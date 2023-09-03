using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Negocio.Vendas
{
    public partial class VendasEscolherCliente : Modelo.ModeloLista
    {
        public VendasEscolherCliente()
        {
            InitializeComponent();
        }

        private bool _Selecionou;
        private string _Codigo;
        private string _Nome;
        private string _RG;
        private string _CPF;
        private string _Pontos;

        public bool Selecionou
        {
            get { return _Selecionou; }
            set { _Selecionou = value; }
        }

        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string RG
        {
            get { return _RG; }
            set { _RG = value; }
        }

        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }

        public string Pontos
        {
            get { return _Pontos; }
            set { _Pontos = value; }
        }

        private void CarregarGrid()
        {
            try
            {
                BLL.Vendas v = new BLL.Vendas();
                string texto = "";
                if (textBox1.Text != "  Pesquisar")/*textbox pesquisar*/
                {
                    texto = textBox1.Text;
                }
                dgv.DataSource = v.ListarClientes(texto).Tables[0];
                dgv.Columns[0].HeaderText = "Código";
                dgv.Columns[1].HeaderText = "Nome";
                dgv.Columns[2].HeaderText = "RG";
                dgv.Columns[3].HeaderText = "CPF";
                dgv.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void Carregar(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void AbrirFormulario(object sender, EventArgs e)
        {
            try
            {
                var botao = (Button)sender;
                Clientes.ClientesDados c = new Clientes.ClientesDados();
                c.Operacao = 1;
                c.lblTitulo.Text += " > " + ((Button)sender).Text;
                c.ShowDialog();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void Escolher(object o, EventArgs e)
        {
            try
            {
                Selecionou = true;
                Codigo = dgv.CurrentRow.Cells[0].Value.ToString();
                Nome = dgv.CurrentRow.Cells[1].Value.ToString();
                RG = dgv.CurrentRow.Cells[2].Value.ToString();
                CPF = dgv.CurrentRow.Cells[3].Value.ToString();
                Pontos = dgv.CurrentRow.Cells[4].Value.ToString();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }









        private void Voltar(object sender, EventArgs e)
        {
            Selecionou = false;
            this.Hide();
        }
    }
}
