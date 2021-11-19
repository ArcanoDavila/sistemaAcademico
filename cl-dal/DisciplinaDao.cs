using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class DisciplinaDao : connectionToSql
    {
        public DataTable MostrarDisciplina()
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var comand = new MySqlCommand())
                {
                    comand.Connection = connection;
                    comand.CommandText = "Select * from tblDisciplinas; ";
                    comand.CommandType = CommandType.Text;
                    MySqlDataReader _reader = comand.ExecuteReader();
                    var dataTable = new DataTable();
                    dataTable.Load(_reader);
                    return dataTable;
                }

            }

        }

        public void InsertDisciplina(string nome, string sigla, string obs, int idcur,int ID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var comand = new MySqlCommand())
                {
                    comand.Connection = connection;
                    comand.CommandText = "INSERT INTO tblDisciplinas(disid,disnome,dissigla,disobs,curid) values (@disid,@disnome,@dissigla,@disobs,@curid);";
                    comand.Parameters.AddWithValue("@disid", ID);
                    comand.Parameters.AddWithValue("@disnome", nome);
                    comand.Parameters.AddWithValue("@dissigla", sigla);
                    comand.Parameters.AddWithValue("@disobs", obs);
                    comand.Parameters.AddWithValue("@curid", idcur);
                    comand.CommandType = CommandType.Text;
                    comand.ExecuteNonQuery();

                }

            }

        }

        public void EditarDisciplina(string nome, string sigla, string obs, int idcur, int ID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var comand = new MySqlCommand())
                {
                    comand.Connection = connection;
                    comand.CommandText = "UPDATE tblDisciplinas SET curid=@curid,disnome=@disnome,dissigla=@dissigla, disobs=@disobs where disid=@disid;";
                    comand.Parameters.AddWithValue("@disid", ID);
                    comand.Parameters.AddWithValue("@disnome", nome);
                    comand.Parameters.AddWithValue("@dissigla", sigla);
                    comand.Parameters.AddWithValue("@disobs", obs);
                    comand.Parameters.AddWithValue("@curid", idcur);
                    comand.CommandType = CommandType.Text;
                    comand.ExecuteNonQuery();

                }

            }

        }

        public void DeleteDisciplina(int ID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var comand = new MySqlCommand())
                {
                    comand.Connection = connection;
                    comand.CommandText = "DELETE FROM tblDisciplinas WHERE disid=@disid;";
                    comand.Parameters.AddWithValue("@disid", ID);
                    comand.CommandType = CommandType.Text;
                    comand.ExecuteNonQuery();

                }

            }

        }
    }
}
