namespace ProjetoLivraria.Negocio.Clientes
{
    partial class ClientesDados
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
            this.label5 = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.datDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.gbTel2 = new System.Windows.Forms.GroupBox();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.txtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.gbTel1 = new System.Windows.Forms.GroupBox();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).BeginInit();
            this.gbEndereco.SuspendLayout();
            this.gbContato.SuspendLayout();
            this.gbTel2.SuspendLayout();
            this.gbTel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.btnSalvar);
            this.pnPrincipal.Controls.Add(this.gbEndereco);
            this.pnPrincipal.Controls.Add(this.btnCancelar);
            this.pnPrincipal.Controls.Add(this.gbContato);
            this.pnPrincipal.Controls.Add(this.txtCPF);
            this.pnPrincipal.Controls.Add(this.txtRG);
            this.pnPrincipal.Controls.Add(this.label1);
            this.pnPrincipal.Controls.Add(this.label5);
            this.pnPrincipal.Controls.Add(this.cboGenero);
            this.pnPrincipal.Controls.Add(this.label18);
            this.pnPrincipal.Controls.Add(this.label19);
            this.pnPrincipal.Controls.Add(this.txtCodigo);
            this.pnPrincipal.Controls.Add(this.lblCodigo);
            this.pnPrincipal.Controls.Add(this.datDataNascimento);
            this.pnPrincipal.Controls.Add(this.txtNome);
            this.pnPrincipal.Controls.Add(this.label16);
            this.pnPrincipal.Controls.Add(this.lblNome);
            this.pnPrincipal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnPrincipal.Size = new System.Drawing.Size(999, 610);
            // 
            // pnMarcaMenu
            // 
            this.pnMarcaMenu.Location = new System.Drawing.Point(0, 171);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(125, 34);
            this.lblTitulo.Text = "Clientes";
            // 
            // pbSetaVoltar
            // 
            this.pbSetaVoltar.Click += new System.EventHandler(this.Voltar);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(825, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 21);
            this.label5.TabIndex = 64;
            this.label5.Text = "RG";
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outros",
            "Não Informar"});
            this.cboGenero.Location = new System.Drawing.Point(233, 116);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(259, 29);
            this.cboGenero.TabIndex = 62;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(29, 91);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(187, 21);
            this.label18.TabIndex = 59;
            this.label18.Text = "Data do Nascimento";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(229, 90);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 21);
            this.label19.TabIndex = 61;
            this.label19.Text = "Gênero";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(31, 59);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(111, 28);
            this.txtCodigo.TabIndex = 49;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(27, 34);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(72, 21);
            this.lblCodigo.TabIndex = 48;
            this.lblCodigo.Text = "Código";
            // 
            // datDataNascimento
            // 
            this.datDataNascimento.CustomFormat = "DD/MM/YYYY";
            this.datDataNascimento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datDataNascimento.Location = new System.Drawing.Point(33, 117);
            this.datDataNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.datDataNascimento.Name = "datDataNascimento";
            this.datDataNascimento.Size = new System.Drawing.Size(183, 28);
            this.datDataNascimento.TabIndex = 55;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(154, 59);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(503, 28);
            this.txtNome.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(661, 34);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 21);
            this.label16.TabIndex = 52;
            this.label16.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(150, 34);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 21);
            this.lblNome.TabIndex = 50;
            this.lblNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(523, 638);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 68;
            this.label1.Text = "label1";
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(829, 59);
            this.txtRG.Margin = new System.Windows.Forms.Padding(4);
            this.txtRG.Mask = "  00.000.000-0";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(135, 28);
            this.txtRG.TabIndex = 82;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(665, 59);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Mask = "  000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(156, 28);
            this.txtCPF.TabIndex = 83;
            // 
            // gbEndereco
            // 
            this.gbEndereco.BackColor = System.Drawing.Color.Gainsboro;
            this.gbEndereco.Controls.Add(this.label3);
            this.gbEndereco.Controls.Add(this.txtComplemento);
            this.gbEndereco.Controls.Add(this.txtUF);
            this.gbEndereco.Controls.Add(this.label17);
            this.gbEndereco.Controls.Add(this.txtNumero);
            this.gbEndereco.Controls.Add(this.txtCEP);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.txtRua);
            this.gbEndereco.Controls.Add(this.label13);
            this.gbEndereco.Controls.Add(this.label11);
            this.gbEndereco.Controls.Add(this.label10);
            this.gbEndereco.Controls.Add(this.label9);
            this.gbEndereco.Controls.Add(this.label8);
            this.gbEndereco.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEndereco.Location = new System.Drawing.Point(31, 341);
            this.gbEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Padding = new System.Windows.Forms.Padding(4);
            this.gbEndereco.Size = new System.Drawing.Size(933, 157);
            this.gbEndereco.TabIndex = 85;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(616, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(620, 112);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplemento.MaxLength = 35;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(305, 28);
            this.txtComplemento.TabIndex = 14;
            // 
            // txtUF
            // 
            this.txtUF.Enabled = false;
            this.txtUF.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUF.Location = new System.Drawing.Point(123, 55);
            this.txtUF.Margin = new System.Windows.Forms.Padding(4);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(29, 28);
            this.txtUF.TabIndex = 12;
            this.txtUF.Text = "SP";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(537, 87);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 21);
            this.label17.TabIndex = 4;
            this.label17.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(541, 112);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.MaxLength = 35;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(71, 28);
            this.txtNumero.TabIndex = 5;
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCEP.Location = new System.Drawing.Point(15, 55);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(104, 28);
            this.txtCEP.TabIndex = 1;
            this.txtCEP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CompletaCep);
            this.txtCEP.Leave += new System.EventHandler(this.LeaveCep);
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(541, 55);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.MaxLength = 20;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(384, 28);
            this.txtBairro.TabIndex = 9;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(154, 55);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.MaxLength = 20;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(379, 28);
            this.txtCidade.TabIndex = 7;
            // 
            // txtRua
            // 
            this.txtRua.Enabled = false;
            this.txtRua.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(17, 112);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4);
            this.txtRua.MaxLength = 40;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(516, 28);
            this.txtRua.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(537, 30);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 21);
            this.label13.TabIndex = 8;
            this.label13.Text = "Bairro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(119, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "UF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(150, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "Rua";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "CEP";
            // 
            // gbContato
            // 
            this.gbContato.BackColor = System.Drawing.Color.Gainsboro;
            this.gbContato.Controls.Add(this.gbTel2);
            this.gbContato.Controls.Add(this.gbTel1);
            this.gbContato.Controls.Add(this.lblEmail);
            this.gbContato.Controls.Add(this.txtEmail);
            this.gbContato.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContato.Location = new System.Drawing.Point(33, 153);
            this.gbContato.Margin = new System.Windows.Forms.Padding(4);
            this.gbContato.Name = "gbContato";
            this.gbContato.Padding = new System.Windows.Forms.Padding(4);
            this.gbContato.Size = new System.Drawing.Size(931, 180);
            this.gbContato.TabIndex = 84;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contato";
            // 
            // gbTel2
            // 
            this.gbTel2.BackColor = System.Drawing.Color.LightGray;
            this.gbTel2.Controls.Add(this.rb4);
            this.gbTel2.Controls.Add(this.rb3);
            this.gbTel2.Controls.Add(this.txtTelefone2);
            this.gbTel2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTel2.Location = new System.Drawing.Point(196, 31);
            this.gbTel2.Name = "gbTel2";
            this.gbTel2.Size = new System.Drawing.Size(175, 142);
            this.gbTel2.TabIndex = 10;
            this.gbTel2.TabStop = false;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb4.Location = new System.Drawing.Point(13, 61);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(89, 25);
            this.rb4.TabIndex = 9;
            this.rb4.Tag = "4";
            this.rb4.Text = "Celular";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Checked = true;
            this.rb3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.Location = new System.Drawing.Point(13, 30);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(101, 25);
            this.rb3.TabIndex = 8;
            this.rb3.TabStop = true;
            this.rb3.Tag = "3";
            this.rb3.Text = "Telefone";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone2.Location = new System.Drawing.Point(13, 99);
            this.txtTelefone2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone2.Mask = "(00) 0000-0000";
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(149, 28);
            this.txtTelefone2.TabIndex = 3;
            // 
            // gbTel1
            // 
            this.gbTel1.BackColor = System.Drawing.Color.LightGray;
            this.gbTel1.Controls.Add(this.rb2);
            this.gbTel1.Controls.Add(this.rb1);
            this.gbTel1.Controls.Add(this.txtTelefone);
            this.gbTel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTel1.Location = new System.Drawing.Point(15, 31);
            this.gbTel1.Name = "gbTel1";
            this.gbTel1.Size = new System.Drawing.Size(175, 142);
            this.gbTel1.TabIndex = 8;
            this.gbTel1.TabStop = false;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.Location = new System.Drawing.Point(13, 61);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(89, 25);
            this.rb2.TabIndex = 9;
            this.rb2.Tag = "2";
            this.rb2.Text = "Celular";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(13, 30);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(101, 25);
            this.rb1.TabIndex = 8;
            this.rb1.TabStop = true;
            this.rb1.Tag = "1";
            this.rb1.Text = "Telefone";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(13, 99);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(149, 28);
            this.txtTelefone.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(378, 119);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 21);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(378, 144);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(517, 28);
            this.txtEmail.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSalvar.Image = global::ProjetoLivraria.Properties.Resources.btnSalvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(622, 505);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(167, 144);
            this.btnSalvar.TabIndex = 89;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.Salvar);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCancelar.Image = global::ProjetoLivraria.Properties.Resources.btnCancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(797, 505);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 144);
            this.btnCancelar.TabIndex = 88;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.Voltar);
            // 
            // ClientesDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 825);
            this.Name = "ClientesDados";
            this.Text = "ClientesDados";
            this.Load += new System.EventHandler(this.Carregar);
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).EndInit();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.gbTel2.ResumeLayout(false);
            this.gbTel2.PerformLayout();
            this.gbTel1.ResumeLayout(false);
            this.gbTel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cboGenero;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.DateTimePicker datDataNascimento;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.MaskedTextBox txtRG;
        public System.Windows.Forms.MaskedTextBox txtCPF;
        public System.Windows.Forms.GroupBox gbEndereco;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtComplemento;
        public System.Windows.Forms.TextBox txtUF;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtNumero;
        public System.Windows.Forms.MaskedTextBox txtCEP;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtRua;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.GroupBox gbContato;
        public System.Windows.Forms.GroupBox gbTel2;
        public System.Windows.Forms.RadioButton rb4;
        public System.Windows.Forms.RadioButton rb3;
        public System.Windows.Forms.MaskedTextBox txtTelefone2;
        public System.Windows.Forms.GroupBox gbTel1;
        public System.Windows.Forms.RadioButton rb2;
        public System.Windows.Forms.RadioButton rb1;
        public System.Windows.Forms.MaskedTextBox txtTelefone;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label label1;
    }
}