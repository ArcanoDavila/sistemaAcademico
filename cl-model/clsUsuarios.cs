using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class clsUsuarios
    {
        private int _idUsers;
        private string _nome;
        private string _email;
        private string _password;

        public int IdUsers { get => _idUsers; set => _idUsers = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
