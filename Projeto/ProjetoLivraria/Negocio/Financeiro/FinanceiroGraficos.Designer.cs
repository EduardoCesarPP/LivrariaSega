namespace ProjetoLivraria.Negocio.Financeiro
{
    partial class FinanceiroGraficos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceiroGraficos));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datFiltro = new System.Windows.Forms.DateTimePicker();
            this.rbDia = new System.Windows.Forms.RadioButton();
            this.rbMes = new System.Windows.Forms.RadioButton();
            this.rbAno = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbInformacao = new System.Windows.Forms.ComboBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.label1);
            this.pnPrincipal.Controls.Add(this.button10);
            this.pnPrincipal.Controls.Add(this.panel3);
            this.pnPrincipal.Controls.Add(this.groupBox7);
            this.pnPrincipal.Controls.Add(this.chart2);
            this.pnPrincipal.Controls.Add(this.chart1);
            // 
            // pnMarcaMenu
            // 
            this.pnMarcaMenu.Location = new System.Drawing.Point(0, 571);
            // 
            // pbSetaVoltar
            // 
            this.pbSetaVoltar.Click += new System.EventHandler(this.Sair);
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Location = new System.Drawing.Point(861, 37);
            // 
            // lblFuncaoUsuario
            // 
            this.lblFuncaoUsuario.Location = new System.Drawing.Point(861, 67);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BorderWidth = 10;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(26, 186);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series2";
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(946, 409);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox7.Controls.Add(this.groupBox2);
            this.groupBox7.Controls.Add(this.groupBox1);
            this.groupBox7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(26, 26);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(923, 123);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Filtro";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.datFiltro);
            this.groupBox2.Controls.Add(this.rbDia);
            this.groupBox2.Controls.Add(this.rbMes);
            this.groupBox2.Controls.Add(this.rbAno);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 82);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Período";
            // 
            // datFiltro
            // 
            this.datFiltro.CustomFormat = "yyyy";
            this.datFiltro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datFiltro.Location = new System.Drawing.Point(230, 33);
            this.datFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.datFiltro.Name = "datFiltro";
            this.datFiltro.Size = new System.Drawing.Size(265, 28);
            this.datFiltro.TabIndex = 14;
            this.datFiltro.ValueChanged += new System.EventHandler(this.MudarInformacao);
            // 
            // rbDia
            // 
            this.rbDia.AutoSize = true;
            this.rbDia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDia.Location = new System.Drawing.Point(163, 33);
            this.rbDia.Margin = new System.Windows.Forms.Padding(4);
            this.rbDia.Name = "rbDia";
            this.rbDia.Size = new System.Drawing.Size(59, 25);
            this.rbDia.TabIndex = 13;
            this.rbDia.Text = "Dia";
            this.rbDia.UseVisualStyleBackColor = true;
            this.rbDia.CheckedChanged += new System.EventHandler(this.Carregar);
            // 
            // rbMes
            // 
            this.rbMes.AutoSize = true;
            this.rbMes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMes.Location = new System.Drawing.Point(89, 33);
            this.rbMes.Margin = new System.Windows.Forms.Padding(4);
            this.rbMes.Name = "rbMes";
            this.rbMes.Size = new System.Drawing.Size(66, 25);
            this.rbMes.TabIndex = 12;
            this.rbMes.Text = "Mês";
            this.rbMes.UseVisualStyleBackColor = true;
            this.rbMes.CheckedChanged += new System.EventHandler(this.Carregar);
            // 
            // rbAno
            // 
            this.rbAno.AutoSize = true;
            this.rbAno.Checked = true;
            this.rbAno.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAno.Location = new System.Drawing.Point(16, 33);
            this.rbAno.Margin = new System.Windows.Forms.Padding(4);
            this.rbAno.Name = "rbAno";
            this.rbAno.Size = new System.Drawing.Size(65, 25);
            this.rbAno.TabIndex = 11;
            this.rbAno.TabStop = true;
            this.rbAno.Text = "Ano";
            this.rbAno.UseVisualStyleBackColor = true;
            this.rbAno.CheckedChanged += new System.EventHandler(this.Carregar);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.cbInformacao);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(533, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 82);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação";
            // 
            // cbInformacao
            // 
            this.cbInformacao.FormattingEnabled = true;
            this.cbInformacao.Location = new System.Drawing.Point(18, 33);
            this.cbInformacao.Name = "cbInformacao";
            this.cbInformacao.Size = new System.Drawing.Size(349, 29);
            this.cbInformacao.TabIndex = 0;
            this.cbInformacao.SelectedIndexChanged += new System.EventHandler(this.MudarInformacao);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineColor = System.Drawing.Color.Black;
            this.chart2.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chart2.BorderSkin.BorderWidth = 10;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(26, 186);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(946, 409);
            this.chart2.TabIndex = 24;
            this.chart2.Text = "chart2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label20);
            this.panel3.Location = new System.Drawing.Point(16, 552);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 42);
            this.panel3.TabIndex = 25;
            this.panel3.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(664, 163);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 17);
            this.label20.TabIndex = 26;
            this.label20.Text = "label20";
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.Location = new System.Drawing.Point(783, 570);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(167, 144);
            this.button10.TabIndex = 27;
            this.button10.Text = "Sair";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dica.SetToolTip(this.button10, "Sair");
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Sair);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(688, 717);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "label1";
            // 
            // FinanceiroGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 825);
            this.Name = "FinanceiroGraficos";
            this.Text = "FinanceiroGraficos";
            this.Load += new System.EventHandler(this.Carregar);
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker datFiltro;
        private System.Windows.Forms.RadioButton rbDia;
        private System.Windows.Forms.RadioButton rbMes;
        private System.Windows.Forms.RadioButton rbAno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbInformacao;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
    }
}