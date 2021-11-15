using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

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
                txt_password.ForeColor = Color.Black;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if(txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.UseSystemPasswordChar = false;
                txt_password.ForeColor = Color.DimGray;
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
                txt_user.ForeColor = Color.Black;
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "User";
                txt_user.ForeColor = Color.Gray;
            }
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if(txt_user.Text != "User")
            {
                if(txt_password.Text != "Password")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txt_user.Text, txt_password.Text);
                    if(validLogin == true)
                    {
                        FormPrincipal mainMenu = new FormPrincipal();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    } else
                    {
                        txt_password.Clear();
                        txt_password.Focus();
                        msgError("Login Invalido");
                    }
                }
                else
                {
                    msgError("Please enter password!");
                }
            }
            else
            {
                msgError("Please enter username!");
            }
        }

        private void msgError(string msg)
        {
            lb_errorLogin.Text = "   " + msg;
            lb_errorLogin.Visible = true;
        }

        private void bt_closeLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txt_password.Clear();
            txt_user.Clear();

            lb_errorLogin.Visible = false;

            txt_password.Text = "Password";
            txt_password.ForeColor = Color.Gray;
            txt_password.UseSystemPasswordChar = false;

            txt_user.Text = "User";
            txt_user.ForeColor = Color.Gray;

            this.Show();
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
                {
                e.Handled = true;
                bt_login.PerformClick();
                }
         }
    }
}
