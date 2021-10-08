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
    public partial class FormPeriodo : Form
    {
        clsPeriodos objetoPeriodo = new clsPeriodos();
        private bool Editar = false;

        public FormPeriodo()
        {
            InitializeComponent();
        }

        private void FormPeriodo_Load(object sender, EventArgs e)
        {
            MostrarProdutos();
        }

        private void MostrarProdutos()
        {
            dg_periodos.DataSource = objetoPeriodo.MostrarPeriodos();
        }

        private void bt_salvarPeriodo_Click(object sender, EventArgs e)
        {
            if(Editar == false)
            {
                try
                {
                    objetoPeriodo.InsertPeriodo(txt_pernome.Text, txt_persigla.Text, txt_IdPeriodo.Text);
                    MessageBox.Show("Adicionado com Sucesso");
                    MostrarProdutos();
                    txt_IdPeriodo.Clear();
                    txt_pernome.Clear();
                    txt_persigla.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar dados por: " + ex);
                }
            }
            
            if(Editar == true)
            {
                try
                {
                    objetoPeriodo.EditarPeriodo(txt_pernome.Text, txt_persigla.Text, txt_IdPeriodo.Text);
                    MessageBox.Show("Atualizado com Sucesso");
                    MostrarProdutos();
                    txt_IdPeriodo.Clear();
                    txt_pernome.Clear();
                    txt_persigla.Clear();
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
            if(dg_periodos.SelectedRows.Count > 0)
            {
                Editar = true;
                txt_IdPeriodo.Text = dg_periodos.CurrentRow.Cells["perid"].Value.ToString();
                txt_pernome.Text = dg_periodos.CurrentRow.Cells["pernome"].Value.ToString();
                txt_persigla.Text = dg_periodos.CurrentRow.Cells["persigla"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecione uma linha na tabela Periodos");
            }
        }

        private void bt_deletePeriodo_Click(object sender, EventArgs e)
        {
            if (dg_periodos.SelectedRows.Count > 0)
            {
                try
                {
                    var id = dg_periodos.CurrentRow.Cells["perid"].Value.ToString();
                    objetoPeriodo.DeletePeriodo(id);
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
