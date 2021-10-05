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
    public partial class FormPrincipal : Form
    {
        bool mover = false;
        Point posicao_inicial;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_inicial = new Point(e.X, e.Y);
        }

        private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - posicao_inicial.X, novo.Y - posicao_inicial.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_menu_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
