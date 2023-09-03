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

namespace ProjetoLivraria.Negocio.Contas
{
    public partial class ContasRegistrarPagamento : Modelo.ModeloDados
    {
        public ContasRegistrarPagamento()
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
            lblNomeUsuario.Location = new Point(lblNomeUsuario.Location.X - 50, lblNomeUsuario.Location.Y);
            lblFuncaoUsuario.Location = new Point(lblFuncaoUsuario.Location.X - 50, lblFuncaoUsuario.Location.Y);


            txtCodigo.Text = Codigo.ToString();
            BLL.Contas c = new BLL.Contas();
            c.Codigo = Codigo;
            SqlDataReader dr;
            dr = c.Consultar();
            if (dr.Read())
            {
                txtNome.Text = dr["DESTINO"].ToString();
                txtDocumento.Text = dr["NUMERO"].ToString();
                txtValor.Text = dr["VALOR"].ToString();
                txtDataEmissao.Text = Convert.ToDateTime(dr["DATA"]).ToString("dd/MM/yyyy");
                txtParcelas.Text = dr["PARCELAS"].ToString();
                Double vt = Convert.ToDouble(dr["VALOR"].ToString().Replace("R$ ", "").Replace(".", ","));
                Double p = Convert.ToDouble(dr["PARCELAS"]);
                Double vp = vt / p;
                txtValorParcela.Text = "R$ " + vp.ToString("0.00");
                CarregarListas();
            }
        }

        private void CarregarListas()
        {
            try
            {
                BLL.Contas c = new BLL.Contas();
                c.Codigo = Codigo;
                DataTable lista = c.ListarParaRegistrarPagamento().Tables[0];
                if (dgvNaoPagas.ColumnCount <= 0)
                {
                    dgvNaoPagas.Columns.Add("Parcela", "Parcela");
                    dgvNaoPagas.Columns.Add("Vencimento", "Vencimento");
                    dgvNaoPagas.Columns.Add("Pagamento", "Pagamento");
                }

                if (dgvPagas.ColumnCount <= 0)
                {
                    dgvPagas.Columns.Add("Parcela", "Parcela");
                    dgvPagas.Columns.Add("Vencimento", "Vencimento");
                    dgvPagas.Columns.Add("Pagamento", "Pagamento");
                }

                foreach (DataRow row in lista.Rows)
                {
                    if (row[2].ToString() == "")
                    {
                        dgvNaoPagas.Rows.Add(Convert.ToInt32(row[0]), Convert.ToDateTime(row[1]).ToString("dd/MM/yyyy"), "Não Paga");
                    }
                    else
                    {
                        dgvPagas.Rows.Add(Convert.ToInt32(row[0]), Convert.ToDateTime(row[1]).ToString("dd/MM/yyyy"), Convert.ToDateTime(row[2]).ToString("dd/MM/yyyy"));
                    }
                    dgvNaoPagas.AutoResizeColumns();
                    dgvPagas.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void MudarBotao(object sender, DataGridViewCellEventArgs e)
        {
            if (sender == dgvNaoPagas)
            {
                btnTrocarVenc.Text = "Registrar Pagamento";
                dtEmissao.MinDate = DateTime.Now;
                dtEmissao.Enabled = true;
            }
            else
            {
                btnTrocarVenc.Text = "Remover Pagamento";
                dtEmissao.Enabled = false;
            }
        }

        private void MoverPagamento(object sender, EventArgs e)
        {
            if (btnTrocarVenc.Text == "Registrar Pagamento")
            {
                if (dgvNaoPagas.RowCount <= 0)
                {
                    return;
                }
                dgvPagas.Rows.Add(Convert.ToInt32(dgvNaoPagas.CurrentRow.Cells[0].Value), dgvNaoPagas.CurrentRow.Cells[1].Value.ToString(), dtEmissao.Value.ToString("dd/MM/yyyy"));
                dgvNaoPagas.Rows.Remove(dgvNaoPagas.CurrentRow);
            }
            else
            {
                if (dgvPagas.RowCount <= 0)
                {
                    return;
                }
                dgvNaoPagas.Rows.Add(Convert.ToInt32(dgvPagas.CurrentRow.Cells[0].Value), dgvPagas.CurrentRow.Cells[1].Value.ToString(), "Não Paga");
                dgvPagas.Rows.Remove(dgvPagas.CurrentRow);
            }

            dgvNaoPagas.Sort(dgvNaoPagas.Columns[0], ListSortDirection.Ascending);
            dgvPagas.Sort(dgvPagas.Columns[0], ListSortDirection.Ascending);

        }

        private void Salvar(object sender, EventArgs e)
        {
            try
            {
                BLL.Contas c = new BLL.Contas();
                c.Codigo = Codigo;
                foreach (DataGridViewRow row in dgvNaoPagas.Rows)
                {
                    c.Numerodocumento = txtDocumento.Text + "/" + row.Cells[0].Value.ToString();
                    c.RegistrarPagamento("NULL");
                }

                foreach (DataGridViewRow row in dgvPagas.Rows)
                {
                    c.Numerodocumento = txtDocumento.Text + "/" + row.Cells[0].Value.ToString();
                    c.RegistrarPagamento("'" + row.Cells[2].Value.ToString() + "'");
                }
                MessageBox.Show("Pagamentos atualizados com sucesso.");
                this.Hide();
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
