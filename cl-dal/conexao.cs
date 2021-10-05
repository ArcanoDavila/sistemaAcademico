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
    public class conexao
    {
        private static MySqlConnection _Conexao;
        private static MySqlCommand _Comando;
        private static MySqlDataAdapter _Adaptador;
        private static MySqlDataReader _Reader;
        private static DataTable _Tabela;
        private static String _StringConn =
            "server = 2.57.88.4; port = 3306;database = u975059562_ADS; user = u975059562_project, password = @Unip2021*";

        public static MySqlConnection OpenConn()
        {
            try {
                _Conexao = new MySqlConnection(_StringConn);
                _Conexao.Open();
                return _Conexao;
            }
            catch(Exception)
            {
                return null;
                throw;
            }
        }

        public static void CloseConn()
        {
            if(_Conexao.State == ConnectionState.Open)
            {
                _Conexao.Close();
            }
        }
    }
}
