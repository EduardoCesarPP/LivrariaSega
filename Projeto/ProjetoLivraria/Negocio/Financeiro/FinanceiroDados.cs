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

namespace ProjetoLivraria.Negocio.Financeiro
{
    public partial class FinanceiroDados : Modelo.ModeloDados
    {
        public FinanceiroDados()
        {
            InitializeComponent();
        }
        private void Checked(object sender, EventArgs e)
        {
            if (rbAno.Checked == true)
            {
                datFiltro.Format = DateTimePickerFormat.Custom;
                datFiltro.CustomFormat = "yyyy";
                datFiltro.ShowUpDown = true;
                Ano();

                lblGanhosMediaMes.Visible = true;
                txtGanhosMediaMes.Visible = true;
                lblVendasMediaMes.Visible = true;
                txtVendasMediaMes.Visible = true;

                lblPedidosMediaMes.Visible = true;
                txtPedidosMediaMes.Visible = true;
                lblGastoscomPedido.Location = new Point(330, lblGastoscomPedido.Location.Y);
                txtGastoscomPedido.Location = new Point(330, txtGastoscomPedido.Location.Y);
                lblGastoPedidoMes.Visible = true;
                txtGastoPedidoMes.Visible = true;

                lblContasMediaMes.Visible = true;
                txtContasMediaMes.Visible = true;
                lblGastoscomContas.Location = new Point(330, lblGastoscomContas.Location.Y);
                txtGastoscomContas.Location = new Point(330, txtGastoscomContas.Location.Y);
                lblGastoContasMes.Visible = true;
                txtGastoContasMes.Visible = true;
                lblGastoMes.Visible = true;
                txtGastosMes.Visible = true;
                lblLucroMes.Visible = true;
                txtLucroMes.Visible = true;
            }
            else
            {
                lblGanhosMediaMes.Visible = false;
                txtGanhosMediaMes.Visible = false;
                lblVendasMediaMes.Visible = false;
                txtVendasMediaMes.Visible = false;

                lblPedidosMediaMes.Visible = false;
                txtPedidosMediaMes.Visible = false;
                lblGastoscomPedido.Location = lblPedidosMediaMes.Location;
                txtGastoscomPedido.Location = txtPedidosMediaMes.Location;
                lblGastoPedidoMes.Visible = false;
                txtGastoPedidoMes.Visible = false;

                lblContasMediaMes.Visible = false;
                txtContasMediaMes.Visible = false;
                lblGastoscomContas.Location = lblContasMediaMes.Location;
                txtGastoscomContas.Location = txtContasMediaMes.Location;
                lblGastoContasMes.Visible = false;
                txtGastoContasMes.Visible = false;
                lblGastoMes.Visible = false;
                txtGastosMes.Visible = false;
                lblLucroMes.Visible = false;
                txtLucroMes.Visible = false;
                if (this.rbMes.Checked == true)
                {
                    datFiltro.Format = DateTimePickerFormat.Custom;
                    datFiltro.CustomFormat = "MM/yyyy";
                    datFiltro.ShowUpDown = false;
                    Mes();
                }
                else if (rbDia.Checked == true)
                {
                    datFiltro.Format = DateTimePickerFormat.Short;
                    datFiltro.ShowUpDown = false;
                    Dia();
                }
            }
        }

