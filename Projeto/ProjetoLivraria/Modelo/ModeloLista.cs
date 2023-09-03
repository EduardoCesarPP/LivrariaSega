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
    public partial class ModeloLista : ModeloPrincipal
    {
        public ModeloLista()
        {
            InitializeComponent();
        }

        private void MouseE(object sender, EventArgs e)
        {
            var botao = (PictureBox)sender;
            int h = botao.Size.Height, w = botao.Size.Width, x = botao.Location.X, y = botao.Location.Y;
            botao.Size = new Size(w+2,h+2);
            botao.Location = new Point(x-1,y-1);
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

        private void pbPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
