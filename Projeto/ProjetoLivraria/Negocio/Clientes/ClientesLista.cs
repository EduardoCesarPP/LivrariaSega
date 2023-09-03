using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Negocio.Clientes
{
    public partial class ClientesLista : Modelo.ModeloLista
    {
        public ClientesLista()
        {
            InitializeComponent();
        }

        private void CarregarGrid()
        {
            BLL.Clientes c = new BLL.Clientes();
            string texto = "";
            if (textBox1.Text != "  Pesquisar")/*textbox pesquisar*/
            {
                texto = textBox1.Text;
            }
            dgv.DataSource = c.Listar(texto).Tables[0];
            dgv.Columns[0].HeaderText = "Código";
            dgv.Columns[1].HeaderText = "Nome";
            dgv.Columns[2].HeaderText = "RG";
            dgv.Columns[3].HeaderText = "CPF";
            dgv.AutoResizeColumns();
        }

        private void Carregar(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void AbrirFormulario(object sender, EventArgs e)
        {
            var botao = (Button)sender;
            ClientesDados c = new ClientesDados();
            if (botao.Text == "Cadastrar")
            {
                c.lblTitulo.Text += " > " + ((Button)sender).Text;
                c.Operacao = 1;
                this.Hide();
                c.ShowDialog();
            }
            else
            {
                try
                {
                    c.Codigo = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                    if (botao.Text == "Alterar")
                    {
                        c.Operacao = 2;
                    }
                    else if (botao.Text == "Consultar")
                    {
                        c.Operacao = 3;
                        c.txtNome.ReadOnly = true;
                        c.txtCPF.ReadOnly = true;
                        c.txtRG.ReadOnly = true;
                        c.datDataNascimento.Enabled = false;
                        c.txtTelefone.ReadOnly = true;
                        c.txtTelefone2.ReadOnly = true;
                        c.txtEmail.ReadOnly = true;

                        c.gbTel1.BackColor = Color.Gainsboro;
                        c.gbTel2.BackColor = Color.Gainsboro;
                        c.gbTel1.Text = "Telefone 1";
                        c.gbTel2.Text = "Telefone 2";
                        c.rb1.Visible = false;
                        c.rb2.Visible = false;
                        c.rb3.Visible = false;
                        c.rb4.Visible = false;
                        c.txtTelefone.Location = new Point(10, 20);
                        c.txtTelefone2.Location = new Point(10, 20);
                        c.lblEmail.Location = new Point(280, 20);
                        c.txtEmail.Location = new Point(280, 45);
                        c.gbContato.Size = new Size(c.gbContato.Size.Width, c.gbContato.Size.Height - 60);
                        c.gbEndereco.Location = new Point(c.gbEndereco.Location.X, c.gbEndereco.Location.Y - 60);
                        c.txtCEP.ReadOnly = true;
                        c.txtNumero.ReadOnly = true;
                        c.txtComplemento.ReadOnly = true;
                        c.btnSalvar.Visible = false;
                        c.btnCancelar.Text = "Sair";
                        c.btnCancelar.Location = new Point(c.btnCancelar.Location.X, c.btnCancelar.Location.Y - 60);
                        c.label1.Location = new Point(c.label1.Location.X, c.label1.Location.Y - 60); //label que esta marcando o final dos forms com barra de rolagem
                    }

                    c.lblTitulo.Text += " > " + ((Button)sender).Text;
                    this.Hide();
                    c.ShowDialog();
                    CarregarGrid();
                }
                catch
                {
                    MessageBox.Show("Selecione um registro da tabela");
                }
            }
        }

        private void Sair(object sender, EventArgs e)
        {

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
