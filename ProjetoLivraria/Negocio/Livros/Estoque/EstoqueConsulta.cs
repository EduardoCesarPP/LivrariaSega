using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Negocio.Livros.Estoque
{
    public partial class EstoqueConsulta : Modelo.ModeloPrincipal
    {
        public EstoqueConsulta()
        {
            InitializeComponent();
        }

        private void Carregar(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarGrid()
        {
            try
            {
                BLL.Estoque est = new BLL.Estoque();
                if (cbFiltro.Text == "Todos")
                {
                    est.CodigoAutor = Convert.ToInt32(cbFiltro.SelectedValue);
                    dgv.DataSource = est.Listar(0).Tables[0];
                }
                else if (rbAutores.Checked)
                {
                    est.CodigoAutor = Convert.ToInt32(cbFiltro.SelectedValue);
                    dgv.DataSource = est.Listar(1).Tables[0];
                }
                else
                {
                    est.CodigoEditora = Convert.ToInt32(cbFiltro.SelectedValue);
                    dgv.DataSource = est.Listar(2).Tables[0];
                }
                dgv.Columns[0].HeaderText = "Código";
                dgv.Columns[1].HeaderText = "Nome do Livro";
                dgv.Columns[2].HeaderText = "Quantidade no Estoque";
                dgv.Columns[3].HeaderText = "ISBN";
                dgv.AutoResizeColumns();
                OrdenarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void CarregarLista()
        {
            try
            {
                BLL.Estoque est = new BLL.Estoque();
                if (rbAutores.Checked)
                {
                    cbFiltro.DataSource = est.ListarAutores().Tables[0];
                    cbFiltro.ValueMember = "CODIGO_AUTOR";
                    carregou = true;
                    cbFiltro.DisplayMember = "DESCRICAO_AUTOR";
                }
                else
                {
                    cbFiltro.DataSource = est.ListarEditoras().Tables[0];
                    cbFiltro.ValueMember = "CODIGO_EDITORA";
                    carregou = true;
                    cbFiltro.DisplayMember = "NOMEFANTASIA_EDITORA";

                }

                cbFiltro.SelectedIndex = 0;
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void OrdenarGrid()
        {
            try
            {
                if (dgv.RowCount > 0)
                {
                    if (rbCrescente.Checked)
                    {
                        dgv.Sort(dgv.Columns[2], ListSortDirection.Ascending);
                    }
                    else
                    {
                        dgv.Sort(dgv.Columns[2], ListSortDirection.Descending);
                    }
                }
                MudarCores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Ordenar(object sender, EventArgs e)
        {
            OrdenarGrid();
        }

        bool carregou = false;
        private void Mudar(object sender, EventArgs e)
        {
            if (!carregou)
            {
                return;
            }
            CarregarGrid();
        }

        private void Listas(object sender, EventArgs e)
        {
            carregou = false;
            CarregarLista();
        }

        private void MudarCores()
        {
            try
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    int qtde = Convert.ToInt32(row.Cells[2].Value);
                    if (qtde <= 10)
                    {
                        if (qtde <= 5)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.LemonChiffon;
                        }
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Voltar(object sender, EventArgs e)
        {
            this.Hide();
            EstoqueMenu em = new EstoqueMenu();
            em.ShowDialog();
        }
    }
}
