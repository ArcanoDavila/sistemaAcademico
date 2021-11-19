using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Common.Cache;
using Common.Util;


namespace DataAccess
{
    public class UserDao : connectionToSql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using(var comand = new MySqlCommand())
                {
                    ToHash512 myHash = new ToHash512();
                    comand.Connection = connection;
                    comand.CommandText = "select * from users where userLogin = @user and userPassword=@password; ";
                    comand.Parameters.AddWithValue("@user", user);
                    comand.Parameters.AddWithValue("@password", myHash.genHash512(pass));
                    comand.CommandType = CommandType.Text;
                    MySqlDataReader reader = comand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.UserLogin = reader.GetString(0);
                            UserLoginCache.UserName = reader.GetString(2);
                            UserLoginCache.UserAdm = reader.GetInt32(3);
                        }
                        return true;
                    } 
                    else
                    {
                        return false;
                    }

                }
            }
        }

        public DataTable MostrarUsuarios()
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var comand = new MySqlCommand())
                {
                    comand.Connection = connection;
                    comand.CommandText = "Select userLogin as Login,userName as Nome from users; ";
                    comand.CommandType = CommandType.Text;
                    MySqlDataReader _reader = comand.ExecuteReader();
                    var dataTable = new DataTable();
                    dataTable.Load(_reader);
                    return dataTable;
                }

            }

        }
        public int EditUser(string name, int adm )
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update users set userName = @user, adm = @adm where userLogin = @login; ";
                    command.Parameters.AddWithValue("@user", name);
                    command.Parameters.AddWithValue("@adm", adm);
                    command.Parameters.AddWithValue("@login", login);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    return command.ExecuteNonQuery();
                }
            }
        }
        public int EditPassword(string login, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update users set userPassword = @pass where userLogin = @login; ";
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@pass", password);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public void InsertUser(string login, string name, string pass,int adm)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO users(userLogin,userPassword,userName,adm) values (@login,@pass,@name,@adm); ";
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@pass", login);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@adm", adm);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }

            }

        }

        public void DeleteUser(string Login)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var comand = new MySqlCommand())
                {
                    comand.Connection = connection;
                    comand.CommandText = "DELETE FROM users WHERE userLogin=@login; ";
                    comand.Parameters.AddWithValue("@login", Login);
                    comand.CommandType = CommandType.Text;
                    comand.ExecuteNonQuery();
                }

            }
        }

    }
}
