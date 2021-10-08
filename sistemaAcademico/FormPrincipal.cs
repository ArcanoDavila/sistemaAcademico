using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace sistemaAcademico
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();

        }


        private Form activeForm = null;
     
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bt_cursos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCursos());
        }

        private void bt_closePrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadUserData()
        {
            lb_UserLogin.Text = "" + UserLoginCache.UserLogin;
            lb_UserName.Text = "" + UserLoginCache.UserName;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pn_header_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bt_periodo_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPeriodo());
        }
    }
}
