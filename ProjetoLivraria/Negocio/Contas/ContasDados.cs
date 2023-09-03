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
    public partial class ContasDados : Modelo.ModeloDados
    {
        public ContasDados()
        {
            InitializeComponent();
        }

        private int _Operacao;

        public int Operacao
        {
            get { return _Operacao; }
            set { _Operacao = value; }
        }

        private int _Codigo;

        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private void Carregar(object sender, EventArgs e)
        {
            try
            {
                if (Operacao == 1) //Cadastro
                {
                    txtCodigo.Visible = false;
                    lblCodigo.Visible = false;
                    txtNome.Location = txtCodigo.Location;
                    lblNome.Location = lblCodigo.Location;
                    txtNome.Size = new Size(470, txtNome.Size.Height);
                }
                else
                {
                    BLL.Contas c = new BLL.Contas();
                    c.Codigo = Codigo;
                    txtCodigo.Text = Codigo.ToString();
                    SqlDataReader dr;
                    dr = c.Consultar();
                    if (dr.Read())
                    {
                        txtNome.Text = dr["DESTINO"].ToString();
                        txtDocumento.Text = dr["NUMERO"].ToString();
                        txtValor.Text = dr["VALOR"].ToString();
                        dtEmissao.Value = Convert.ToDateTime(dr["DATA"]);
                        nudParcelas.Value = Convert.ToDecimal(dr["PARCELAS"].ToString());
                        Double vt = Convert.ToDouble(dr["VALOR"].ToString().Replace("R$ ", "").Replace(".", ","));
                        Double p = Convert.ToDouble(dr["PARCELAS"]);
                        Double vp = vt / p;
                        txtValorParcela.Text = "R$ " + vp.ToString("0.00");
                        CarregarLista();

                        btnInserirPag.Visible = false;
                        //btnTrocarPag.Visible = false;
                        btnTrocarVenc.Visible = false;
                        dgvParcelas.Size = new Size(670,dgvParcelas.Size.Height);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void CarregarLista()
        {
            try
            {
                BLL.Contas c = new BLL.Contas();
                c.Codigo = Codigo;
                dgvParcelas.DataSource = c.ListarParaConsulta().Tables[0];
                dgvParcelas.Columns[0].HeaderText = "Parcela";
                dgvParcelas.Columns[1].HeaderText = "Vencimento";
                dgvParcelas.Columns[2].HeaderText = "Pagamento";
                dgvParcelas.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Salvar(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == String.Empty)
                {
                    MessageBox.Show("O preenchimento do campo Destino da Conta / Cliente / Nome é obrigatório.");
                    txtNome.Focus();
                    return;
                }

                //VALIDAR EMAIL
                if (txtDocumento.Text == String.Empty)
                {
                    MessageBox.Show("O preenchimento do campo Número do Documento é obrigatório.");
                    txtDocumento.Focus();
                    return;
                }                //VALIDAR EMAIL
                if (txtValor.Text == String.Empty)
                {
                    MessageBox.Show("O preenchimento do campo valor é obrigatório.");
                    txtValor.Focus();
                    return;
                }


                BLL.Contas c = new BLL.Contas();
                switch (Operacao)
                {
                    case 1: //CADASTRO
                        SqlDataReader dr;
                        dr = c.ConsultarProximo();
                        if (dr.Read())
                        {
                            Codigo = Convert.ToInt32(dr["CODIGO"]);
                        }
                        c.Codigo = Codigo;
                        c.Destino = txtNome.Text;
                        c.Valor = txtValor.Text.Replace(",", ".");
                        int i = 1;
                        foreach (DataGridViewRow row in dgvParcelas.Rows)
                        {
                            c.Numerodocumento = txtDocumento.Text + "/" + i.ToString();
                            i++;
                            c.Vencimento = Convert.ToDateTime(row.Cells[1].Value);
                            if (row.Cells[2].Value.ToString() == "Não Paga")
                            {
                                c.Incluir(false);
                            }
                            else
                            {
                                c.Pagamento = Convert.ToDateTime(row.Cells[2].Value);
                                c.Incluir(true);
                            }
                        }
                        MessageBox.Show("Conta do destino " + txtNome.Text + " cadastrada com sucesso.");
                        this.Hide();
                        ContasLista cl = new ContasLista();
                        cl.ShowDialog();
                        break;
                    case 2: //ALTERAÇÃO
                        c.Codigo = Codigo;
                        //c.Alterar();
                        MessageBox.Show("Pagamento registrado com sucesso.");
                        this.Hide();
                        ContasLista cll = new ContasLista();
                        cll.ShowDialog();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void FormatarValor(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            string texto = textbox.Text.Replace(",", "");

            if (texto.Length > 0)
            {
                if (texto.Length == 1)
                {
                    textbox.Text = texto + ",00";
                }
                else if (texto.Length == 2)
                {
                    textbox.Text = texto.Substring(0, 1) + "," + texto.Substring(1, 1) + "0";
                }
                else
                {
                    textbox.Text = texto.Substring(0, texto.Length - 2) + "," + texto.Substring(texto.Length - 2, 2);
                }
            }
            CalcularParcela(sender, e);
        }

        private void RestringirCaracteres(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CalcularParcela(object sender, EventArgs e)
        {
            try
            {
                if (txtValor.Text.Length != 0)
                {
                    txtValorParcela.Text = (Convert.ToDouble(txtValor.Text.Replace("R$ ", "")) / Convert.ToDouble(nudParcelas.Value)).ToString("0.00");
                    ListarDatas();
                    btnTrocarVenc.Enabled = true;
                    btnInserirPag.Enabled = true;
                    //btnTrocarPag.Enabled = true;

                }
                else
                {
                    txtValorParcela.Text = "";
                    dgvParcelas.Rows.Clear();
                    btnTrocarVenc.Enabled = false;
                    btnInserirPag.Enabled = false;
                    //btnTrocarPag.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void ListarDatas()
        {
            try
            {
                if (Operacao != 1)
                {
                    return;
                }
                if (this.dgvParcelas.ColumnCount == 0)
                {
                    dgvParcelas.Columns.Add("Parcela", "Parcela");
                    dgvParcelas.Columns.Add("Vencimento", "Vencimento");
                    dgvParcelas.Columns.Add("Pagamento", "Pagamento");
                }

                if (dgvParcelas.Rows.Count > 0)
                {
                    dgvParcelas.Rows.Clear();
                }

                DateTime data = dtVencimento.Value;
                for (int i = 0; i < nudParcelas.Value; i++)
                {
                    dgvParcelas.Rows.Add(i + 1, data.ToString("dd/MM/yyyy"), "Não Paga");
                    data = data.AddMonths(1);
                }
                dgvParcelas.DefaultCellStyle.Font = new Font("Century Gothic", 10);
                dgvParcelas.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void MudarDatas(object sender, EventArgs e)
        {
            ListarDatas();
        }

        private void MudarBotoes(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvParcelas.CurrentRow.Cells[2].Value.ToString() == "Não Paga")
            {
                btnInserirPag.Text = " Inserir Pagamento";
                //btnTrocarPag.Enabled = false;
            }
            else
            {
                btnInserirPag.Text = " Excluir Pagamento";
                //btnTrocarPag.Enabled = true;
            }
        }

        private void TrocarVencimento(object sender, EventArgs e)
        {
            ContasTrocarData c = new Contas.ContasTrocarData();
            if (dgvParcelas.CurrentRow.Index == 0)
            {
                c.Limite1 = DateTime.Now;
            }
            else
            {
                c.Limite1 = Convert.ToDateTime(dgvParcelas.CurrentRow.Cells[1].Value);
            }

            if (dgvParcelas.CurrentRow.Index == dgvParcelas.Rows.Count - 1)
            {
                c.Limite2 = Convert.ToDateTime("31/12/9998");
            }
            else
            {
                c.Limite2 = Convert.ToDateTime(dgvParcelas.CurrentRow.Cells[1].Value);
            }
            c.ShowDialog();
            dgvParcelas.CurrentRow.Cells[1].Value = c.dtNova.Value.ToString("dd/MM/yyyy");
        }

        private void InserirPagamento(object sender, EventArgs e)
        {
            string opcao = ((Button)sender).Text;
            if (opcao == " Inserir Pagamento")
            {
                ContasTrocarData c = new Contas.ContasTrocarData();
                c.Limite1 = Convert.ToDateTime("01/01/1901");
                c.Limite2 = DateTime.Today;
                c.ShowDialog();
                dgvParcelas.CurrentRow.Cells[2].Value = c.dtNova.Value.ToString("dd/MM/yyyy");
                btnInserirPag.Text = " Excluir Pagamento";
            }
            else
            {
                dgvParcelas.CurrentRow.Cells[2].Value = "Não Paga";
            }
        }

        private void TrocarPagamento(object sender, EventArgs e)
        {

        }

        private void Voltar(object sender, EventArgs e)
        {
            if (Operacao == 1 || Operacao == 2)
            {
                if (MessageBox.Show("Fechando este formulário, os dados não salvos serão perdidos.\nDeseja continuar?", "Sair", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            this.Hide();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
