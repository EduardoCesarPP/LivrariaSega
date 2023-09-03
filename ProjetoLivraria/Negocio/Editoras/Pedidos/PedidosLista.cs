using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Negocio.Editoras.Pedidos
{
    public partial class PedidosLista : Modelo.ModeloLista
    {
        public PedidosLista()
        {
            InitializeComponent();
        }

        private void CarregarGrid()
        {
            BLL.Pedidos p = new BLL.Pedidos();
            if (rbNaoEntregues.Checked)
            {
                dgv.DataSource = p.Listar(0).Tables[0];
                dgv.Columns[3].HeaderText = "Valor";
                dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            else
            {
                dgv.DataSource = p.Listar(1).Tables[0];
                dgv.Columns[3].HeaderText = "Entrega";
                dgv.Columns[4].HeaderText = "Valor";
                dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            dgv.Columns[0].HeaderText = "Código";
            dgv.Columns[1].HeaderText = "Editora";
            dgv.Columns[2].HeaderText = "Emissão";

            dgv.AutoResizeColumns();
        }

        private void Carregar(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void AbrirFormulario(object sender, EventArgs e)
        {
            var botao = (Button)sender;
            PedidosDados p = new PedidosDados();
            if (botao.Text == "Novo Pedido")
            {
                p.lblTitulo.Text += " > " + ((Button)sender).Text;
                p.Operacao = 1;
                this.Hide();
                p.ShowDialog();
            }
            else
            {
                try
                {
                    p.Codigo = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    if (botao.Text == "Registrar Chegada")
                    {
                        BLL.Pedidos pe = new BLL.Pedidos();
                        pe.Codigo = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                        pe.RegistrarEntrega();
                        CarregarGrid();
                        return;
                    }
                    else if (botao.Text == "Consultar")
                    {
                        p.Operacao = 3;
                        p.cbEditoras.Enabled = false;
                        p.datDataEmissao.Enabled = false;
                        p.datDataEntrega.Enabled = false;
                        p.gbLivros.Visible = false;
                        p.gbLivrosPedido.Location = p.gbLivros.Location;
                        p.gbLivrosPedido.Size = new Size(670, p.gbLivrosPedido.Size.Height);
                        p.dgvLivrosPedido.Size = new Size(650, p.dgvLivrosPedido.Size.Height);
                        p.pnValor.Location = new Point(650 - p.pnValor.Size.Width, p.pnValor.Location.Y);
                        p.lbltv.Location = new Point(p.pnValor.Location.X, p.lbltv.Location.Y);
                        p.gbRemover.Visible = false;

                        p.btnSalvar.Visible = false;
                        p.btnCancelar.Text = "Sair";

                        p.lblTitulo.Text += " > " + ((Button)sender).Text;
                        this.Hide();
                        p.ShowDialog();
                        CarregarGrid();
                    }
                }
                catch
                {
                    MessageBox.Show("Selecione um registro da tabela");
                }

            }
        }

            private void Voltar(object sender, EventArgs e)
            {
                this.Hide();
            }


        }
    }
