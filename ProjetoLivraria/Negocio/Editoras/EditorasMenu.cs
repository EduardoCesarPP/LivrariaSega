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
    public partial class EditorasMenu : Modelo.ModeloMenu
    {
        public EditorasMenu()
        {
            InitializeComponent();
        }

        private void Opcao(object sender, EventArgs e)
        {
            var opcao = (Button)sender;
            if (opcao.Text == "\r\nNossas Editoras")
            {
                this.Hide();
                EditorasLista ed = new EditorasLista();
                ed.ShowDialog();
            }
            else if(opcao.Text == "\r\nPedidos")
            {
                this.Hide();
                Pedidos.PedidosLista p = new Pedidos.PedidosLista();
                p.ShowDialog();
            }
        }
    }
}
