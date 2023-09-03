namespace ProjetoLivraria.Negocio.Contas
{
    partial class ContasDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContasDados));
            this.nudParcelas = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtValorParcela = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtEmissao = new System.Windows.Forms.DateTimePicker();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnTrocarVenc = new System.Windows.Forms.Button();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.btnInserirPag = new System.Windows.Forms.Button();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.pnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).BeginInit();
            this.gbContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.gbContato);
            this.pnPrincipal.Controls.Add(this.button11);
            this.pnPrincipal.Controls.Add(this.button10);
            this.pnPrincipal.Controls.Add(this.dtEmissao);
            this.pnPrincipal.Controls.Add(this.label2);
            this.pnPrincipal.Controls.Add(this.label5);
            this.pnPrincipal.Controls.Add(this.txtValor);
            this.pnPrincipal.Controls.Add(this.txtDocumento);
            this.pnPrincipal.Controls.Add(this.label1);
            this.pnPrincipal.Controls.Add(this.txtCodigo);
            this.pnPrincipal.Controls.Add(this.lblCodigo);
            this.pnPrincipal.Controls.Add(this.txtNome);
            this.pnPrincipal.Controls.Add(this.lblNome);
            // 
            // pnMarcaMenu
            // 
            this.pnMarcaMenu.Location = new System.Drawing.Point(0, 491);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(113, 34);
            this.lblTitulo.Text = "Contas";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // pbSetaVoltar
            // 
            this.pbSetaVoltar.Click += new System.EventHandler(this.Voltar);
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Location = new System.Drawing.Point(861, 37);
            // 
            // lblFuncaoUsuario
            // 
            this.lblFuncaoUsuario.Location = new System.Drawing.Point(861, 67);
            // 
            // nudParcelas
            // 
            this.nudParcelas.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.nudParcelas.Location = new System.Drawing.Point(22, 61);
            this.nudParcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudParcelas.Name = "nudParcelas";
            this.nudParcelas.Size = new System.Drawing.Size(77, 28);
            this.nudParcelas.TabIndex = 94;
            this.nudParcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudParcelas.ValueChanged += new System.EventHandler(this.CalcularParcela);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 37);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 21);
            this.label19.TabIndex = 91;
            this.label19.Text = "Qtde.";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(30, 59);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(111, 28);
            this.txtCodigo.TabIndex = 87;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(26, 34);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(72, 21);
            this.lblCodigo.TabIndex = 86;
            this.lblCodigo.Text = "Código";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(154, 59);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(810, 28);
            this.txtNome.TabIndex = 89;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(150, 34);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(303, 21);
            this.lblNome.TabIndex = 88;
            this.lblNome.Text = "Destino da Conta / Cliente / Nome";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(30, 139);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(401, 28);
            this.txtDocumento.TabIndex = 97;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RestringirCaracteres);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 21);
            this.label1.TabIndex = 96;
            this.label1.Text = "Número do Documento";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(439, 139);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(115, 28);
            this.txtValor.TabIndex = 99;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RestringirCaracteres);
            this.txtValor.Leave += new System.EventHandler(this.FormatarValor);
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.Enabled = false;
            this.txtValorParcela.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorParcela.Location = new System.Drawing.Point(115, 61);
            this.txtValorParcela.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.Size = new System.Drawing.Size(107, 28);
            this.txtValorParcela.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 100;
            this.label5.Text = "Valor (R$)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 21);
            this.label6.TabIndex = 102;
            this.label6.Text = "Val/Parcela (R$)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(557, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 104;
            this.label2.Text = "Dt. de Emissão";
            // 
            // dtEmissao
            // 
            this.dtEmissao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEmissao.Location = new System.Drawing.Point(561, 139);
            this.dtEmissao.Name = "dtEmissao";
            this.dtEmissao.Size = new System.Drawing.Size(131, 28);
            this.dtEmissao.TabIndex = 105;
            // 
            // dtVencimento
            // 
            this.dtVencimento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimento.Location = new System.Drawing.Point(280, 61);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(176, 28);
            this.dtVencimento.TabIndex = 107;
            this.dtVencimento.ValueChanged += new System.EventHandler(this.MudarDatas);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 21);
            this.label3.TabIndex = 106;
            this.label3.Text = "Primeiro Vencimento";
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Image = global::ProjetoLivraria.Properties.Resources.btnCancelar;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.Location = new System.Drawing.Point(797, 583);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(167, 143);
            this.button11.TabIndex = 112;
            this.button11.Text = "Cancelar";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dica.SetToolTip(this.button11, "Sair");
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Voltar);
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Image = global::ProjetoLivraria.Properties.Resources.btnSalvar;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.Location = new System.Drawing.Point(618, 583);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(167, 143);
            this.button10.TabIndex = 111;
            this.button10.Text = "Salvar";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dica.SetToolTip(this.button10, "Sair");
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Salvar);
            // 
            // btnTrocarVenc
            // 
            this.btnTrocarVenc.Enabled = false;
            this.btnTrocarVenc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrocarVenc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocarVenc.Image = ((System.Drawing.Image)(resources.GetObject("btnTrocarVenc.Image")));
            this.btnTrocarVenc.Location = new System.Drawing.Point(672, 102);
            this.btnTrocarVenc.Name = "btnTrocarVenc";
            this.btnTrocarVenc.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTrocarVenc.Size = new System.Drawing.Size(255, 83);
            this.btnTrocarVenc.TabIndex = 115;
            this.btnTrocarVenc.Text = " Trocar Vencimento";
            this.btnTrocarVenc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrocarVenc.UseVisualStyleBackColor = true;
            this.btnTrocarVenc.Click += new System.EventHandler(this.TrocarVencimento);
            // 
            // gbContato
            // 
            this.gbContato.BackColor = System.Drawing.Color.Gainsboro;
            this.gbContato.Controls.Add(this.btnInserirPag);
            this.gbContato.Controls.Add(this.dgvParcelas);
            this.gbContato.Controls.Add(this.dtVencimento);
            this.gbContato.Controls.Add(this.btnTrocarVenc);
            this.gbContato.Controls.Add(this.label19);
            this.gbContato.Controls.Add(this.nudParcelas);
            this.gbContato.Controls.Add(this.txtValorParcela);
            this.gbContato.Controls.Add(this.label6);
            this.gbContato.Controls.Add(this.label3);
            this.gbContato.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContato.Location = new System.Drawing.Point(30, 185);
            this.gbContato.Margin = new System.Windows.Forms.Padding(4);
            this.gbContato.Name = "gbContato";
            this.gbContato.Padding = new System.Windows.Forms.Padding(4);
            this.gbContato.Size = new System.Drawing.Size(934, 381);
            this.gbContato.TabIndex = 116;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Parcelas";
            // 
            // btnInserirPag
            // 
            this.btnInserirPag.Enabled = false;
            this.btnInserirPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirPag.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirPag.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirPag.Image")));
            this.btnInserirPag.Location = new System.Drawing.Point(672, 194);
            this.btnInserirPag.Name = "btnInserirPag";
            this.btnInserirPag.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInserirPag.Size = new System.Drawing.Size(255, 83);
            this.btnInserirPag.TabIndex = 120;
            this.btnInserirPag.Text = " Inserir Pagamento";
            this.btnInserirPag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserirPag.UseVisualStyleBackColor = true;
            this.btnInserirPag.Click += new System.EventHandler(this.InserirPagamento);
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.AllowUserToResizeRows = false;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Location = new System.Drawing.Point(22, 102);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.RowHeadersWidth = 51;
            this.dgvParcelas.RowTemplate.Height = 24;
            this.dgvParcelas.Size = new System.Drawing.Size(640, 268);
            this.dgvParcelas.TabIndex = 116;
            this.dgvParcelas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MudarBotoes);
            // 
            // ContasDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 825);
            this.Name = "ContasDados";
            this.Text = "ContasDados";
            this.Load += new System.EventHandler(this.Carregar);
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).EndInit();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudParcelas;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtEmissao;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtValorParcela;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.TextBox txtDocumento;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button11;
        public System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnTrocarVenc;
        public System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.Button btnInserirPag;
    }
}