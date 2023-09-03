using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Negocio.Livros.Estoque
{
    public partial class EstoqueMenu : Modelo.ModeloMenu
    {
        public EstoqueMenu()
        {
            InitializeComponent();
        }
        private void Opcao(object sender, EventArgs e)
        {
            var opcao = (Button)sender;
            if (opcao.Text == "\r\nConsulta")
            {
                this.Hide();
                EstoqueConsulta c = new EstoqueConsulta();
                c.ShowDialog();
            }
            else if (opcao.Text == "\r\nHomologação")
            {
                this.Hide();
                EstoqueHomologacao h = new EstoqueHomologacao();
                h.ShowDialog();
            }
        }

        private void btnOpcao1_Click(object sender, EventArgs e)
        {

        }

        private void PbSetaVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LivrosMenu lvr = new LivrosMenu();
            lvr.ShowDialog();
        }
    }
}
