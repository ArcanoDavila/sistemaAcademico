using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        //Atributos
        private string password;
        private string login;

        public UserModel(string password, string login)
        {
            this.password = password;
            this.login = login;
        }

        public UserModel() { }
        public DataTable MostrarUsuarios()
        {
            DataTable _table = new DataTable();
            _table = userDao.MostrarUsuarios();
            return _table;
        }

        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }

        public string EditUser(string name, bool adm)
        {
            int cadm = adm ? 1 : 0;
            try { 
            userDao.EditUser(name, cadm);
            LoginUser(login, password);
                return "Usuario Alterado!";
            }
            catch (Exception ex) {
                return "Alteraçao Invalida1" + ex;
            }
        }

        public string EditPassword(string login, string password)
        {
            try
            {
            userDao.EditPassword(login, password);
                return "Senha Alterada!";
            }
            catch(Exception ex)
            {
                return "Nao foi possivel alterar." + ex;
            }
        }
        public void DeleteUser(string login)
        {
            userDao.DeleteUser(login);
        }


    }
}
