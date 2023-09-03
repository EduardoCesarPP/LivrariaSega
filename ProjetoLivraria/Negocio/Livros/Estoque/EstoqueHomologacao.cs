using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Negocio.Livros.Estoque
{
    public partial class EstoqueHomologacao : Modelo.ModeloPrincipal
    {
        public EstoqueHomologacao()
        {
            InitializeComponent();
        }

        string caminho = "";

        private void Carregar(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void CarregarGrid()
        {
            try
            {
                while (dgv.Columns.Count>0)
                {
                    dgv.Columns.Clear();
                }
                if (caminho == "")
                {
                    return;
                }
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
                dgv.Columns[3].Visible = false;
                dgv.AutoResizeColumns();
                Comparar();
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
                    int estoque = Convert.ToInt32(row.Cells[2].Value);
                    int homolog = Convert.ToInt32(row.Cells[3].Value);
                    if (estoque != homolog)
                    {
                        if (estoque > homolog)
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

        private void AbrirArquivo(object o, EventArgs e)
        {
            try
            {
                f.Filter = "Arquivos de texto (*.txt)|*.TXT";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    caminho = f.FileName;
                    CarregarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        struct Lista
        {
            public int Codigo;
            public String Nome;
            public int QuantidadeE;
            public int QuantidadeH;
        };

        List<Lista> dadosLista;

        private void Comparar()
        {
            try
            {
                dadosLista = new List<Lista>();
                string[] linhas = File.ReadAllLines(caminho);
                int i = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (String linha in linhas)
                    {
                        string isbn = linha.Substring(0, 12);
                        string qtde = linha.Substring(13, linha.Length - 13);
                        if (isbn == row.Cells[3].Value.ToString())
                        {
                            Lista l = new Estoque.EstoqueHomologacao.Lista
                            {
                                Codigo = Convert.ToInt32(row.Cells[0].Value),
                                Nome = Convert.ToString(row.Cells[1].Value),
                                QuantidadeE = Convert.ToInt32(row.Cells[2].Value),
                                QuantidadeH = Convert.ToInt32(qtde)
                            };
                            dadosLista.Add(l);
                        }

                    }
                }

                dgv.DataSource = null;
                dgv.Columns.Add("Código", "Cód.");
                dgv.Columns.Add("Nome", "Livro");
                dgv.Columns.Add("Estoque", "Qtd. Estoque");
                dgv.Columns.Add("Homologação", "Qtd. Homologação");

                foreach (Lista d in dadosLista)
                {
                    var index = dgv.Rows.Add();
                    dgv.Rows[index].Cells[0].Value = d.Codigo;
                    dgv.Rows[index].Cells[1].Value = d.Nome;
                    dgv.Rows[index].Cells[2].Value = d.QuantidadeE;
                    dgv.Rows[index].Cells[3].Value = d.QuantidadeH;
                    dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgv.Columns[2].MinimumWidth = 130;
                    dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgv.Columns[3].MinimumWidth = 180;
                }
                dgv.AutoResizeColumns();
                OrdenarGrid();

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
