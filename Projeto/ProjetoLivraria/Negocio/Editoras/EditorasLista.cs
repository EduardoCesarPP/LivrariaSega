using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Negocio.Editoras
{
    public partial class EditorasLista : Modelo.ModeloLista
    {
        public EditorasLista()
        {
            InitializeComponent();
        }

        private void CarregarGrid()
        {
            BLL.Editoras f = new BLL.Editoras();
            string texto = "";
            if (textBox1.Text != "  Pesquisar")/*textbox pesquisar*/
            {
                texto = textBox1.Text;
            }
            dgv.DataSource = f.Listar(texto).Tables[0];
            dgv.Columns[0].HeaderText = "Código";
            dgv.Columns[1].HeaderText = "Nome";
            dgv.Columns[2].HeaderText = "CNPJ";
            dgv.AutoResizeColumns();
        }

        private void Carregar(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void AbrirFormulario(object sender, EventArgs e)
        {
            var botao = (Button)sender;
            EditorasDados ed = new EditorasDados();
            if (botao.Text == "Cadastrar")
            {
                ed.Operacao = 1;
            }
            else
            {
                ed.Codigo = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                if (botao.Text == "Alterar")
                {
                    ed.Operacao = 2;
                }
                else if (botao.Text == "Consultar")
                {
                    ed.Operacao = 3;
                    ed.txtNomeFantasia.ReadOnly = true;
                    ed.txtRazaoSocial.ReadOnly = true;
                    ed.txtCNPJ.ReadOnly = true;
                    ed.txtTelefone.ReadOnly = true;
                    ed.txtTelefone2.ReadOnly = true;
                    ed.txtEmail.ReadOnly = true;

                    ed.gbTel1.BackColor = Color.Gainsboro;
                    ed.gbTel2.BackColor = Color.Gainsboro;
                    ed.gbTel1.Text = "Telefone 1";
                    ed.gbTel2.Text = "Telefone 2";
                    ed.rb1.Visible = false;
                    ed.rb2.Visible = false;
                    ed.rb3.Visible = false;
                    ed.rb4.Visible = false;
                    ed.txtTelefone.Location = new Point(10, 20);
                    ed.txtTelefone2.Location = new Point(10, 20);
                    ed.lblEmail.Location = new Point(280, 20);
                    ed.txtEmail.Location = new Point(280, 45);
                    ed.gbContato.Size = new Size(ed.gbContato.Size.Width, ed.gbContato.Size.Height - 60);
                    ed.gbEndereco.Location = new Point(ed.gbEndereco.Location.X, ed.gbEndereco.Location.Y - 60);
                    ed.txtCEP.ReadOnly = true;
                    ed.txtNumero.ReadOnly = true;
                    ed.txtComplemento.ReadOnly = true;
                    ed.btnSalvar.Visible = false;
                    ed.btnCancelar.Text = "Sair";
                    ed.btnCancelar.Location = new Point(ed.btnCancelar.Location.X, ed.btnCancelar.Location.Y - 60);
                    ed.label2.Location = new Point(ed.label2.Location.X, ed.label2.Location.Y - 60); //label que esta marcando o final dos forms com barra de rolagem
                }
            }
            Modelo.ModeloPrincipal.Anterior = this;// mp = new Modelo.ModeloPrincipal();
            this.Hide();
            ed.lblTitulo.Text += " > " + ((Button)sender).Text;
            this.Hide();
            ed.ShowDialog();
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
