namespace ProjetoLivraria.Negocio.Contas
{
    partial class ContasRegistrarPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContasRegistrarPagamento));
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.dtEmissao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPagas = new System.Windows.Forms.DataGridView();
            this.txtParcelas = new System.Windows.Forms.TextBox();
            this.dgvNaoPagas = new System.Windows.Forms.DataGridView();
            this.btnTrocarVenc = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtValorParcela = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDataEmissao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaoPagas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.btnSalvar);
            this.pnPrincipal.Controls.Add(this.txtDataEmissao);
            this.pnPrincipal.Controls.Add(this.gbContato);
            this.pnPrincipal.Controls.Add(this.button11);
            this.pnPrincipal.Controls.Add(this.label2);
            this.pnPrincipal.Controls.Add(this.label5);
            this.pnPrincipal.Controls.Add(this.txtValor);
            this.pnPrincipal.Controls.Add(this.txtDocumento);
            this.pnPrincipal.Controls.Add(this.label1);
            this.pnPrincipal.Controls.Add(this.txtCodigo);
            this.pnPrincipal.Controls.Add(this.label4);
            this.pnPrincipal.Controls.Add(this.txtNome);
            this.pnPrincipal.Controls.Add(this.label20);
            this.pnPrincipal.Size = new System.Drawing.Size(1243, 617);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(434, 34);
            this.lblTitulo.Text = "Contas > Registrar Pagamento";
            // 
            // pbSetaVoltar
            // 
            this.pbSetaVoltar.Click += new System.EventHandler(this.Voltar);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1311, 108);
            // 
            // lblFuncaoUsuario
            // 
            this.lblFuncaoUsuario.Location = new System.Drawing.Point(1049, 67);
            this.lblFuncaoUsuario.Size = new System.Drawing.Size(0, 21);
            this.lblFuncaoUsuario.Text = "";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Location = new System.Drawing.Point(1049, 37);
            this.lblNomeUsuario.Size = new System.Drawing.Size(184, 30);
            this.lblNomeUsuario.Text = "Bem Vindo(a) ";
            // 
            // gbContato
            // 
            this.gbContato.BackColor = System.Drawing.Color.Gainsboro;
            this.gbContato.Controls.Add(this.dtEmissao);
            this.gbContato.Controls.Add(this.label3);
            this.gbContato.Controls.Add(this.dgvPagas);
            this.gbContato.Controls.Add(this.txtParcelas);
            this.gbContato.Controls.Add(this.dgvNaoPagas);
            this.gbContato.Controls.Add(this.btnTrocarVenc);
            this.gbContato.Controls.Add(this.label19);
            this.gbContato.Controls.Add(this.txtValorParcela);
            this.gbContato.Controls.Add(this.label6);
            this.gbContato.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContato.Location = new System.Drawing.Point(24, 185);
            this.gbContato.Margin = new System.Windows.Forms.Padding(4);
            this.gbContato.Name = "gbContato";
            this.gbContato.Padding = new System.Windows.Forms.Padding(4);
            this.gbContato.Size = new System.Drawing.Size(1168, 381);
            this.gbContato.TabIndex = 128;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Parcelas";
            // 
            // dtEmissao
            // 
            this.dtEmissao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEmissao.Location = new System.Drawing.Point(477, 120);
            this.dtEmissao.Name = "dtEmissao";
            this.dtEmissao.Size = new System.Drawing.Size(230, 28);
            this.dtEmissao.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 21);
            this.label3.TabIndex = 123;
            this.label3.Text = "Dt. de Pagamento";
            // 
            // dgvPagas
            // 
            this.dgvPagas.AllowUserToAddRows = false;
            this.dgvPagas.AllowUserToDeleteRows = false;
            this.dgvPagas.AllowUserToResizeRows = false;
            this.dgvPagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagas.Location = new System.Drawing.Point(712, 96);
            this.dgvPagas.Name = "dgvPagas";
            this.dgvPagas.RowTemplate.Height = 24;
            this.dgvPagas.Size = new System.Drawing.Size(444, 268);
            this.dgvPagas.TabIndex = 122;
            this.dgvPagas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MudarBotao);
            // 
            // txtParcelas
            // 
            this.txtParcelas.Location = new System.Drawing.Point(22, 61);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.ReadOnly = true;
            this.txtParcelas.Size = new System.Drawing.Size(89, 28);
            this.txtParcelas.TabIndex = 121;
            // 
            // dgvNaoPagas
            // 
            this.dgvNaoPagas.AllowUserToAddRows = false;
            this.dgvNaoPagas.AllowUserToDeleteRows = false;
            this.dgvNaoPagas.AllowUserToResizeRows = false;
            this.dgvNaoPagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaoPagas.Location = new System.Drawing.Point(22, 96);
            this.dgvNaoPagas.Name = "dgvNaoPagas";
            this.dgvNaoPagas.RowTemplate.Height = 24;
            this.dgvNaoPagas.Size = new System.Drawing.Size(444, 268);
            this.dgvNaoPagas.TabIndex = 116;
            this.dgvNaoPagas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MudarBotao);
            // 
            // btnTrocarVenc
            // 
            this.btnTrocarVenc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrocarVenc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocarVenc.Image = ((System.Drawing.Image)(resources.GetObject("btnTrocarVenc.Image")));
            this.btnTrocarVenc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrocarVenc.Location = new System.Drawing.Point(477, 154);
            this.btnTrocarVenc.Name = "btnTrocarVenc";
            this.btnTrocarVenc.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTrocarVenc.Size = new System.Drawing.Size(230, 83);
            this.btnTrocarVenc.TabIndex = 115;
            this.btnTrocarVenc.Text = "   Registrar\r\n   Pagamento";
            this.btnTrocarVenc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrocarVenc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrocarVenc.UseVisualStyleBackColor = true;
            this.btnTrocarVenc.Click += new System.EventHandler(this.MoverPagamento);
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
            // txtValorParcela
            // 
            this.txtValorParcela.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorParcela.Location = new System.Drawing.Point(124, 61);
            this.txtValorParcela.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.ReadOnly = true;
            this.txtValorParcela.Size = new System.Drawing.Size(179, 28);
            this.txtValorParcela.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 21);
            this.label6.TabIndex = 102;
            this.label6.Text = "Val/Parcela (R$)";
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
            this.button11.Location = new System.Drawing.Point(1025, 574);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(167, 143);
            this.button11.TabIndex = 127;
            this.button11.Text = "Cancelar";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dica.SetToolTip(this.button11, "Sair");
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Voltar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 125;
            this.label2.Text = "Dt. de Emissão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 124;
            this.label5.Text = "Valor (R$)";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(24, 135);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(115, 28);
            this.txtValor.TabIndex = 123;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(791, 59);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(401, 28);
            this.txtDocumento.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(787, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 21);
            this.label1.TabIndex = 121;
            this.label1.Text = "Número do Documento";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(24, 59);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(111, 28);
            this.txtCodigo.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 117;
            this.label4.Text = "Código";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(148, 59);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(635, 28);
            this.txtNome.TabIndex = 120;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(144, 34);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(303, 21);
            this.label20.TabIndex = 119;
            this.label20.Text = "Destino da Conta / Cliente / Nome";
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEmissao.Location = new System.Drawing.Point(148, 135);
            this.txtDataEmissao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.ReadOnly = true;
            this.txtDataEmissao.Size = new System.Drawing.Size(128, 28);
            this.txtDataEmissao.TabIndex = 129;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Image = global::ProjetoLivraria.Properties.Resources.btnSalvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(850, 574);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(167, 143);
            this.btnSalvar.TabIndex = 125;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dica.SetToolTip(this.btnSalvar, "Sair");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // ContasRegistrarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 825);
            this.Name = "ContasRegistrarPagamento";
            this.Text = "ContasRegistrarPagamento";
            this.Load += new System.EventHandler(this.Carregar);
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaoPagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.DataGridView dgvNaoPagas;
        private System.Windows.Forms.Button btnTrocarVenc;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtValorParcela;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button button11;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.TextBox txtDocumento;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtParcelas;
        public System.Windows.Forms.TextBox txtDataEmissao;
        private System.Windows.Forms.DataGridView dgvPagas;
        private System.Windows.Forms.DateTimePicker dtEmissao;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnSalvar;
    }
}