using Npgsql;

namespace SIKOPI_DOPY_MVC_GREENBEAN
{
    public static class KoneksiDb
    {
        private static readonly string connectionString =
            "Host=localhost;Port=5432;Database=sikopi_dopy_mvc_greenbean;Username=postgres;Password=faraday";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}