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
                        "server = 2.57.88.4;" +
                        "port = 3306; " +
                        "user = u975059562_project; " +
                        "password = @Unip2021*;" +
                        "database = u975059562_ADS;";
        
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
