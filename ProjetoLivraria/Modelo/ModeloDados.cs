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
    public partial class ModeloDados : ModeloPrincipal
    {
        public ModeloDados()
        {
            InitializeComponent();
            pnPrincipal.AutoScroll = false;
            pnPrincipal.HorizontalScroll.Enabled = false;
            pnPrincipal.HorizontalScroll.Visible = false;
            pnPrincipal.HorizontalScroll.Maximum = 0;
            pnPrincipal.AutoScroll = true;
        }

        private void ModeloDados_Load(object sender, EventArgs e)
        {
            
        }
    }
}
