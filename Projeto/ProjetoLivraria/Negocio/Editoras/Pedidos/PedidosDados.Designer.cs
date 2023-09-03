namespace ProjetoLivraria.Negocio.Editoras.Pedidos
{
    partial class PedidosDados
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
            this.cbEditoras = new System.Windows.Forms.ComboBox();
            this.lblEditoras = new System.Windows.Forms.Label();
            this.lblEmissao = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.datDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.datDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbLivrosPedido = new System.Windows.Forms.GroupBox();
            this.pnValor = new System.Windows.Forms.Panel();
            this.lblValor = new System.Windows.Forms.Label();
            this.lbltv = new System.Windows.Forms.Label();
            this.gbRemover = new System.Windows.Forms.GroupBox();
            this.pbRemover = new System.Windows.Forms.PictureBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.nudQuantidadeRemover = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvLivrosPedido = new System.Windows.Forms.DataGridView();
            this.gbLivros = new System.Windows.Forms.GroupBox();
            this.pbAdicionar = new System.Windows.Forms.PictureBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.gbLivrosPedido.SuspendLayout();
            this.pnValor.SuspendLayout();
            this.gbRemover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeRemover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivrosPedido)).BeginInit();
            this.gbLivros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.lblEntrega);
            this.pnPrincipal.Controls.Add(this.btnSalvar);
            this.pnPrincipal.Controls.Add(this.datDataEntrega);
            this.pnPrincipal.Controls.Add(this.label5);
            this.pnPrincipal.Controls.Add(this.groupBox4);
            this.pnPrincipal.Controls.Add(this.btnCancelar);
            this.pnPrincipal.Controls.Add(this.cbEditoras);
            this.pnPrincipal.Controls.Add(this.lblEditoras);
            this.pnPrincipal.Controls.Add(this.lblEmissao);
            this.pnPrincipal.Controls.Add(this.txtCodigo);
            this.pnPrincipal.Controls.Add(this.lblCodigo);
            this.pnPrincipal.Controls.Add(this.datDataEmissao);
            // 
            // pnMarcaMenu
            // 
            this.pnMarcaMenu.Location = new System.Drawing.Point(0, 269);
            this.pnMarcaMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(96, 25);
            this.lblTitulo.Text = "Pedidos";
            // 
            // pbSetaVoltar
            // 
            this.pbSetaVoltar.Click += new System.EventHandler(this.Voltar);
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Location = new System.Drawing.Point(476, 20);
            // 
            // lblFuncaoUsuario
            // 
            this.lblFuncaoUsuario.Location = new System.Drawing.Point(476, 36);
            // 
            // cbEditoras
            // 
            this.cbEditoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditoras.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditoras.FormattingEnabled = true;
            this.cbEditoras.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outros",
            "Não Informar"});
            this.cbEditoras.Location = new System.Drawing.Point(115, 47);
            this.cbEditoras.Name = "cbEditoras";
            this.cbEditoras.Size = new System.Drawing.Size(396, 27);
            this.cbEditoras.TabIndex = 91;
            this.cbEditoras.SelectedIndexChanged += new System.EventHandler(this.ListarLivrosEditora);
            // 
            // lblEditoras
            // 
            this.lblEditoras.AutoSize = true;
            this.lblEditoras.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditoras.Location = new System.Drawing.Point(112, 26);
            this.lblEditoras.Name = "lblEditoras";
            this.lblEditoras.Size = new System.Drawing.Size(58, 19);
            this.lblEditoras.TabIndex = 90;
            this.lblEditoras.Text = "Editora";
            // 
            // lblEmissao
            // 
            this.lblEmissao.AutoSize = true;
            this.lblEmissao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmissao.Location = new System.Drawing.Point(512, 27);
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Size = new System.Drawing.Size(62, 19);
            this.lblEmissao.TabIndex = 89;
            this.lblEmissao.Text = "Emissão";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(26, 48);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(84, 24);
            this.txtCodigo.TabIndex = 85;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(22, 28);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 19);
            this.lblCodigo.TabIndex = 84;
            this.lblCodigo.Text = "Código";
            // 
            // datDataEmissao
            // 
            this.datDataEmissao.CustomFormat = "DD/MM/YYYY";
            this.datDataEmissao.Enabled = false;
            this.datDataEmissao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datDataEmissao.Location = new System.Drawing.Point(515, 48);
            this.datDataEmissao.Name = "datDataEmissao";
            this.datDataEmissao.Size = new System.Drawing.Size(99, 24);
            this.datDataEmissao.TabIndex = 88;
            // 
            // lblEntrega
            // 
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrega.Location = new System.Drawing.Point(617, 27);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(63, 19);
            this.lblEntrega.TabIndex = 95;
            this.lblEntrega.Text = "Entrega";
            // 
            // datDataEntrega
            // 
            this.datDataEntrega.CustomFormat = "DD/MM/YYYY";
            this.datDataEntrega.Enabled = false;
            this.datDataEntrega.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datDataEntrega.Location = new System.Drawing.Point(620, 48);
            this.datDataEntrega.Name = "datDataEntrega";
            this.datDataEntrega.Size = new System.Drawing.Size(99, 24);
            this.datDataEntrega.TabIndex = 94;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.gbLivrosPedido);
            this.groupBox4.Controls.Add(this.gbLivros);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(26, 81);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(693, 464);
            this.groupBox4.TabIndex = 102;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Livros";
            // 
            // gbLivrosPedido
            // 
            this.gbLivrosPedido.BackColor = System.Drawing.Color.LightGray;
            this.gbLivrosPedido.Controls.Add(this.pnValor);
            this.gbLivrosPedido.Controls.Add(this.lbltv);
            this.gbLivrosPedido.Controls.Add(this.gbRemover);
            this.gbLivrosPedido.Controls.Add(this.dgvLivrosPedido);
            this.gbLivrosPedido.Location = new System.Drawing.Point(353, 37);
            this.gbLivrosPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLivrosPedido.Name = "gbLivrosPedido";
            this.gbLivrosPedido.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLivrosPedido.Size = new System.Drawing.Size(328, 414);
            this.gbLivrosPedido.TabIndex = 111;
            this.gbLivrosPedido.TabStop = false;
            this.gbLivrosPedido.Text = "Livros do Pedido";
            // 
            // pnValor
            // 
            this.pnValor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnValor.Controls.Add(this.lblValor);
            this.pnValor.Location = new System.Drawing.Point(160, 329);
            this.pnValor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnValor.Name = "pnValor";
            this.pnValor.Size = new System.Drawing.Size(163, 72);
            this.pnValor.TabIndex = 37;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblValor.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(37, 18);
            this.lblValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblValor.Size = new System.Drawing.Size(93, 34);
            this.lblValor.TabIndex = 29;
            this.lblValor.Text = "R$ 0,00";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltv
            // 
            this.lbltv.AutoSize = true;
            this.lbltv.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltv.Location = new System.Drawing.Point(158, 308);
            this.lbltv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltv.Name = "lbltv";
            this.lbltv.Size = new System.Drawing.Size(132, 18);
            this.lbltv.TabIndex = 36;
            this.lbltv.Text = "Valor do Pedido:";
            // 
            // gbRemover
            // 
            this.gbRemover.BackColor = System.Drawing.Color.Silver;
            this.gbRemover.Controls.Add(this.pbRemover);
            this.gbRemover.Controls.Add(this.chkTodos);
            this.gbRemover.Controls.Add(this.nudQuantidadeRemover);
            this.gbRemover.Controls.Add(this.label17);
            this.gbRemover.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRemover.Location = new System.Drawing.Point(10, 310);
            this.gbRemover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRemover.Name = "gbRemover";
            this.gbRemover.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRemover.Size = new System.Drawing.Size(143, 93);
            this.gbRemover.TabIndex = 35;
            this.gbRemover.TabStop = false;
            this.gbRemover.Text = "Remover";
            // 
            // pbRemover
            // 
            this.pbRemover.BackColor = System.Drawing.Color.DimGray;
            this.pbRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRemover.Image = global::ProjetoLivraria.Properties.Resources.btnCancelar;
            this.pbRemover.Location = new System.Drawing.Point(111, 54);
            this.pbRemover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbRemover.Name = "pbRemover";
            this.pbRemover.Size = new System.Drawing.Size(22, 26);
            this.pbRemover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRemover.TabIndex = 24;
            this.pbRemover.TabStop = false;
            this.pbRemover.Click += new System.EventHandler(this.Remover);
            this.pbRemover.MouseEnter += new System.EventHandler(this.MouseE);
            this.pbRemover.MouseLeave += new System.EventHandler(this.MouseD);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodos.Location = new System.Drawing.Point(10, 30);
            this.chkTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(66, 23);
            this.chkTodos.TabIndex = 25;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.Todos);
            // 
            // nudQuantidadeRemover
            // 
            this.nudQuantidadeRemover.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidadeRemover.Location = new System.Drawing.Point(56, 55);
            this.nudQuantidadeRemover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudQuantidadeRemover.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantidadeRemover.Name = "nudQuantidadeRemover";
            this.nudQuantidadeRemover.Size = new System.Drawing.Size(50, 24);
            this.nudQuantidadeRemover.TabIndex = 24;
            this.nudQuantidadeRemover.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 58);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 19);
            this.label17.TabIndex = 23;
            this.label17.Text = "Qtde.";
            // 
            // dgvLivrosPedido
            // 
            this.dgvLivrosPedido.AllowUserToAddRows = false;
            this.dgvLivrosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivrosPedido.Location = new System.Drawing.Point(10, 25);
            this.dgvLivrosPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLivrosPedido.Name = "dgvLivrosPedido";
            this.dgvLivrosPedido.RowTemplate.Height = 24;
            this.dgvLivrosPedido.Size = new System.Drawing.Size(311, 278);
            this.dgvLivrosPedido.TabIndex = 34;
            this.dgvLivrosPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LimitarRemocao);
            // 
            // gbLivros
            // 
            this.gbLivros.BackColor = System.Drawing.Color.LightGray;
            this.gbLivros.Controls.Add(this.pbAdicionar);
            this.gbLivros.Controls.Add(this.nudQuantidade);
            this.gbLivros.Controls.Add(this.label16);
            this.gbLivros.Controls.Add(this.dgvLivros);
            this.gbLivros.Location = new System.Drawing.Point(12, 37);
            this.gbLivros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLivros.Name = "gbLivros";
            this.gbLivros.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLivros.Size = new System.Drawing.Size(337, 414);
            this.gbLivros.TabIndex = 110;
            this.gbLivros.TabStop = false;
            this.gbLivros.Text = "Livros da Editora";
            // 
            // pbAdicionar
            // 
            this.pbAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.pbAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdicionar.Image = global::ProjetoLivraria.Properties.Resources.btnAdicionar;
            this.pbAdicionar.Location = new System.Drawing.Point(303, 376);
            this.pbAdicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbAdicionar.Name = "pbAdicionar";
            this.pbAdicionar.Size = new System.Drawing.Size(22, 26);
            this.pbAdicionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdicionar.TabIndex = 115;
            this.pbAdicionar.TabStop = false;
            this.pbAdicionar.Click += new System.EventHandler(this.Adicionar);
            this.pbAdicionar.MouseEnter += new System.EventHandler(this.MouseE);
            this.pbAdicionar.MouseLeave += new System.EventHandler(this.MouseD);
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(64, 376);
            this.nudQuantidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudQuantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(234, 27);
            this.nudQuantidade.TabIndex = 114;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 384);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 21);
            this.label16.TabIndex = 113;
            this.label16.Text = "Qtde.";
            // 
            // dgvLivros
            // 
            this.dgvLivros.AllowUserToAddRows = false;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Location = new System.Drawing.Point(14, 25);
            this.dgvLivros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.RowTemplate.Height = 24;
            this.dgvLivros.Size = new System.Drawing.Size(311, 344);
            this.dgvLivros.TabIndex = 111;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSalvar.Image = global::ProjetoLivraria.Properties.Resources.btnSalvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(462, 550);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(125, 117);
            this.btnSalvar.TabIndex = 114;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(388, 652);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 112;
            this.label5.Text = "label5";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCancelar.Image = global::ProjetoLivraria.Properties.Resources.btnCancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(593, 550);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 117);
            this.btnCancelar.TabIndex = 113;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.Voltar);
            // 
            // PedidosDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 640);
            this.Name = "PedidosDados";
            this.Text = "PedidosDados";
            this.Load += new System.EventHandler(this.Carregar);
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.gbLivrosPedido.ResumeLayout(false);
            this.gbLivrosPedido.PerformLayout();
            this.pnValor.ResumeLayout(false);
            this.pnValor.PerformLayout();
            this.gbRemover.ResumeLayout(false);
            this.gbRemover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidadeRemover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivrosPedido)).EndInit();
            this.gbLivros.ResumeLayout(false);
            this.gbLivros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdicionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbEditoras;
        public System.Windows.Forms.Label lblEditoras;
        public System.Windows.Forms.Label lblEmissao;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.DateTimePicker datDataEmissao;
        public System.Windows.Forms.Label lblEntrega;
        public System.Windows.Forms.DateTimePicker datDataEntrega;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pbRemover;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.NumericUpDown nudQuantidadeRemover;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pbAdicionar;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.GroupBox gbLivrosPedido;
        public System.Windows.Forms.Panel pnValor;
        public System.Windows.Forms.Label lblValor;
        public System.Windows.Forms.Label lbltv;
        public System.Windows.Forms.GroupBox gbRemover;
        public System.Windows.Forms.DataGridView dgvLivrosPedido;
        public System.Windows.Forms.GroupBox gbLivros;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnCancelar;
    }
}