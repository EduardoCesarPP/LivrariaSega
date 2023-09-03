using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Negocio.Vendas
{
    public partial class VendasDados : Modelo.ModeloDados
    {
        public VendasDados()
        {
            InitializeComponent();
        }

        private int _Codigo;

        public int Codigo
        {
            get
            {
                return _Codigo;
            }

            set
            {
                _Codigo = value;
            }
        }

        private void Carregar(object sender, EventArgs e)
        {
            txtCodigo.Text = Codigo.ToString();
            BLL.Vendas v = new BLL.Vendas();
            v.Codigo = Codigo;
            SqlDataReader dr;
            dr = v.Consultar();
            if (dr.Read())
            {
                datDataVenda.Value = Convert.ToDateTime(dr["DATA_VENDA"]);
                txtNomeCliente.Text = dr["NOME_CLIENTE"].ToString();
                txtRGCliente.Text = dr["RG_CLIENTE"].ToString();
                txtCPFCliente.Text = dr["CPF_CLIENTE"].ToString();
                txtNomeFuncionario.Text = dr["NOME_FUNCIONARIO"].ToString();
                txtRGFuncionario.Text = dr["RG_FUNCIONARIO"].ToString();
                txtCPFFuncionario.Text = dr["CPF_FUNCIONARIO"].ToString();
                Double vp = Convert.ToDouble(dr["VALOR"]);
                Double de = Convert.ToDouble(dr["DESCONTO"]);
                Double vd = de / 100 * vp;
                Double vf = vp - vd;
                txtValorParcial.Text = "R$ " + vp.ToString("0.00");
                txtDesconto.Text += de.ToString() + "% - R$ " + vd.ToString("0.00");
                txtValorFinal.Text = "R$ " + vf.ToString("0.00");
                ListarLivros();
            }
        }

        private void ListarLivros()
        {
            try
            {
                BLL.Vendas v = new BLL.Vendas();
                v.Codigo = Codigo;
                dgv.DataSource = v.ListarLivros().Tables[0];
                dgv.Columns[0].HeaderText = "Código do Livro";
                dgv.Columns[1].HeaderText = "Nome do Livro";
                dgv.Columns[2].HeaderText = "Valor Unitário";
                dgv.Columns[3].HeaderText = "Quantidade";
                dgv.Columns[4].HeaderText = "Valor do desconto";
                dgv.Columns[5].HeaderText = "Valor Total";

                dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Voltar(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
