using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class CursoDao : connectionToSql
    {
        public DataTable MostrarCurso()
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var comand = new MySqlCommand())
                {
                    comand.Connection = connection;
                    comand.CommandText = "Select * from tblCursos";
                    comand.CommandType = CommandType.Text;
                    MySqlDataReader _reader = comand.ExecuteReader();
                    var dataTable = new DataTable();
                    dataTable.Load(_reader);
                    return dataTable;
                }

            }

        }

        public void InsertCurso(string nome, string sigla, int ID, string obs,int idPer)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var comand = new MySqlCommand())
                {
                    comand.Connection = connection;
                    comand.CommandText = "INSERT INTO tblCursos(curid,curnome,cursigla,curobs,perid) values (@curid,@curnome,@cursigla,@curobs,@perid)";
                    comand.Parameters.AddWithValue("@curid", ID);
                    comand.Parameters.AddWithValue("@curnome", nome);
                    comand.Parameters.AddWithValue("@cursigla", sigla);
                    comand.Parameters.AddWithValue("@curobs", obs);
                    comand.Parameters.AddWithValue("@perid", idPer);
                    comand.CommandType = CommandType.Text;
                    comand.ExecuteNonQuery();

                }

            }

        }

        public void EditarCurso(string nome, string sigla, int ID, string obs, int idPer)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var comand = new MySqlCommand())
                {
                    comand.Connection = connection;
                    comand.CommandText = "UPDATE tblCursos SET curnome=@curnome,cursigla=@cursigla,curobs=@curobs,perid=@perid where curid=@curid;";
                    comand.Parameters.AddWithValue("@curid", ID);
                    comand.Parameters.AddWithValue("@curnome", nome);
                    comand.Parameters.AddWithValue("@cursigla", sigla);
                    comand.Parameters.AddWithValue("@curobs", obs);
                    comand.Parameters.AddWithValue("@perid", idPer);
                    comand.CommandType = CommandType.Text;
                    comand.ExecuteNonQuery();

                }

            }

        }

        public void DeleteCurso(int ID)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var comand = new MySqlCommand())
                {
                    comand.Connection = connection;
                    comand.CommandText = "DELETE FROM tblCursos WHERE curid=@curid;";
                    comand.Parameters.AddWithValue("@curid", ID);
                    comand.CommandType = CommandType.Text;
                    comand.ExecuteNonQuery();

                }

            }

        }
    }
 }
