using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Negocio.Contas
{
    public partial class ContasLista : Modelo.ModeloLista
    {
        public ContasLista()
        {
            InitializeComponent();
        }

        private void CarregarGrid()
        {
            BLL.Contas c = new BLL.Contas();
            string texto = "";
            if (textBox1.Text != "  Pesquisar")/*textbox pesquisar*/
            {
                texto = textBox1.Text;
            }
            if (rbNaoPagos.Checked)
            {
                dgv.DataSource = c.Listar(texto, false).Tables[0];
                dgv.Columns[0].HeaderText = "Código";
                dgv.Columns[1].HeaderText = "Destino";
                dgv.Columns[3].HeaderText = "Parcelas";
                dgv.Columns[2].HeaderText = "Emissão";
                dgv.Columns[4].HeaderText = "Valor Parcela";
                dgv.Columns[5].HeaderText = "Dt. Vencimento"; 
            }
            else
            {
                dgv.DataSource = c.Listar(texto, true).Tables[0];
                dgv.Columns[0].HeaderText = "Código";
                dgv.Columns[1].HeaderText = "Destino";
                dgv.Columns[3].HeaderText = "Parcelas";
                dgv.Columns[2].HeaderText = "Emissão";
                dgv.Columns[4].HeaderText = "Valor Parcela";
                dgv.Columns[5].HeaderText = "Dt. Pagamento";
                ConferirPagamento();
            }

            

            dgv.AutoResizeColumns();
        }

        private void ConferirPagamento()
        {
            try
            {
                BLL.Contas c = new BLL.Contas();
                int i = 0;
                while (dgv.RowCount > 0 && i != dgv.RowCount)
                {
                    c.Codigo = Convert.ToInt32(dgv.Rows[i].Cells[0].Value);
                    if (!c.RealmentePago())
                    {
                        dgv.Rows.Remove(dgv.Rows[i]);
                        i--;
                    }
                    i++;
                }
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Carregar(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void AbrirFormulario(object sender, EventArgs e)
        {
            ContasDados c = new ContasDados();
            string botao = ((Button)sender).Text;
            if (botao == "Nova Conta")
            {
                c.Operacao = 1;
            }
            else
            {
                c.Operacao = 2;
                c.Codigo = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            }
            c.lblTitulo.Text += " > " + ((Button)sender).Text;
            this.Hide();
            c.ShowDialog();
            CarregarGrid();
        }

        private void RegistrarPagamento(object sender, EventArgs e)
        {
            ContasRegistrarPagamento c = new ContasRegistrarPagamento();
            c.Codigo = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            this.Hide();
            c.ShowDialog();
            CarregarGrid();
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
