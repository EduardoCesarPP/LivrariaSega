using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Negocio.Editoras.Pedidos
{
    public partial class PedidosDados : Modelo.ModeloDados
    {
        public PedidosDados()
        {
            InitializeComponent();
        }

        private int _Operacao;

        public int Operacao
        {
            get { return _Operacao; }
            set { _Operacao = value; }
        }

        private int _Codigo;

        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private void Carregar(object sender, EventArgs e)
        {
            try
            {
                CarregarEditoras();
                if (Operacao == 1) //Cadastro
                {
                    txtCodigo.Visible = false;
                    lblCodigo.Visible = false;
                    cbEditoras.Location = txtCodigo.Location;
                    lblEditoras.Location = lblCodigo.Location;
                    cbEditoras.Size = new Size(550, cbEditoras.Size.Height);
                    datDataEntrega.Visible = false;
                    lblEntrega.Visible = false;
                    datDataEmissao.Location = datDataEntrega.Location;
                    lblEmissao.Location = lblEntrega.Location;
                }
                else
                {
                    BLL.Pedidos p = new BLL.Pedidos();
                    p.Codigo = Codigo;
                    txtCodigo.Text = Codigo.ToString();
                    SqlDataReader dr;
                    dr = p.Consultar();
                    if (dr.Read())
                    {
                        datDataEmissao.Value = Convert.ToDateTime(dr["EMISSAO_PEDIDO"].ToString());
                        cbEditoras.SelectedValue = Convert.ToInt32(dr["CODIGO_EDITORA"].ToString());
                        if ((dr["ENTREGA_PEDIDO"].ToString()) != "")
                        {
                            datDataEntrega.Value = Convert.ToDateTime(dr["ENTREGA_PEDIDO"].ToString());
                        }
                        else
                        {
                            datDataEntrega.Visible = false;
                            lblEntrega.Visible = false;
                        }
                        dgvLivrosPedido.DataSource = p.ListarLivroPedido().Tables[0];
                        dgvLivrosPedido.Columns[0].HeaderText = "Cod.";
                        dgvLivrosPedido.Columns[1].HeaderText = "Nome";
                        dgvLivrosPedido.Columns[2].HeaderText = "Qtde.";
                        dgvLivrosPedido.Columns[3].HeaderText = "Valor Unitário";
                        dgvLivrosPedido.Columns[4].HeaderText = "Valor Total";
                        dgvLivrosPedido.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvLivrosPedido.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvLivrosPedido.AutoResizeColumns();
                        dgvLivrosPedido.DefaultCellStyle.Font = new Font("Century Gothic", 9);
                        dgvLivrosPedido.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9);
                        CalcularValor(4);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private bool dadoscarregados;
        private void CarregarEditoras()
        {
            try
            {
                BLL.Pedidos p = new BLL.Pedidos();
                cbEditoras.DataSource = p.ListarEditoras().Tables[0];
                cbEditoras.ValueMember = "CODIGO_EDITORA";
                dadoscarregados = true;
                cbEditoras.DisplayMember = "NOMEFANTASIA_EDITORA";
                if (cbEditoras.Items.Count > 0)
                {
                    cbEditoras.SelectedIndex = 0;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Salvar(object sender, EventArgs e)
        {
            try
            {
                //VALIDAR LISTA
                if (dgvLivrosPedido.Rows.Count == 0)
                {
                    MessageBox.Show("É necessário adicionar ao menos um livro para registrar o pedido.");
                    return;
                }

                BLL.Pedidos p = new BLL.Pedidos();
                p.CodigoEditora = Convert.ToInt32(cbEditoras.SelectedValue);
                p.Incluir();
                foreach (DataGridViewRow row in dgvLivrosPedido.Rows)
                {
                    p.CodigoLivro = Convert.ToInt32(row.Cells[0].Value);
                    p.QuantidadeLivro = Convert.ToInt32(row.Cells[2].Value);
                    p.ValorLivro = (Convert.ToDouble(row.Cells[3].Value.ToString().Replace("R$ ", "")) / Convert.ToDouble(row.Cells[2].Value)).ToString();
                    p.IncluirLivroPedido();
                }
                MessageBox.Show("Pedido registrado com sucesso.");
                PedidosLista pl = new PedidosLista();
                pl.ShowDialog();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Voltar(object sender, EventArgs e)
        {
            PedidosLista pl = new PedidosLista();
            this.Hide();
            pl.ShowDialog();
            
        }

        private void ListarLivrosEditora(object sender, EventArgs e)
        {
            if (dadoscarregados)
            {
                if (dgvLivrosPedido.RowCount > 0)
                {
                    if (MessageBox.Show("Ao trocar de editora os livros já selecionados serão retirados da lista.\nDeseja continuar?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        dgvLivrosPedido.Rows.Clear();
                        CalcularValor(3);
                    }

                }
                BLL.Pedidos p = new BLL.Pedidos();
                dgvLivros.DataSource = p.ListarLivrosEditora(Convert.ToInt32(cbEditoras.SelectedValue)).Tables[0];
                dgvLivros.Columns[0].HeaderText = "Cod.";
                dgvLivros.Columns[1].HeaderText = "Nome";
                dgvLivros.Columns[2].HeaderText = "Preço";
                dgvLivros.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvLivros.AutoResizeColumns();
                dgvLivros.DefaultCellStyle.Font = new Font("Century Gothic", 9);
                dgvLivros.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9);
            }
        }

        private void Adicionar(object sender, EventArgs e)
        {
            try
            {


                if (dgvLivros.RowCount != 0)
                {
                    if (dgvLivrosPedido.RowCount != 0)
                    {
                        foreach (DataGridViewRow row in dgvLivrosPedido.Rows)
                        {
                            if (Convert.ToInt32(row.Cells[0].Value) == Convert.ToInt32(dgvLivros.CurrentRow.Cells[0].Value))
                            {
                                row.Cells[3].Value = "R$ " + (Convert.ToDouble(row.Cells[3].Value.ToString().Replace("R$ ", "").Replace(".", ",")) + Convert.ToDouble(nudQuantidade.Value) * Convert.ToDouble(dgvLivros.CurrentRow.Cells[2].Value.ToString().Replace("R$ ", "").Replace(".", ","))).ToString("0.00");
                                row.Cells[2].Value = Convert.ToDecimal(row.Cells[2].Value) + nudQuantidade.Value;
                                CalcularValor(3);
                                return;
                            }
                        }
                    }
                    if (this.dgvLivrosPedido.ColumnCount == 0)
                    {
                        dgvLivrosPedido.Columns.Add("Cód.", "Cód.");
                        dgvLivrosPedido.Columns.Add("Nome", "Nome");
                        dgvLivrosPedido.Columns.Add("Qtde.", "Qtde.");
                        dgvLivrosPedido.Columns.Add("Preço", "Preço");
                    }

                    var index = dgvLivrosPedido.Rows.Add();
                    dgvLivrosPedido.Rows[index].Cells["Cód."].Value = Convert.ToInt32(dgvLivros.CurrentRow.Cells[0].Value);
                    dgvLivrosPedido.Rows[index].Cells["Nome"].Value = dgvLivros.CurrentRow.Cells[1].Value.ToString();
                    dgvLivrosPedido.Rows[index].Cells["Qtde."].Value = nudQuantidade.Value;
                    dgvLivrosPedido.Rows[index].Cells["Preço"].Value = "R$ " + (Convert.ToDouble(nudQuantidade.Value) * Convert.ToDouble(dgvLivros.CurrentRow.Cells[2].Value.ToString().Replace("R$ ", "").Replace(".", ","))).ToString("0.00");

                    dgvLivrosPedido.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvLivrosPedido.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvLivrosPedido.DefaultCellStyle.Font = new Font("Century Gothic", 9);
                    dgvLivrosPedido.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9);
                    dgvLivrosPedido.AutoResizeColumns();

                    CalcularValor(3);
                    nudQuantidade.Value = 1;
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
                foreach (DataGridViewRow row in dgvLivrosPedido.Rows)
                {
                    valor += Convert.ToDouble(row.Cells[col].Value.ToString().Replace("R$ ", "").Replace(".",","));
                }
                lblValor.Text = "R$ " + valor.ToString("0.00");


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
            if (dgvLivrosPedido.RowCount != 0)
            {
                double valorunitario = Convert.ToDouble(dgvLivrosPedido.CurrentRow.Cells[3].Value.ToString().Replace("R$ ", "")) / Convert.ToDouble(dgvLivrosPedido.CurrentRow.Cells[2].Value);
                decimal qtd = Convert.ToDecimal(dgvLivrosPedido.CurrentRow.Cells[2].Value);
                if (chkTodos.Checked || qtd == nudQuantidadeRemover.Value)
                {
                    dgvLivrosPedido.Rows.Remove(dgvLivrosPedido.CurrentRow);
                    CalcularValor(3);
                }
                else
                {
                    dgvLivrosPedido.CurrentRow.Cells[3].Value = "R$ " + (Convert.ToDouble(dgvLivrosPedido.CurrentRow.Cells[3].Value.ToString().Replace("R$ ", "")) - (valorunitario * Convert.ToDouble(nudQuantidadeRemover.Value))).ToString("0.00");
                    dgvLivrosPedido.CurrentRow.Cells[2].Value = qtd - nudQuantidadeRemover.Value;
                    CalcularValor(3);
                }
                dgvLivrosPedido.AutoResizeColumns();
            }
        }

        private void LimitarRemocao(object sender, DataGridViewCellEventArgs e)
        {
            nudQuantidadeRemover.Maximum = Convert.ToDecimal(dgvLivrosPedido.CurrentRow.Cells[2].Value);
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
    }
}
