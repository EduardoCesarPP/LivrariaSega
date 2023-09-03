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
    public partial class LivrosMenu : Modelo.ModeloMenu
    {
        public LivrosMenu()
        {
            InitializeComponent();
        }

        private void Carregar(object sender, EventArgs e)
        {
        }

        private void Opcao(object sender, EventArgs e)
        {
            var opcao = (Button)sender;
            if (opcao.Text == "\r\nNossos Livros")
            {
                LivrosLista l = new LivrosLista();
                this.Hide();
                l.ShowDialog();
            }
            else if (opcao.Text == "\r\nEstoque")
            {
                Estoque.EstoqueMenu est = new Estoque.EstoqueMenu();
                this.Hide();
                est.ShowDialog();
            }
        }




    }
}
