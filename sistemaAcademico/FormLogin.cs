using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaAcademico
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if(txt_password.Text == "Password")
            {
                txt_password.Text = "";
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if(txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "User")
            {
                txt_user.Text = "";
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "User";
            }
        }
    }
}
