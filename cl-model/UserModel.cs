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
        private int adm;
        private string name;
        private string password;
        private string login;

        public UserModel(int adm, string name, string password, string login)
        {
            this.adm = adm;
            this.name = name;
            this.password = password;
            this.login = login;
        }

        public UserModel()
        {

        }
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }

        public DataTable MostrarUsuarios()
        {
            DataTable _table = new DataTable();
            _table = userDao.MostrarUsuarios();
            return _table;
        }

        public string editUser()
        {
            try { 
            userDao.EditUser(name, password, adm, login);
            LoginUser(login, password);
                return "Usuario Alterado!";
            }
            catch (Exception ex) {
                return "Alteraçao Invalida1" + ex;
            }
        }
    }
}
