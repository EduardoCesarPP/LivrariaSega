using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Negocio.Financeiro
{
    public partial class FinanceiroGraficos : Modelo.ModeloDados
    {
        public FinanceiroGraficos()
        {
            InitializeComponent();
        }

        private int _Operacao;

        public int Operacao
        {
            get
            {
                return _Operacao;
            }

            set
            {
                _Operacao = value;
            }
        }

        private void Carregar(object sender, EventArgs e)
        {
            if (Operacao == 1)
            {
                lblTitulo.Text = "Financeiro > Ver Gráficos (Ganhos)";
                if (rbAno.Checked)
                {
                    cbInformacao.Items.Clear();
                    cbInformacao.Items.Add("Ganhos");
                    cbInformacao.Items.Add("Ganhos por Editora");
                    cbInformacao.Items.Add("Ganhos por Gênero de Livro");
                    cbInformacao.Items.Add("Ganhos por Livro");
                    cbInformacao.SelectedIndex = 0;
                }
                else
                {
                    cbInformacao.Items.Clear();
                    cbInformacao.Items.Add("Ganhos por Editora");
                    cbInformacao.Items.Add("Ganhos por Gênero de Livro");
                    cbInformacao.Items.Add("Ganhos por Livro");
                    cbInformacao.SelectedIndex = 0;
                }
            }
            else if (Operacao == 2)  //Gastos
            {
                lblTitulo.Text = "Financeiro > Ver Gráficos (Gastos)";
                rbDia.Enabled = false;
                if (rbAno.Checked)
                {
                    cbInformacao.Items.Clear();
                    cbInformacao.Items.Add("Gastos");
                    cbInformacao.Items.Add("Gastos com Pedidos");
                    cbInformacao.Items.Add("Gastos com Pedidos (por editora)");
                    cbInformacao.Items.Add("Gastos com Contas");
                    cbInformacao.Items.Add("Comparação (%)");
                    cbInformacao.Items.Add("Comparação (mensal)");
                    cbInformacao.SelectedIndex = 0;
                }
                else if (rbMes.Checked)
                {
                    cbInformacao.Items.Clear();
                    cbInformacao.Items.Add("Gastos com Pedidos (por editora)");
                    cbInformacao.Items.Add("Comparação (%)");
                    cbInformacao.Items.Add("Comparação (R$)");
                    cbInformacao.SelectedIndex = 0;
                }

            }
            else
            {
                lblTitulo.Text = "Financeiro > Ver Gráficos (Lucro)";
                rbMes.Enabled = false;
                rbDia.Enabled = false;
                cbInformacao.Items.Clear();
                cbInformacao.Items.Add("Lucro (Evolução)");
                cbInformacao.Items.Add("Lucro (Comparação)");
                cbInformacao.SelectedIndex = 0;
            }
        }

        private void MudarInformacao(object sender, EventArgs e)
        {
            if (Operacao == 1)
            {
                if (rbAno.Checked)
                {
                    datFiltro.Format = DateTimePickerFormat.Custom;
                    datFiltro.CustomFormat = "yyyy";
                    datFiltro.ShowUpDown = true;

                    carregarGraficoAnoGanhos();
                }
                else if (rbMes.Checked)
                {
                    datFiltro.Format = DateTimePickerFormat.Custom;
                    datFiltro.CustomFormat = "MM/yyyy";
                    datFiltro.ShowUpDown = false;
                    carregarGraficoMesGanhos();
                }
                else
                {
                    datFiltro.Format = DateTimePickerFormat.Short;
                    datFiltro.ShowUpDown = false;
                    carregarGraficoDiaGanhos();
                }
            }
            else if (Operacao == 2)
            {
                if (rbAno.Checked)
                {
                    datFiltro.Format = DateTimePickerFormat.Custom;
                    datFiltro.CustomFormat = "yyyy";
                    carregarGraficoAnoGastos();
                }
                else if (rbMes.Checked)
                {
                    datFiltro.Format = DateTimePickerFormat.Custom;
                    datFiltro.CustomFormat = "MM/yyyy";
                    datFiltro.ShowUpDown = false;
                    carregarGraficoMesGastos();
                }
            }
            else
            {
                 datFiltro.Format = DateTimePickerFormat.Custom;
                    datFiltro.CustomFormat = "yyyy";
                carregarGraficoLucro();
            }

        }

        private void carregarGraficoAnoGastos()
        {
            try
            {
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }

                BLL.Financeiro f = new BLL.Financeiro();
                DataTable lista;
                panel3.Visible = false;
                switch (cbInformacao.SelectedIndex)
                {
                    case 0:
                        chart2.Visible = false;
                        chart1.Visible = true;
                        chart1.Series["Series1"].LegendText = "Valor dos gastos (R$)";
                        lista = f.GraficosAnoGastos1(datFiltro.Value.ToString("yyyy")).Tables[0];
                        chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        chart1.Series["Series2"].IsVisibleInLegend = false;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart1.Series["Series1"].Points.AddXY(row[0], row[1]);
                        }
                        break;
                    case 1:
                        chart2.Visible = false;
                        chart1.Visible = true;
                        chart1.Series["Series1"].LegendText = "Valor dos gastos (R$)";
                        lista = f.GraficosAnoGastos2(datFiltro.Value.ToString("yyyy")).Tables[0];
                        chart1.Series["Series2"].IsVisibleInLegend = false;
                        chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart1.Series["Series1"].Points.AddXY(row[0], row[1]);
                        }
                        break;
                    case 2:
                        foreach (var series in chart2.Series)
                        {
                            series.Points.Clear();
                        }
                        chart2.Visible = true;
                        chart1.Visible = false;
                        lista = f.GraficosAnoGastos5(datFiltro.Value.ToString("yyyy")).Tables[0];
                        int i = 0;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart2.Series["Series1"].Points.AddXY(row[0], row[1]);
                            chart2.Series["Series1"].Points[i].LegendText = row[0].ToString();
                            chart2.Series["Series1"].Points[i].Label = "R$ " + Convert.ToDouble(row[1]).ToString("0.00");
                            i++;
                            //chart2.Series["Series1"].LegendText = chart2.Series["Series1"].LegendText.Substring(0, chart2.Series["Series1"].LegendText.Length-5);

                        }
                        break;
                    case 3:
                        chart2.Visible = false;
                        chart1.Visible = true;
                        chart1.Series["Series1"].LegendText = "Valor dos gastos (R$)";
                        lista = f.GraficosAnoGastos3(datFiltro.Value.ToString("yyyy")).Tables[0];
                        chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        chart1.Series["Series2"].IsVisibleInLegend = false;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart1.Series["Series1"].Points.AddXY(row[0], row[1]);
                        }
                        break;
                    case 4:
                        chart2.Visible = false;
                        chart1.Visible = true;
                        chart1.Series["Series2"].IsVisibleInLegend = true;
                        panel3.Visible = true;

                        lista = f.GraficosAnoGastos4(datFiltro.Value.ToString("yyyy")).Tables[0];
                        chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        chart1.Series["Series2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        if (lista.Rows.Count <= 0)
                        {
                            foreach (var series in chart1.Series)
                            {
                                series.Points.Clear();
                            }
                            foreach (var series in chart2.Series)
                            {
                                series.Points.Clear();
                            }
                            return;
                        }
                        chart1.Series["Series1"].Points.AddXY(lista.Rows[0][0], lista.Rows[0][1]);
                        chart1.Series["Series2"].Points.AddXY(lista.Rows[1][0], lista.Rows[1][1]);

                        chart1.Series["Series1"].Points[0].Label = Convert.ToDouble(lista.Rows[0][1]).ToString("0.00") + "%";
                        chart1.Series["Series2"].Points[0].Label = Convert.ToDouble(lista.Rows[1][1]).ToString("0.00") + "%";
                        chart1.Series["Series1"].LegendText = "Pedidos";
                        chart1.Series["Series2"].LegendText = "Contas";

                        break;
                    case 5:
                        chart2.Visible = false;
                        chart1.Visible = true;
                        chart1.Series["Series1"].LegendText = "Pedidos (R$)";
                        chart1.Series["Series2"].LegendText = "Contas (R$)";
                        lista = f.GraficosAnoGastos2(datFiltro.Value.ToString("yyyy")).Tables[0];
                        chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        chart1.Series["Series2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        chart1.Series["Series2"].IsVisibleInLegend = true;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart1.Series["Series1"].Points.AddXY(row[0], row[1]);
                        }

                        lista = f.GraficosAnoGastos3(datFiltro.Value.ToString("yyyy")).Tables[0];
                        foreach (DataRow row in lista.Rows)
                        {
                            chart1.Series["Series2"].Points.AddXY(row[0], row[1]);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void carregarGraficoMesGastos()
        {
            try
            {
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }

                BLL.Financeiro f = new BLL.Financeiro();
                DataTable lista;
                panel3.Visible = false;
                switch (cbInformacao.SelectedIndex)
                {
                    case 0:
                        foreach (var series in chart2.Series)
                        {
                            series.Points.Clear();
                        }
                        chart2.Visible = true;
                        chart1.Visible = false;
                        lista = f.GraficosMesGastos1(datFiltro.Value.ToString("yyyy"), datFiltro.Value.ToString("MM")).Tables[0];
                        int i = 0;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart2.Series["Series1"].Points.AddXY(row[0], row[1]);
                            chart2.Series["Series1"].Points[i].LegendText = row[0].ToString();
                            chart2.Series["Series1"].Points[i].Label = "R$ " + Convert.ToDouble(row[1]).ToString("0.00");
                            i++;
                            //chart2.Series["Series1"].LegendText = chart2.Series["Series1"].LegendText.Substring(0, chart2.Series["Series1"].LegendText.Length-5);

                        }
                        break;
                    case 1:
                        chart2.Visible = false;
                        chart1.Visible = true;
                        chart1.Series["Series2"].IsVisibleInLegend = true;
                        panel3.Visible = true;

                        lista = f.GraficosMesGastos2(datFiltro.Value.ToString("yyyy"), datFiltro.Value.ToString("MM")).Tables[0];
                        chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        chart1.Series["Series2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        if (lista.Rows.Count <= 0)
                        {
                            foreach (var series in chart1.Series)
                            {
                                series.Points.Clear();
                            }
                            foreach (var series in chart2.Series)
                            {
                                series.Points.Clear();
                            }
                            return;
                        }
                        chart1.Series["Series1"].Points.AddXY(lista.Rows[0][0], lista.Rows[0][1]);
                        chart1.Series["Series2"].Points.AddXY(lista.Rows[1][0], lista.Rows[1][1]);

                        chart1.Series["Series1"].Points[0].Label = Convert.ToDouble(lista.Rows[0][1]).ToString("0.00") + "%";
                        chart1.Series["Series2"].Points[0].Label = Convert.ToDouble(lista.Rows[1][1]).ToString("0.00") + "%";
                        chart1.Series["Series1"].LegendText = "Pedidos";
                        chart1.Series["Series2"].LegendText = "Contas";
                        break;
                    case 2:
                        chart2.Visible = false;
                        chart1.Visible = true;
                        chart1.Series["Series2"].IsVisibleInLegend = true;
                        panel3.Visible = true;

                        lista = f.GraficosMesGastos3(datFiltro.Value.ToString("yyyy"), datFiltro.Value.ToString("MM")).Tables[0];
                        chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        chart1.Series["Series2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        if (lista.Rows.Count <= 0)
                        {
                            foreach (var series in chart1.Series)
                            {
                                series.Points.Clear();
                            }
                            foreach (var series in chart2.Series)
                            {
                                series.Points.Clear();
                            }
                            return;
                        }
                        chart1.Series["Series1"].Points.AddXY(lista.Rows[0][0], lista.Rows[0][1]);
                        chart1.Series["Series2"].Points.AddXY(lista.Rows[1][0], lista.Rows[1][1]);

                        chart1.Series["Series1"].Points[0].Label = "R$ " + Convert.ToDouble(lista.Rows[0][1]).ToString("0.00");
                        chart1.Series["Series2"].Points[0].Label = "R$ " + Convert.ToDouble(lista.Rows[1][1]).ToString("0.00");
                        chart1.Series["Series1"].LegendText = "Pedidos";
                        chart1.Series["Series2"].LegendText = "Contas";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void carregarGraficoAnoGanhos()
        {
            try
            {
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }

                BLL.Financeiro f = new BLL.Financeiro();
                DataTable lista;
                panel3.Visible = false;
                switch (cbInformacao.SelectedIndex)
                {
                    case 0:
                        chart2.Visible = false;
                        chart1.Visible = true;
                        chart1.Series["Series1"].LegendText = "Valor dos ganhos (R$)";
                        lista = f.GraficosAnoGanhos(datFiltro.Value.ToString("yyyy")).Tables[0];
                        chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        chart1.Series["Series2"].IsVisibleInLegend = false;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart1.Series["Series1"].Points.AddXY(row[0], row[1]);
                        }
                        break;
                    case 1:
                        foreach (var series in chart2.Series)
                        {
                            series.Points.Clear();
                        }
                        chart2.Visible = true;
                        chart1.Visible = false;
                        lista = f.GraficosAnoGanhosEditora(datFiltro.Value.ToString("yyyy")).Tables[0];
                        int i = 0;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart2.Series["Series1"].Points.AddXY(row[1], row[0]);
                            chart2.Series["Series1"].Points[i].LegendText = row[1].ToString();
                            chart2.Series["Series1"].Points[i].Label = "R$ " + Convert.ToDouble(row[0]).ToString("0.00");
                            i++;
                        }
                        break;
                    case 2:
                        foreach (var series in chart2.Series)
                        {
                            series.Points.Clear();
                        }
                        chart2.Visible = true;
                        chart1.Visible = false;
                        lista = f.GraficosAnoGanhosGenero(datFiltro.Value.ToString("yyyy")).Tables[0];
                        int ii = 0;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart2.Series["Series1"].Points.AddXY(row[1], row[0]);
                            chart2.Series["Series1"].Points[ii].LegendText = row[1].ToString();
                            chart2.Series["Series1"].Points[ii].Label = "R$ " + Convert.ToDouble(row[0]).ToString("0.00");
                            ii++;
                        }
                        break;
                    case 3:
                        chart2.Visible = false;
                        chart1.Visible = true;
                        chart1.Series["Series1"].LegendText = "Quantidade Vendida";
                        lista = f.GraficosAnoGanhosLivro(datFiltro.Value.ToString("yyyy")).Tables[0];
                        chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        chart1.Series["Series2"].IsVisibleInLegend = false;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart1.Series["Series1"].Points.AddXY(row[0], row[1]);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void carregarGraficoMesGanhos()
        {
            try
            {
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }

                BLL.Financeiro f = new BLL.Financeiro();
                DataTable lista;
                panel3.Visible = false;
                switch (cbInformacao.SelectedIndex)
                {
                    case 0:
                        foreach (var series in chart2.Series)
                        {
                            series.Points.Clear();
                        }
                        chart2.Visible = true;
                        chart1.Visible = false;
                        lista = f.GraficosMesGanhosEditora(datFiltro.Value.ToString("yyyy"), datFiltro.Value.ToString("MM")).Tables[0];
                        int i = 0;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart2.Series["Series1"].Points.AddXY(row[1], row[0]);
                            chart2.Series["Series1"].Points[i].LegendText = row[1].ToString();
                            chart2.Series["Series1"].Points[i].Label = "R$ " + Convert.ToDouble(row[0]).ToString("0.00");
                            i++;
                        }
                        break;
                    case 1:
                        foreach (var series in chart2.Series)
                        {
                            series.Points.Clear();
                        }
                        chart2.Visible = true;
                        chart1.Visible = false;
                        lista = f.GraficosMesGanhosGenero(datFiltro.Value.ToString("yyyy"), datFiltro.Value.ToString("MM")).Tables[0];
                        int ii = 0;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart2.Series["Series1"].Points.AddXY(row[1], row[0]);
                            chart2.Series["Series1"].Points[ii].LegendText = row[1].ToString();
                            chart2.Series["Series1"].Points[ii].Label = "R$ " + Convert.ToDouble(row[0]).ToString("0.00");
                            ii++;
                        }
                        break;
                    case 2:
                        chart2.Visible = false;
                        chart1.Visible = true;
                        chart1.Series["Series1"].LegendText = "Quantidade Vendida";
                        lista = f.GraficosMesGanhosLivro(datFiltro.Value.ToString("yyyy"), datFiltro.Value.ToString("MM")).Tables[0];
                        chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        chart1.Series["Series2"].IsVisibleInLegend = false;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart1.Series["Series1"].Points.AddXY(row[0], row[1]);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void carregarGraficoDiaGanhos()
        {
            try
            {
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }

                BLL.Financeiro f = new BLL.Financeiro();
                DataTable lista;
                panel3.Visible = false;
                switch (cbInformacao.SelectedIndex)
                {
                    case 0:
                        foreach (var series in chart2.Series)
                        {
                            series.Points.Clear();
                        }
                        chart2.Visible = true;
                        chart1.Visible = false;
                        lista = f.GraficosDiaGanhosEditora(datFiltro.Value.ToString("dd/MM/yyyy")).Tables[0];
                        int i = 0;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart2.Series["Series1"].Points.AddXY(row[1], row[0]);
                            chart2.Series["Series1"].Points[i].LegendText = row[1].ToString();
                            chart2.Series["Series1"].Points[i].Label = "R$ " + Convert.ToDouble(row[0]).ToString("0.00");
                            i++;
                        }
                        break;
                    case 1:
                        foreach (var series in chart2.Series)
                        {
                            series.Points.Clear();
                        }
                        chart2.Visible = true;
                        chart1.Visible = false;
                        lista = f.GraficosDiaGanhosGenero(datFiltro.Value.ToString("dd/MM/yyyy")).Tables[0];
                        int ii = 0;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart2.Series["Series1"].Points.AddXY(row[1], row[0]);
                            chart2.Series["Series1"].Points[ii].LegendText = row[1].ToString();
                            chart2.Series["Series1"].Points[ii].Label = "R$ " + Convert.ToDouble(row[0]).ToString("0.00");
                            ii++;
                        }
                        break;
                    case 2:
                        chart2.Visible = false;
                        chart1.Visible = true;
                        chart1.Series["Series1"].LegendText = "Quantidade Vendida";
                        lista = f.GraficosDiaGanhosLivro(datFiltro.Value.ToString("dd/MM/yyyy")).Tables[0];
                        chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        chart1.Series["Series2"].IsVisibleInLegend = false;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart1.Series["Series1"].Points.AddXY(row[0], row[1]);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void carregarGraficoLucro()
        {
            try
            {
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }

                BLL.Financeiro f = new BLL.Financeiro();
                DataTable lista;
                panel3.Visible = false;
                switch (cbInformacao.SelectedIndex)
                {
                    case 0:
                        chart2.Visible = false;
                        chart1.Visible = true;
                        chart1.Series["Series1"].LegendText = "Valor dos lucros (R$)";
                        lista = f.GraficosAnoLucro(datFiltro.Value.ToString("yyyy")).Tables[0];
                        chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        chart1.Series["Series2"].IsVisibleInLegend = false;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart1.Series["Series1"].Points.AddXY(row[0], row[1]);
                        }
                        break;
                    case 1:
                        chart2.Visible = false;
                        chart1.Visible = true;
                        chart1.Series["Series1"].LegendText = "Valor dos lucros (R$)";
                        lista = f.GraficosAnoLucro(datFiltro.Value.ToString("yyyy")).Tables[0];
                        chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                        chart1.Series["Series2"].IsVisibleInLegend = false;
                        foreach (DataRow row in lista.Rows)
                        {
                            chart1.Series["Series1"].Points.AddXY(row[0], row[1]);
                        }
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Sair(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
