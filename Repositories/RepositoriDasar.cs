using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace SIKOPI_DOPY_MVC_GREENBEAN.Repositories
{
    public abstract class RepositoriDasar
    {
        protected NpgsqlConnection BuatKoneksi()
        {
            return KoneksiDb.GetConnection();
        }
    }
}