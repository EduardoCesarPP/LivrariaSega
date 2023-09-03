using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Modelo
{
    public partial class ModeloPrincipal : Form
    {
        public ModeloPrincipal()
        {
            InitializeComponent();
        }

        public static Form Anterior;
        public static int Momento;


        public void FecharHidden()
        {
        //    try
        //    {
        //        if (HiddenForms.Count != 0)
        //        {
        //            foreach (Form f in HiddenForms)
        //            {
        //                MessageBox.Show(f.Name);
        //                this.Show();
        //                f.Close();
        //            }
        //        }
        //        HiddenForms.Add(this);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        //throw;
        //    }
        }

        public void IncluiHidden()
        {
            //try
            //{
            //    HiddenForms.Add(this);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    //throw;
            //}
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
                        Application.Exit();
                    }
                    break;
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

        private void Voltar(object sender, EventArgs e)
        {
            Anterior.Show();
            this.Hide();
        }

        private void Carregar(object sender, EventArgs e)
        {
            lblNomeUsuario.Text = "Bem Vindo(a) " + Sistema.Login.Nome;
            lblFuncaoUsuario.Text = Sistema.Login.Funcao;
            lblNomeUsuario.Location = new Point(panel2.Size.Width - lblNomeUsuario.Size.Width - 30, lblNomeUsuario.Location.Y);
            lblFuncaoUsuario.Location = new Point(lblNomeUsuario.Location.X, lblFuncaoUsuario.Location.Y);
            if (Sistema.Login.Funcao == "Vendedor")
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button8.Enabled = false;
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }















        /*
           01 - Página Inicial
           02 - Clientes Lista
           03 - Clientes Cadastro
           04 - Clientes Alteração
           05 - Clientes Consulta
           06 - Funcionários Inicial
           07 - Funcionários Inicial
           08 - Funcionários Inicial
           09 - Funcionários Inicial
           10 - Página Inicial
           11 - Página Inicial
           12 - Página Inicial
           13 - Página Inicial

       */
    }
}
