using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace DataAccess
{
    public abstract class connectionToSql
    {
        private readonly string connectionString;

        public connectionToSql()
        {
            connectionString =
                        "SslMode=none;" +
                        "server = 212.1.211.51;" +
                        "port = 3306; " +
                        "user = u323887216_project; " +
                        "password = @Unip2021*;" +
                        "database = u323887216_ADS;";
        
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
