using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Negocio.Contas
{
    public partial class ContasTrocarData : Form
    {
        public ContasTrocarData()
        {
            InitializeComponent();
        }

        private DateTime _Limite1;
        private DateTime _Limite2;

        public DateTime Limite1
        {
            get
            {
                return _Limite1;
            }

            set
            {
                _Limite1 = value;
            }
        }

        public DateTime Limite2
        {
            get
            {
                return _Limite2;
            }

            set
            {
                _Limite2 = value;
            }
        }


        private void Carregar(object sender, EventArgs e)
        {
            dtNova.MinDate = Limite1;
            dtNova.MaxDate = Limite2;
        }

        private void OK(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
