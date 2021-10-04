using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

using cl_model;

namespace cl_dal
{
    public class connPeriodo
    {
        private MySqlConnection _conn;
        private MySqlCommand comand;


        public void Salvar(clsPeriodos paramPeriodos)
        {
            _conn = conexao.OpenConn();
            comand = new MySqlCommand();
            comand.Connection = _conn;

            conexao.CloseConn();
        }

        public void Atualizar(clsPeriodos paramPeriodos)
        {

        }

        public void Excluir(int paramCodigo)
        {

        }

        public DataTable ListarTodos()
        {
            return null;
        }

        public List<clsPeriodos> ListarTodosArray()
        {
            return null;
        }


    }
}
