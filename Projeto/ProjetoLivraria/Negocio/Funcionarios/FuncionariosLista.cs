using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Negocio.Funcionarios
{
    public partial class FuncionariosLista : Modelo.ModeloLista
    {
        public FuncionariosLista()
        {
            InitializeComponent();
        }

        private void CarregarGrid()
        {
            BLL.Funcionarios f = new BLL.Funcionarios();
            string texto = "";
            if (textBox1.Text != "  Pesquisar")/*textbox pesquisar*/
            {
                texto = textBox1.Text;
            }
            dgv.DataSource = f.Listar(texto).Tables[0];
            dgv.Columns[0].HeaderText = "Código";
            dgv.Columns[1].HeaderText = "Nome";
            dgv.Columns[2].HeaderText = "RG";
            dgv.Columns[3].HeaderText = "Função";
            dgv.AutoResizeColumns();
        }

        private void Carregar(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void AbrirFormulario(object sender, EventArgs e)
        {
            var botao = (Button)sender;
            FuncionariosDados f = new FuncionariosDados();
            if (botao.Text == "Cadastrar")
            {
                f.Operacao = 1;
            }
            else
            {
                f.Codigo = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                if (botao.Text == "Alterar")
                {
                    f.Operacao = 2;
                }
                else if (botao.Text == "Consultar")
                {
                    f.Operacao = 3;
                    f.txtNome.ReadOnly = true;
                    f.txtCPF.ReadOnly = true;
                    f.txtRG.ReadOnly = true;
                    f.datDataNascimento.Enabled = false;
                    //f.txtNome.ReadOnly = true;
                    f.txtSalario.ReadOnly = true;
                    f.txtTelefone.ReadOnly = true;
                    f.txtTelefone2.ReadOnly = true;
                    f.txtEmail.ReadOnly = true;

                    f.gbTel1.BackColor = Color.Gainsboro;
                    f.gbTel2.BackColor = Color.Gainsboro;
                    f.gbTel1.Text = "Telefone 1";
                    f.gbTel2.Text = "Telefone 2";
                    f.rb1.Visible = false;
                    f.rb2.Visible = false;
                    f.rb3.Visible = false;
                    f.rb4.Visible = false;
                    f.txtTelefone.Location = new Point(10, 20);
                    f.txtTelefone2.Location = new Point(10, 20);
                    f.lblEmail.Location = new Point(280, 20);
                    f.txtEmail.Location = new Point(280, 45);
                    f.gbContato.Size = new Size(f.gbContato.Size.Width, f.gbContato.Size.Height - 60);
                    f.gbEndereco.Location = new Point(f.gbEndereco.Location.X, f.gbEndereco.Location.Y - 60);
                    f.txtCEP.ReadOnly = true;
                    f.txtNumero.ReadOnly = true;
                    f.txtComplemento.ReadOnly = true;
                    f.btnSalvar.Visible = false;
                    f.btnCancelar.Text = "Sair";
                    f.btnCancelar.Location = new Point(f.btnCancelar.Location.X, f.btnCancelar.Location.Y - 60);
                    f.label2.Location = new Point(f.label2.Location.X, f.label2.Location.Y - 60); //label que esta marcando o final dos forms com barra de rolagem
                }
            }
            Modelo.ModeloPrincipal.Anterior = this;// mp = new Modelo.ModeloPrincipal();
            this.Hide();
            f.lblTitulo.Text += " > " + ((Button)sender).Text;
            f.ShowDialog();
            CarregarGrid();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            int i = fc.Count-1;
            if (fc[i].Name == "FuncionarioDados")
            {
                MessageBox.Show(fc[i].Name);
            }
            
        }

        private void Voltar(object sender, EventArgs e)
        {
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
