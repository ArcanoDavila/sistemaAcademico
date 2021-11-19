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
using Common.Cache;

namespace sistemaAcademico
{
    public partial class FormUser : Form
    {
        UserModel userModel = new UserModel();
        private bool Editar = false;
        public FormUser()
        {
            InitializeComponent();
        }

        private void MostrarUsuaruios()
        {
            dg.DataSource = userModel.MostrarUsuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            MostrarUsuaruios();
        }


    }
}
