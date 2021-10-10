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
    public partial class FormDisciplina : Form
    {
        clsDisciplina objetoDisciplina = new clsDisciplina();
        private bool Editar = false;
        public FormDisciplina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDisciplinas_Load(object sender, EventArgs e)
        {
            MostrarProdutos();
        }

        private void MostrarProdutos()
        {
            dg.DataSource = objetoDisciplina.MostrarDisciplina();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoDisciplina.InsertDisciplina(txt_nome.Text, txt_sigla.Text, txt_obs.Text, txt_Id.Text, txt_curid.Text);
                    MessageBox.Show("Adicionado com Sucesso");
                    MostrarProdutos();
                    txt_Id.Clear();
                    txt_nome.Clear();
                    txt_sigla.Clear();
                    txt_obs.Clear();
                    txt_curid.Clear();
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
                    objetoDisciplina.EditarDisciplina(txt_nome.Text, txt_sigla.Text, txt_obs.Text, txt_Id.Text, txt_curid.Text);
                    MessageBox.Show("Atualizado com Sucesso");
                    MostrarProdutos();
                    txt_Id.Clear();
                    txt_nome.Clear();
                    txt_sigla.Clear();
                    txt_obs.Clear();
                    txt_curid.Clear();
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
                txt_Id.Text = dg.CurrentRow.Cells["disid"].Value.ToString();
                txt_nome.Text = dg.CurrentRow.Cells["disnome"].Value.ToString();
                txt_sigla.Text = dg.CurrentRow.Cells["dissigla"].Value.ToString();
                txt_obs.Text = dg.CurrentRow.Cells["disobs"].Value.ToString();
                txt_curid.Text = dg.CurrentRow.Cells["curid"].Value.ToString();
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
                    var id = dg.CurrentRow.Cells["disid"].Value.ToString();
                    objetoDisciplina.DeleteDisciplina(id);
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
