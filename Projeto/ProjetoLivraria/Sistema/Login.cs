using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Sistema
{
    public partial class Login : Form
    {
        public Login()
        {
            //this.BackColor = Color.BurlyWood;
            //TransparencyKey = Color.BurlyWood;
            InitializeComponent();
        }


        public static int Codigo;
        public static string Nome;
        public static string Funcao;


        private void Aumentar(object sender, EventArgs e)
        {
            var botao = (PictureBox)sender;
            int h = botao.Size.Height, w = botao.Size.Width, x = botao.Location.X, y = botao.Location.Y;
            botao.Size = new Size(w + 2, h + 2);
            botao.Location = new Point(x - 1, y - 1);
        }

        private void Diminuir(object sender, EventArgs e)
        {
            var botao = (PictureBox)sender;
            int h = botao.Size.Height, w = botao.Size.Width, x = botao.Location.X, y = botao.Location.Y;
            botao.Size = new Size(w - 2, h - 2);
            botao.Location = new Point(x + 1, y + 1);
        }

        private void MostarSenha(object sender, EventArgs e)
        {
            if (this.txtSenha.PasswordChar == '*')
            {
                pbMostra.Image = ProjetoLivraria.Properties.Resources.btnMostrarSenha2;
                if (this.txtSenha.ForeColor != Color.Gray)
                {
                    this.txtSenha.PasswordChar = '\0';
                }
            }
            else
            {
                pbMostra.Image = ProjetoLivraria.Properties.Resources.btnEsconderSenha;
                if (this.txtSenha.ForeColor != Color.Gray)
                {
                    this.txtSenha.PasswordChar = '*';
                }
            }
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == " Login")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = " Login";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == " Senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
                txtSenha.PasswordChar = '*';
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                if (pbMostra.Image == ProjetoLivraria.Properties.Resources.btnEsconderSenha)
                {
                    txtSenha.Text = " Senha";
                    txtSenha.ForeColor = Color.Gray;
                    txtSenha.PasswordChar = '\0';
                }
            }
        }

        private void Logar(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtUsuario.Text != " Login" && txtSenha.Text != "" && txtSenha.Text != " Senha")
            {
                BLL.Login l = new BLL.Login();
                l.Usuario = txtUsuario.Text;
                l.Senha = txtSenha.Text;
                if (l.Logar())
                {
                    Codigo = l.Codigo;
                    Nome = l.Nome;
                    Funcao = l.Funcao;
                    if (txtSenha.Text == "123456")
                    {
                        string NovaSenha;
                        NovaSenha = Interaction.InputBox("Identificamos que este é seu primeiro acesso.\nPor favor insira sua nova senha.", "Nova senha", "", 650, 300);
                        if (NovaSenha == "")
                        {
                            txtUsuario.Text = "";
                            txtSenha.Text = "";
                            return;
                        }
                        while (NovaSenha == txtUsuario.Text || NovaSenha == "123456")
                        {
                            if (NovaSenha == "")
                            {
                                txtUsuario.Text = "";
                                txtSenha.Text = "";
                                return;
                            }

                            NovaSenha = Interaction.InputBox("A senha deve ser diferente do usuário e de 123456.\nPor favor insira sua nova senha.", "Nova senha", "", -1, -1);
                        }


                        l.AlterarSenha(NovaSenha);
                        Negocio.Livros.LivrosMenu li = new Negocio.Livros.LivrosMenu();
                        this.Hide();
                        li.ShowDialog();

                    }
                    else
                    {
                        Negocio.Livros.LivrosMenu li = new Negocio.Livros.LivrosMenu();
                        this.Hide();
                        li.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Erro Usuário/Senha");
                }
            }
        }

        private void Cancelar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PressEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtSenha.Text.Length == 0)
                {
                    txtSenha.Focus();
                }
                else
                {
                    EventArgs ee = new EventArgs();
                    Logar(sender, ee);
                }
            }
        }
    }
}
