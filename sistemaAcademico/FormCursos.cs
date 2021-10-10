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
    public partial class FormCursos : Form
    {
        clsCursos objetoCursos = new clsCursos();
        private bool Editar = false;

        public FormCursos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCursos_Load(object sender, EventArgs e)
        {
            MostrarProdutos();
        }

        private void MostrarProdutos()
        {
            dg.DataSource = objetoCursos.MostrarCurso();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCursos.InsertCurso(txt_nome.Text, txt_sigla.Text,txt_obs.Text ,txt_Id.Text,txt_perid.Text);
                    MessageBox.Show("Adicionado com Sucesso");
                    MostrarProdutos();
                    txt_Id.Clear();
                    txt_nome.Clear();
                    txt_sigla.Clear();
                    txt_obs.Clear();
                    txt_perid.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar dados por: " + ex);
                }
            }

            if (Editar == true)
            {
                try
                {
                    objetoCursos.EditarCurso(txt_nome.Text, txt_sigla.Text, txt_obs.Text, txt_Id.Text, txt_perid.Text);
                    MessageBox.Show("Atualizado com Sucesso");
                    MostrarProdutos();
                    txt_Id.Clear();
                    txt_nome.Clear();
                    txt_sigla.Clear();
                    txt_obs.Clear();
                    txt_perid.Clear();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Atualizar dados por: " + ex);
                }
            }

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            if (dg.SelectedRows.Count > 0)
            {
                Editar = true;
                txt_Id.Text = dg.CurrentRow.Cells["curid"].Value.ToString();
                txt_nome.Text = dg.CurrentRow.Cells["curnome"].Value.ToString();
                txt_sigla.Text = dg.CurrentRow.Cells["cursigla"].Value.ToString();
                txt_obs.Text = dg.CurrentRow.Cells["curobs"].Value.ToString();
                txt_perid.Text = dg.CurrentRow.Cells["perid"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecione uma linha na tabela Periodos");
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (dg.SelectedRows.Count > 0)
            {
                try
                {
                    var id = dg.CurrentRow.Cells["curid"].Value.ToString();
                    objetoCursos.DeleteCurso(id);
                    MostrarProdutos();
                    MessageBox.Show("Excluido com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Excluir dados por: " + ex);
                }

            }
            else
            {
                MessageBox.Show("Selecione uma linha na tabela Periodos");
            }
        }

    }
}
