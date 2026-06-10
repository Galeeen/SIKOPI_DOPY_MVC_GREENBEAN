using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using SIKOPI_DOPY_MVC_GREENBEAN.Models;

namespace SIKOPI_DOPY_MVC_GREENBEAN.Repositories
{
    public class RepositoriUser : RepositoriDasar, IRepositoriUser
    {
        public User? AmbilByUsername(string username)
        {
            using var conn = BuatKoneksi();
            conn.Open();

            string query = @"
                SELECT
                    id,
                    username,
                    password_hash,
                    name,
                    role
                FROM users
                WHERE username = @username;
            ";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new User
                {
                    Id = Convert.ToInt64(reader["id"]),
                    Username = reader["username"].ToString() ?? string.Empty,
                    PasswordHash = reader["password_hash"].ToString() ?? string.Empty,
                    Name = reader["name"].ToString() ?? string.Empty,
                    Role = reader["role"].ToString() ?? string.Empty
                };
            }

            return null;
        }
    }
}