        private void Ano()
        {
            try
            {
                BLL.Financeiro f = new BLL.Financeiro();
                SqlDataReader dr;
                dr = f.ControleAnoGanhos(escolherMes(), datFiltro.Value.ToString("yyyy"));
                if (dr.Read())
                {
                    txtVendasQtde.Text = dr["QUANTIDADE_VENDAS"].ToString();
                    txtVendasMediaMes.Text = dr["VENDAS_MES"].ToString();
                    txtGanhos.Text = "R$ " + Convert.ToDouble(dr["GANHOS"]).ToString("0.00");
                    txtGanhosMediaVenda.Text = "R$ " + Convert.ToDouble(dr["GANHOS_VENDA"]).ToString("0.00");
                    txtGanhosMediaMes.Text = "R$ " + Convert.ToDouble(dr["GANHOS_MES"]).ToString("0.00");
                }

                dr = f.ControleAnoPedidos1(escolherMes(), datFiltro.Value.ToString("yyyy"));
                if (dr.Read())
                {
                    txtPedidosQtde.Text = dr["QUANTIDADE_PEDIDOS"].ToString();
                    txtPedidosMediaMes.Text = dr["PEDIDOS_MES"].ToString();
                }

                dr = f.ControleAnoPedidos2(escolherMes(), datFiltro.Value.ToString("yyyy"));
                if (dr.Read())
                {
                    txtGastoscomPedido.Text = "R$ " + Convert.ToDouble(dr["GASTOS_COM_PEDIDO"]).ToString("0.00");
                    txtGastosPorPedido.Text = "R$ " + Convert.ToDouble(dr["GASTOS_POR_PEDIDO"]).ToString("0.00");
                    txtGastoPedidoMes.Text = "R$ " + Convert.ToDouble(dr["GASTOS_MEDIA_PEDIDOS_MES"]).ToString("0.00");
                }

                dr = f.ControleAnoContas(escolherMes(), datFiltro.Value.ToString("yyyy"));
                if (dr.Read())
                {
                    txtContasQtde.Text = dr["QUANTIDADE"].ToString();
                    txtContasMediaMes.Text = dr["QUANTIDADE_MES"].ToString();
                    txtGastoscomContas.Text = "R$ " + Convert.ToDouble(dr["GASTOS_COM_CONTAS"]).ToString("0.00");
                    txtGastosPorContas.Text = "R$ " + Convert.ToDouble(dr["GASTOS_POR_CONTA"]).ToString("0.00");
                    txtGastoContasMes.Text = "R$ " + Convert.ToDouble(dr["GASTOS_COM_CONTAS_POR_MES"]).ToString("0.00");
                }

                dr = f.ControleAnoGastos(escolherMes(), datFiltro.Value.ToString("yyyy"));
                if (dr.Read())
                {
                    txtGastos.Text = "R$ " + Convert.ToDouble(dr["GASTOS"]).ToString("0.00");
                    txtGastosMes.Text = "R$ " + Convert.ToDouble(dr["GASTOS_MES"]).ToString("0.00");
                }

                Double ganhos = Convert.ToDouble(txtGanhos.Text.Replace("R$ ", ""));
                Double gastos = Convert.ToDouble(txtGastos.Text.Replace("R$ ", ""));
                Double lucro = ganhos - gastos;
                Double lucroMes = lucro / escolherMes();

                txtLucro.Text = "R$ " + lucro.ToString("0.00");
                txtLucroMes.Text = "R$ " + lucroMes.ToString("0.00");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Mes()
        {
            try
            {
                BLL.Financeiro f = new BLL.Financeiro();
                SqlDataReader dr;
                dr = f.ControleMesGanhos(datFiltro.Value.ToString("MM"), datFiltro.Value.ToString("yyyy"));
                if (dr.Read())
                {
                    txtVendasQtde.Text = dr["QUANTIDADE_VENDAS"].ToString();
                    txtGanhos.Text = "R$ " + Convert.ToDouble(dr["GANHOS"]).ToString("0.00");
                    txtGanhosMediaVenda.Text = "R$ " + Convert.ToDouble(dr["GANHOS_VENDA"]).ToString("0.00");
                }

                dr = f.ControleMesPedidos1(datFiltro.Value.ToString("MM"), datFiltro.Value.ToString("yyyy"));
                if (dr.Read())
                {
                    txtPedidosQtde.Text = dr["QUANTIDADE_PEDIDOS"].ToString();
                }

                dr = f.ControleMesPedidos2(datFiltro.Value.ToString("MM"), datFiltro.Value.ToString("yyyy"));
                if (dr.Read())
                {
                    txtGastoscomPedido.Text = "R$ " + Convert.ToDouble(dr["GASTOS_COM_PEDIDO"]).ToString("0.00");
                    txtGastosPorPedido.Text = "R$ " + Convert.ToDouble(dr["GASTOS_POR_PEDIDO"]).ToString("0.00");
                }

                dr = f.ControleMesContas(datFiltro.Value.ToString("MM"), datFiltro.Value.ToString("yyyy"));
                if (dr.Read())
                {
                    txtContasQtde.Text = dr["QUANTIDADE"].ToString();
                    txtGastoscomContas.Text = "R$ " + Convert.ToDouble(dr["GASTOS_COM_CONTAS"]).ToString("0.00");
                    txtGastosPorContas.Text = "R$ " + Convert.ToDouble(dr["GASTOS_POR_CONTA"]).ToString("0.00");
                }

                dr = f.ControleMesGastos(datFiltro.Value.ToString("MM"), datFiltro.Value.ToString("yyyy"));
                if (dr.Read())
                {
                    txtGastos.Text = "R$ " + Convert.ToDouble(dr["GASTOS"]).ToString("0.00");
                }

                Double ganhos = Convert.ToDouble(txtGanhos.Text.Replace("R$ ", ""));
                Double gastos = Convert.ToDouble(txtGastos.Text.Replace("R$ ", ""));
                Double lucro = ganhos - gastos;

                txtLucro.Text = "R$ " + lucro.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Dia()
        {
            try
            {
                BLL.Financeiro f = new BLL.Financeiro();
                SqlDataReader dr;
                dr = f.ControleDiaGanhos(datFiltro.Value.ToString("dd/MM/yyyy"));
                if (dr.Read())
                {
                    txtVendasQtde.Text = dr["QUANTIDADE_VENDAS"].ToString();
                    txtGanhos.Text = "R$ " + Convert.ToDouble(dr["GANHOS"]).ToString("0.00");
                    txtGanhosMediaVenda.Text = "R$ " + Convert.ToDouble(dr["GANHOS_VENDA"]).ToString("0.00");
                }

                dr = f.ControleDiaPedidos1(datFiltro.Value.ToString("dd/MM/yyyy"));
                if (dr.Read())
                {
                    txtPedidosQtde.Text = dr["QUANTIDADE_PEDIDOS"].ToString();
                }

                dr = f.ControleDiaPedidos2(datFiltro.Value.ToString("dd/MM/yyyy"));
                if (dr.Read())
                {
                    txtGastoscomPedido.Text = "R$ " + Convert.ToDouble(dr["GASTOS_COM_PEDIDO"]).ToString("0.00");
                    txtGastosPorPedido.Text = "R$ " + Convert.ToDouble(dr["GASTOS_POR_PEDIDO"]).ToString("0.00");
                }

                dr = f.ControleDiaContas(datFiltro.Value.ToString("dd/MM/yyyy"));
                if (dr.Read())
                {
                    txtContasQtde.Text = dr["QUANTIDADE"].ToString();
                    txtGastoscomContas.Text = "R$ " + Convert.ToDouble(dr["GASTOS_COM_CONTAS"]).ToString("0.00");
                    txtGastosPorContas.Text = "R$ " + Convert.ToDouble(dr["GASTOS_POR_CONTA"]).ToString("0.00");
                }

                dr = f.ControleDiaGastos(datFiltro.Value.ToString("dd/MM/yyyy"));
                if (dr.Read())
                {
                    txtGastos.Text = "R$ " + Convert.ToDouble(dr["GASTOS"]).ToString("0.00");
                }

                Double ganhos = Convert.ToDouble(txtGanhos.Text.Replace("R$ ", ""));
                Double gastos = Convert.ToDouble(txtGastos.Text.Replace("R$ ", ""));
                Double lucro = ganhos - gastos;

                txtLucro.Text = "R$ " + lucro.ToString("0.00");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private int escolherMes()
        {
            int mes = 0;

            if (datFiltro.Value.ToString("yyyy") == DateTime.Now.Year.ToString("yyyy"))
            {
                mes = DateTime.Now.Month;
            }
            else
            {
                mes = 12;
            }
            return mes;
        }

        private void MudaData(object sender, EventArgs e)
        {
            if (rbAno.Checked == true)
            {
                Ano();
            }
            else if(rbMes.Checked == true)
            {
                Mes();
            }
            else
            {
                Dia();
            }
        }

        private void AbrirGraficosGanhos(object sender, EventArgs e)
        {
            FinanceiroGraficos f = new Financeiro.FinanceiroGraficos();
            f.Operacao = 1;
            f.ShowDialog();
        }

        private void AbrirGraficosGastos(object sender, EventArgs e)
        {
            FinanceiroGraficos f = new Financeiro.FinanceiroGraficos();
            f.Operacao = 2;
            f.ShowDialog();
        }

        private void AbrirGraficosLucro(object sender, EventArgs e)
        {
            FinanceiroGraficos f = new Financeiro.FinanceiroGraficos();
            f.Operacao = 3;
            f.ShowDialog();
        }

        private void Sair(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
