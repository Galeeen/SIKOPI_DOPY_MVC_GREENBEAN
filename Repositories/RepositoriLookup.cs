using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using SIKOPI_DOPY_MVC_GREENBEAN.Models;
namespace SIKOPI_DOPY_MVC_GREENBEAN.Repositories
{
    public class RepositoriLookup : RepositoriDasar, IRepositoriLookup
    {
        public List<Lookup> AmbilBeanTypes()
        {
            return AmbilLookup("SELECT id, name FROM bean_types ORDER BY name");
        }

        public List<Lookup> AmbilProcessMethods()
        {
            return AmbilLookup("SELECT id, name FROM process_methods ORDER BY name");
        }

        public List<Lookup> AmbilGrades()
        {
            return AmbilLookup("SELECT id, name FROM grades ORDER BY name");
        }

        private List<Lookup> AmbilLookup(string query)
        {
            List<Lookup> data = new List<Lookup>();

            using var conn = BuatKoneksi();
            conn.Open();

            using var cmd = new NpgsqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                data.Add(new Lookup
                {
                    Id = reader.GetInt64(0),
                    Name = reader.GetString(1)
                });
            }

            return data;
        }
    }
}