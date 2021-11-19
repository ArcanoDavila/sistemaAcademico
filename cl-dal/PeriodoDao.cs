using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using Common.Cache;


namespace DataAccess
{
    public class PeriodoDao : connectionToSql
    {
        public DataTable MostrarPeriodo()
        {
            using ( var connection = GetConnection())
            {
                connection.Open();

                using ( var comand = new MySqlCommand())
                {
                    comand.Connection = connection;
                    comand.CommandText = "select * from tblPeriodo ; ";
                    comand.CommandType = CommandType.Text;
                    MySqlDataReader _reader = comand.ExecuteReader();
                    var dataTable = new DataTable();
                    dataTable.Load(_reader);
                    return dataTable; 
                }
                
            }
            
        }

        public void InsertPeriodo(string nome, string sigla, int ID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var comand = new MySqlCommand())
                {
                    comand.Connection = connection;
                    comand.CommandText = "INSERT INTO tblPeriodo(perid,pernome,persigla) values (@perid,@pernome,@persigla)";
                    comand.Parameters.AddWithValue("@perid", ID);
                    comand.Parameters.AddWithValue("@pernome", nome);
                    comand.Parameters.AddWithValue("@persigla", sigla);
                    comand.CommandType = CommandType.Text;
                    comand.ExecuteNonQuery();
                    
                }

            }

        }

        public void EditarPeriodo(string nome, string sigla, int ID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var comand = new MySqlCommand())
                {
                    comand.Connection = connection;
                    comand.CommandText = "UPDATE tblPeriodo SET perid=@perid,pernome=@pernome,persigla=@persigla where perid=@perid;";
                    comand.Parameters.AddWithValue("@perid", ID);
                    comand.Parameters.AddWithValue("@pernome", nome);
                    comand.Parameters.AddWithValue("@persigla", sigla);
                    comand.CommandType = CommandType.Text;
                    comand.ExecuteNonQuery();

                }

            }

        }

        public void DeletePeriodo(int ID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var comand = new MySqlCommand())
                {
                    comand.Connection = connection;
                    comand.CommandText = "DELETE FROM tblPeriodo WHERE perid=@perid;";
                    comand.Parameters.AddWithValue("@perid", ID);
                    comand.CommandType = CommandType.Text;
                    comand.ExecuteNonQuery();
                }

            }
        }



    }
}
