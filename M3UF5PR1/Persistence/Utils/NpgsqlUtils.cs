using Npgsql;
using Microsoft.Extensions.Configuration;
using M03UF5PR1.Models;

namespace M03UF5PR1.Persistence.Utils
{
    public class NpgsqlUtils
    {
        // Obrir connexió a la bbdd
        public static string OpenConnection()
        {
            string path = @"appsettings.json";
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(path, optional: false, reloadOnChange: true)
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }
    }
}
