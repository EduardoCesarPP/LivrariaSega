using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Negocio.Livros
{
    public partial class LivrosLista : Modelo.ModeloLista
    {
        public LivrosLista()
        {
            InitializeComponent();
        }

        private void CarregarGrid()
        {
            BLL.Livros l = new BLL.Livros();
            string texto = "";
            if (textBox1.Text != "  Pesquisar")/*textbox pesquisar*/
            {
                texto = textBox1.Text;
            }
            dgv.DataSource = l.Listar(texto).Tables[0];
            dgv.Columns[0].HeaderText = "Código";
            dgv.Columns[1].HeaderText = "Nome";
            dgv.Columns[2].HeaderText = "Autor(a)";
            dgv.Columns[3].HeaderText = "Valor de compra";
            dgv.Columns[4].HeaderText = "Valor de venda";
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[3].MinimumWidth = 150;
            dgv.Columns[4].MinimumWidth = 142;
            dgv.AutoResizeColumns();
        }

        private void Carregar(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void AbrirFormulario(object sender, EventArgs e)
        {
            var botao = (Button)sender;
            LivrosDados l = new LivrosDados();
            if (botao.Text == "Cadastrar")
            {
                l.lblTitulo.Text += " > " + ((Button)sender).Text;
                l.Operacao = 1;
                this.Hide();
                l.ShowDialog();
            }
            else
            {
                try
                {
                    l.Codigo = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    if (botao.Text == "Alterar")
                    {
                        l.Operacao = 2;
                    }
                    else if (botao.Text == "Consultar")
                    {
                        l.Operacao = 3;
                        l.txtNome.ReadOnly = true;
                        l.nudEdicao.Enabled = false;
                        l.nudPaginas.Enabled = false;
                        l.txtValorCompra.ReadOnly = true;
                        l.txtValorVenda.ReadOnly = true;

                        l.cbAutores.DropDownStyle = ComboBoxStyle.Simple;
                        l.cbAutores.Enabled = false;
                        l.cbAutores.Size = new Size(l.cbAutores.Size.Width + 32, l.cbAutores.Size.Height);
                        l.cbEditoras.DropDownStyle = ComboBoxStyle.Simple;
                        l.cbEditoras.Enabled = false;
                        l.cbEditoras.Size = new Size(l.cbEditoras.Size.Width + 32, l.cbEditoras.Size.Height);
                        l.cbIdioma.DropDownStyle = ComboBoxStyle.Simple;
                        l.cbIdioma.Enabled = false;
                        l.cbIdioma.Size = new Size(l.cbIdioma.Size.Width + 27, l.cbIdioma.Size.Height);
                        l.cbGenero.DropDownStyle = ComboBoxStyle.Simple;
                        l.cbGenero.Enabled = false;
                        l.cbGenero.Size = new Size(l.cbGenero.Size.Width + 32, l.cbGenero.Size.Height);

                        l.pbCapa.Location = new Point(l.pbCapa.Location.X + 32, l.pbCapa.Location.Y);
                        l.lblCapa.Location = new Point(l.lblCapa.Location.X + 32, l.lblCapa.Location.Y);

                        l.pbAddAutor.Visible = false;
                        l.pbAddEditoras.Visible = false;
                        l.pbAddIdioma.Visible = false;
                        l.pbAddGenero.Visible = false;
                        l.pbAddCapa.Visible = false;

                        l.txtISBN.ReadOnly = true;

                        l.btnSalvar.Visible = false;
                        l.btnCancelar.Text = "Sair";

                    }

                    l.lblTitulo.Text += " > " + ((Button)sender).Text;
                    this.Hide();
                    l.ShowDialog();
                    CarregarGrid();
                }
                catch
                {
                    MessageBox.Show("Selecione um registro da tabela");
                }
            }
        }

        private void Voltar(object sender, EventArgs e)
        {
            LivrosMenu l = new LivrosMenu();
            l.Show();
            this.Close();
        }

        private void Pesquisar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CarregarGrid();
            }
        }
    }
}
