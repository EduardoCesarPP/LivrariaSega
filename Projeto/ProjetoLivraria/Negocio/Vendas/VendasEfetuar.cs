using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Negocio.Vendas
{
    public partial class VendasEfetuar : Form
    {
        public VendasEfetuar()
        {
            InitializeComponent();
            TransparencyKey = Color.Fuchsia;
            pnPrincipal.AutoScroll = true;
        }

        private int _CodCliente;

        public int CodCliente
        {
            get { return _CodCliente; }
            set { _CodCliente = value; }
        }



        private void MouseE(object sender, EventArgs e)
        {
            var botao = (PictureBox)sender;
            int h = botao.Size.Height, w = botao.Size.Width, x = botao.Location.X, y = botao.Location.Y;
            botao.Size = new Size(w + 2, h + 2);
            botao.Location = new Point(x - 1, y - 1);
        }

        private void MouseD(object sender, EventArgs e)
        {
            var botao = (PictureBox)sender;
            int h = botao.Size.Height, w = botao.Size.Width, x = botao.Location.X, y = botao.Location.Y;
            botao.Size = new Size(w - 2, h - 2);
            botao.Location = new Point(x + 1, y + 1);
        }

        private void Carregar(object sender, EventArgs e)
        {
            CarregarLivros();
            if (Sistema.Login.Funcao == "Vendedor")
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button8.Enabled = false;
            }
        }

        private void CarregarLivros()
        {
            try
            {
                string texto = "";
                if (txtPesquisar.Text != "  Pesquisar")/*textbox pesquisar*/
                {
                    texto = txtPesquisar.Text;
                }
                BLL.Vendas v = new BLL.Vendas();
                dgvLivros.DataSource = v.ListarLivrosDoEstoque(texto).Tables[0];
                dgvLivros.Columns[0].HeaderText = "Nome do Livro";
                dgvLivros.Columns[0].MinimumWidth = 325;
                dgvLivros.Columns[1].Visible = false; //AUTOR
                dgvLivros.Columns[2].Visible = false; //QUANTIDADE
                dgvLivros.Columns[3].Visible = false; //PÁGINAS
                dgvLivros.Columns[4].Visible = false; //EDIÇÃO
                dgvLivros.Columns[5].Visible = false; //CAPA
                dgvLivros.Columns[6].Visible = false; //PREÇO
                dgvLivros.Columns[7].Visible = false; //GÊNERO
                dgvLivros.Columns[8].Visible = false; //EDITORA
                dgvLivros.Columns[9].Visible = false; //IDIOMA
                dgvLivros.Columns[10].Visible = false; //CODIGO
                dgvLivros.DefaultCellStyle.Font = new Font("Century Gothic", 10);
                dgvLivros.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
                Caracteristicas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Menu(object sender, EventArgs e)
        {
            var opcao = (Button)sender;
            switch (opcao.Text)
            {
                case "   Clientes":
                    Negocio.Clientes.ClientesLista c = new Negocio.Clientes.ClientesLista();
                    c.Show();
                    this.Hide();
                    break;
                case "   Funcionários":
                    Negocio.Funcionarios.FuncionariosLista f = new Negocio.Funcionarios.FuncionariosLista();
                    f.Show();
                    this.Hide();
                    break;
                case "   Livros":
                    Negocio.Livros.LivrosMenu l = new Negocio.Livros.LivrosMenu();
                    l.Show();
                    this.Hide();
                    break;
                case "   Editoras":
                    Negocio.Editoras.EditorasMenu ed = new Negocio.Editoras.EditorasMenu();
                    ed.Show();
                    this.Hide();
                    break;
                case "   Vendas":
                    Negocio.Vendas.VendasMenu v = new Negocio.Vendas.VendasMenu();
                    v.Show();
                    this.Hide();
                    break;
                case "   Contas":
                    Negocio.Contas.ContasLista co = new Negocio.Contas.ContasLista();
                    co.Show();
                    this.Hide();
                    break;
                case "   Financeiro":
                    Negocio.Financeiro.FinanceiroDados fi = new Negocio.Financeiro.FinanceiroDados();
                    fi.Show();
                    this.Hide();
                    break;
                case "   Fechar":
                    if (MessageBox.Show("Deseja realmente fechar a aplicação?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    break;
            }
        }

        int desconto = 0;

        private void EscolherCliente(object sender, EventArgs e)
        {
            try
            {
                VendasEscolherCliente ec = new VendasEscolherCliente();
                this.Visible = false;
                ec.ShowDialog();
                if (ec.Selecionou)
                {
                    btnEscolherCliente.Visible = false;
                    gbDadosCliente.Visible = true;
                    lblCodigoCliente.Text = Convert.ToInt32(ec.Codigo).ToString("D6");
                    lblNomeCliente.Text = ec.Nome;
                    lblRGCliente.Text = ec.RG;
                    lblCPFCliente.Text = ec.CPF;
                    lblPontuacaoCliente.Text = Convert.ToInt32(ec.Pontos).ToString("D2");

                    int pontos = Convert.ToInt32(ec.Pontos);
                    switch (pontos)
                    {
                        case 10:
                        case 15:
                            desconto = 5;
                            break;
                        case 20:
                        case 25:
                            desconto = 10;
                            break;
                        case 30:
                        case 35:
                            desconto = 15;
                            break;
                        default:
                            if (pontos < 10)
                            {
                                desconto = 0;
                            }
                            else
                            {
                                desconto = 20;
                            }
                            break;
                    }
                    CalcularValor(3);
                }
                this.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Pagamento(object sender, EventArgs e)
        {
            BLL.Vendas v = new BLL.Vendas();
            v.CodigoFuncionario = Sistema.Login.Codigo;
            v.Desconto = desconto;
            if (gbDadosCliente.Visible == true)
            {
                v.CodigoCliente = Convert.ToInt32(lblCodigoCliente.Text);
                v.Incluir(true);
            }
            else
            {
                v.Incluir(false);
            }

            foreach (DataGridViewRow row in dgvLivrosVenda.Rows)
            {
                v.CodigoLivro = Convert.ToInt32(row.Cells[0].Value);
                v.QuantidadeLivro = Convert.ToInt32(row.Cells[2].Value);
                v.ValorUnitario = (Convert.ToDouble(row.Cells[3].Value.ToString().Remove(0, 3)) / Convert.ToDouble(row.Cells[2].Value)).ToString("0.00");
                v.IncluirItens();
            }

            VendasPagamento p = new VendasPagamento();
            p.Valor = Convert.ToDouble(lblValor.Text.Replace("R$ ", ""));
            this.Hide();
            p.ShowDialog();
        }

        private void Cancelar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Fechando este formulário, os dados não salvos serão perdidos.\nDeseja continuar?", "Sair", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
        }

        private void Caracteristicas()
        {
            lblAutor.Text = dgvLivros.CurrentRow.Cells[1].Value.ToString();
            lblPaginas.Text = dgvLivros.CurrentRow.Cells[3].Value.ToString();
            lblEdicao.Text = dgvLivros.CurrentRow.Cells[4].Value.ToString();
            lblPreco.Text = dgvLivros.CurrentRow.Cells[6].Value.ToString();
            lblGenero.Text = dgvLivros.CurrentRow.Cells[7].Value.ToString();
            lblEditora.Text = dgvLivros.CurrentRow.Cells[8].Value.ToString();
            lblIdioma.Text = dgvLivros.CurrentRow.Cells[9].Value.ToString();
            pbCapa.ImageLocation = dgvLivros.CurrentRow.Cells[5].Value.ToString();

            if (dgvLivrosVenda.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvLivrosVenda.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == Convert.ToInt32(dgvLivros.CurrentRow.Cells[10].Value))
                    {
                        decimal q = Convert.ToDecimal(dgvLivros.CurrentRow.Cells[2].Value) - Convert.ToDecimal(row.Cells[2].Value);
                        if (q == 0)
                        {
                            MessageBox.Show("Não é possível adicionar mais unidades desse livro, todas já foram adicionadas.");
                            btnAdicionar.Enabled = false;
                            return;
                        }
                        btnAdicionar.Enabled = true;
                        nudQuantidade.Maximum = q;
                        return;
                    }
                }
            }
            btnAdicionar.Enabled = true;
            nudQuantidade.Maximum = Convert.ToDecimal(dgvLivros.CurrentRow.Cells[2].Value);
        }

        private void MudarInfo(object sender, DataGridViewCellEventArgs e)
        {
            Caracteristicas();
        }

        private void BoardE(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            if (txt.Text == "  Pesquisar")
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }

        private void BoardL(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            if (txt.Text == "")
            {
                txt.Text = "  Pesquisar";
                txt.ForeColor = Color.Gray;
            }
        }

        private void CancelarCliente(object sender, EventArgs e)
        {
            try
            {
                btnEscolherCliente.Visible = true;
                gbDadosCliente.Visible = false;
                lblCodigoCliente.Text = "";
                lblNomeCliente.Text = "";
                lblRGCliente.Text = "";
                lblCPFCliente.Text = "";
                lblPontuacaoCliente.Text = "";
                desconto = 0;
                lblDesconto.Text = "00% - R$ 0,00";
                CalcularValor(3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Adicionar(object sender, EventArgs e)
        {
            try
            {
                if (dgvLivros.RowCount != 0)
                {
                    if (dgvLivrosVenda.RowCount != 0)
                    {
                        foreach (DataGridViewRow row in dgvLivrosVenda.Rows)
                        {
                            if (Convert.ToInt32(row.Cells[0].Value) == Convert.ToInt32(dgvLivros.CurrentRow.Cells[10].Value))
                            {
                                row.Cells[3].Value = "R$ " + (Convert.ToDouble(row.Cells[3].Value.ToString().Replace("R$ ", "").Replace(".", ",")) + Convert.ToDouble(nudQuantidade.Value) * Convert.ToDouble(dgvLivros.CurrentRow.Cells[2].Value.ToString().Replace("R$ ", "").Replace(".", ","))).ToString("0.00");
                                row.Cells[2].Value = Convert.ToDecimal(row.Cells[2].Value) + nudQuantidade.Value;
                                CalcularValor(3);
                                nudQuantidade.Value = 1;
                                Caracteristicas();
                                return;
                            }
                        }
                    }
                    if (this.dgvLivrosVenda.ColumnCount == 0)
                    {
                        dgvLivrosVenda.Columns.Add("Cód.", "Cód.");
                        dgvLivrosVenda.Columns.Add("Nome", "Nome");
                        dgvLivrosVenda.Columns.Add("Qtde.", "Qtde.");
                        dgvLivrosVenda.Columns.Add("Preço", "Preço");
                    }

                    var index = dgvLivrosVenda.Rows.Add();
                    dgvLivrosVenda.Rows[index].Cells["Cód."].Value = Convert.ToInt32(dgvLivros.CurrentRow.Cells[10].Value);
                    dgvLivrosVenda.Rows[index].Cells["Nome"].Value = dgvLivros.CurrentRow.Cells[0].Value.ToString();
                    dgvLivrosVenda.Rows[index].Cells["Qtde."].Value = nudQuantidade.Value;
                    dgvLivrosVenda.Rows[index].Cells["Preço"].Value = "R$ " + (Convert.ToDouble(nudQuantidade.Value) * Convert.ToDouble(dgvLivros.CurrentRow.Cells[6].Value.ToString().Replace("R$ ", "").Replace(".", ","))).ToString("0.00");

                    dgvLivrosVenda.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvLivrosVenda.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvLivrosVenda.DefaultCellStyle.Font = new Font("Century Gothic", 10);
                    dgvLivrosVenda.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
                    dgvLivrosVenda.AutoResizeColumns();

                    CalcularValor(3);
                    nudQuantidade.Value = 1;
                    Caracteristicas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void CalcularValor(int col)
        {
            try
            {
                double valor = 0;
                foreach (DataGridViewRow row in dgvLivrosVenda.Rows)
                {
                    valor += Convert.ToDouble(row.Cells[col].Value.ToString().Replace("R$ ", "").Replace(".", ","));
                }
                double valorDesconto = desconto * valor / 100;
                lblDesconto.Text = desconto.ToString("D2") + "% - R$ " + valorDesconto.ToString("0.00");
                if (lblDesconto.Text == "00% - R$ 0,00")
                {
                    lblValor.Text = "R$ " + valor.ToString("0.00");
                }
                else
                {

                    lblValor.Text = "R$ " + (valor - (valor * desconto / 100)).ToString("0.00");
                }



                int l = (Convert.ToInt32(pnValor.Size.Width) - Convert.ToInt32(lblValor.Size.Width)) / 2;
                lblValor.Location = new Point(l, lblValor.Location.Y);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Remover(object sender, EventArgs e)
        {
            if (dgvLivrosVenda.RowCount != 0)
            {
                int cod = Convert.ToInt32(dgvLivrosVenda.CurrentRow.Cells[0].Value);
                double valorunitario = Convert.ToDouble(dgvLivrosVenda.CurrentRow.Cells[3].Value.ToString().Replace("R$ ", "")) / Convert.ToDouble(dgvLivrosVenda.CurrentRow.Cells[2].Value);
                decimal qtd = Convert.ToDecimal(dgvLivrosVenda.CurrentRow.Cells[2].Value);
                if (chkTodos.Checked || qtd == nudQuantidadeRemover.Value)
                {
                    dgvLivrosVenda.Rows.Remove(dgvLivrosVenda.CurrentRow);
                    CalcularValor(3);
                }
                else
                {
                    dgvLivrosVenda.CurrentRow.Cells[3].Value = "R$ " + (Convert.ToDouble(dgvLivrosVenda.CurrentRow.Cells[3].Value.ToString().Replace("R$ ", "")) - (valorunitario * Convert.ToDouble(nudQuantidadeRemover.Value))).ToString("0.00");
                    dgvLivrosVenda.CurrentRow.Cells[2].Value = qtd - nudQuantidadeRemover.Value;
                    CalcularValor(3);
                }
                dgvLivrosVenda.AutoResizeColumns();
                if (cod == Convert.ToInt32(dgvLivros.CurrentRow.Cells[10].Value))
                {
                    Caracteristicas();
                }
            }
        }

        private void LimitarRemocao(object sender, DataGridViewCellEventArgs e)
        {
            nudQuantidadeRemover.Maximum = Convert.ToDecimal(dgvLivrosVenda.CurrentRow.Cells[2].Value);
        }

        private void Todos(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                nudQuantidadeRemover.Enabled = false;
            }
            else
            {
                nudQuantidadeRemover.Enabled = true;
            }
        }
    }
}
