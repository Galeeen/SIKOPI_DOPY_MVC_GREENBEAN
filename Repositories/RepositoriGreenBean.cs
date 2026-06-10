using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;
using SIKOPI_DOPY_MVC_GREENBEAN.Models;

namespace SIKOPI_DOPY_MVC_GREENBEAN.Repositories
{
    public class RepositoriGreenBean : RepositoriDasar, IRepositoriGreenBean
    {
        public DataTable AmbilSemua()
        {
            DataTable table = new DataTable();

            using var conn = BuatKoneksi();
            conn.Open();

            string query = @"
                SELECT
                    gb.id,
                    gb.name AS nama_green_bean,
                    gb.origin AS asal,
                    bt.name AS jenis,
                    pm.name AS metode_proses,
                    g.name AS grade,
                    gb.stock_kg,
                    gb.price_per_kg,
                    gb.created_at
                FROM green_beans gb
                JOIN bean_types bt ON gb.bean_type_id = bt.id
                LEFT JOIN process_methods pm ON gb.process_method_id = pm.id
                LEFT JOIN grades g ON gb.grade_id = g.id
                ORDER BY gb.id DESC;
            ";

            using var cmd = new NpgsqlCommand(query, conn);
            using var adapter = new NpgsqlDataAdapter(cmd);

            adapter.Fill(table);

            return table;
        }

        public GreenBean? AmbilById(long id)
        {
            using var conn = BuatKoneksi();
            conn.Open();

            string query = @"
                SELECT
                    id,
                    name,
                    origin,
                    bean_type_id,
                    process_method_id,
                    grade_id,
                    stock_kg,
                    price_per_kg
                FROM green_beans
                WHERE id = @id;
            ";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new GreenBean
                {
                    Id = Convert.ToInt64(reader["id"]),
                    Name = reader["name"].ToString() ?? string.Empty,
                    Origin = reader["origin"] == DBNull.Value ? null : reader["origin"].ToString(),
                    BeanTypeId = Convert.ToInt64(reader["bean_type_id"]),
                    ProcessMethodId = reader["process_method_id"] == DBNull.Value
                        ? null
                        : Convert.ToInt64(reader["process_method_id"]),
                    GradeId = reader["grade_id"] == DBNull.Value
                        ? null
                        : Convert.ToInt64(reader["grade_id"]),
                    StockKg = Convert.ToDecimal(reader["stock_kg"]),
                    PricePerKg = Convert.ToDecimal(reader["price_per_kg"])
                };
            }

            return null;
        }

        public void Tambah(GreenBean greenBean)
        {
            using var conn = BuatKoneksi();
            conn.Open();

            using var transaction = conn.BeginTransaction();

            try
            {
                string query = @"
                    INSERT INTO green_beans
                    (
                        name,
                        origin,
                        bean_type_id,
                        process_method_id,
                        grade_id,
                        stock_kg,
                        price_per_kg
                    )
                    VALUES
                    (
                        @name,
                        @origin,
                        @bean_type_id,
                        @process_method_id,
                        @grade_id,
                        @stock_kg,
                        @price_per_kg
                    )
                    RETURNING id;
                ";

                using var cmd = new NpgsqlCommand(query, conn, transaction);

                cmd.Parameters.AddWithValue("@name", greenBean.Name);
                cmd.Parameters.AddWithValue("@origin", (object?)greenBean.Origin ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@bean_type_id", greenBean.BeanTypeId);

                cmd.Parameters.AddWithValue(
                    "@process_method_id",
                    greenBean.ProcessMethodId.HasValue
                        ? (object)greenBean.ProcessMethodId.Value
                        : DBNull.Value
                );

                cmd.Parameters.AddWithValue(
                    "@grade_id",
                    greenBean.GradeId.HasValue
                        ? (object)greenBean.GradeId.Value
                        : DBNull.Value
                );

                cmd.Parameters.AddWithValue("@stock_kg", greenBean.StockKg);
                cmd.Parameters.AddWithValue("@price_per_kg", greenBean.PricePerKg);

                long idBaru = Convert.ToInt64(cmd.ExecuteScalar());

                string queryStok = @"
                    INSERT INTO stock_movements
                    (
                        direction,
                        category,
                        green_bean_id,
                        qty,
                        unit,
                        reference
                    )
                    VALUES
                    (
                        'IN',
                        'GREEN',
                        @green_bean_id,
                        @qty,
                        'Kg',
                        @reference
                    );
                ";

                using var cmdStok = new NpgsqlCommand(queryStok, conn, transaction);
                cmdStok.Parameters.AddWithValue("@green_bean_id", idBaru);
                cmdStok.Parameters.AddWithValue("@qty", greenBean.StockKg);
                cmdStok.Parameters.AddWithValue("@reference", "Input Green Bean");
                cmdStok.ExecuteNonQuery();

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void Ubah(GreenBean greenBean)
        {
            using var conn = BuatKoneksi();
            conn.Open();

            string query = @"
                UPDATE green_beans
                SET
                    name = @name,
                    origin = @origin,
                    bean_type_id = @bean_type_id,
                    process_method_id = @process_method_id,
                    grade_id = @grade_id,
                    stock_kg = @stock_kg,
                    price_per_kg = @price_per_kg
                WHERE id = @id;
            ";

            using var cmd = new NpgsqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", greenBean.Id);
            cmd.Parameters.AddWithValue("@name", greenBean.Name);
            cmd.Parameters.AddWithValue("@origin", (object?)greenBean.Origin ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@bean_type_id", greenBean.BeanTypeId);

            cmd.Parameters.AddWithValue(
                "@process_method_id",
                greenBean.ProcessMethodId.HasValue
                    ? (object)greenBean.ProcessMethodId.Value
                    : DBNull.Value
            );

            cmd.Parameters.AddWithValue(
                "@grade_id",
                greenBean.GradeId.HasValue
                    ? (object)greenBean.GradeId.Value
                    : DBNull.Value
            );

            cmd.Parameters.AddWithValue("@stock_kg", greenBean.StockKg);
            cmd.Parameters.AddWithValue("@price_per_kg", greenBean.PricePerKg);

            cmd.ExecuteNonQuery();
        }

        public void Hapus(long id)
        {
            using var conn = BuatKoneksi();
            conn.Open();

            using var transaction = conn.BeginTransaction();

            try
            {
                string hapusStok = @"
                    DELETE FROM stock_movements
                    WHERE category = 'GREEN'
                    AND green_bean_id = @id;
                ";

                using var cmdStok = new NpgsqlCommand(hapusStok, conn, transaction);
                cmdStok.Parameters.AddWithValue("@id", id);
                cmdStok.ExecuteNonQuery();

                string hapusGreen = @"
                    DELETE FROM green_beans
                    WHERE id = @id;
                ";

                using var cmd = new NpgsqlCommand(hapusGreen, conn, transaction);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}