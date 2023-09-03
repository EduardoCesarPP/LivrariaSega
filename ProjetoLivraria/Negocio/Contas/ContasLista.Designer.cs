namespace ProjetoLivraria.Negocio.Contas
{
    partial class ContasLista
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbPagos = new System.Windows.Forms.RadioButton();
            this.rbNaoPagos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.button7.Image = global::ProjetoLivraria.Properties.Resources.btnContasNova;
            this.button7.Text = "Nova Conta";
            this.Dica.SetToolTip(this.button7, "Cadastrar");
            this.button7.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.button8.Image = global::ProjetoLivraria.Properties.Resources.btnContasConsultar;
            this.button8.Text = "Consultar";
            this.Dica.SetToolTip(this.button8, "Alterar");
            this.button8.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.button9.Image = global::ProjetoLivraria.Properties.Resources.btnContasRegistrar;
            this.button9.Size = new System.Drawing.Size(268, 144);
            this.button9.Text = "Registrar Pagamento";
            this.Dica.SetToolTip(this.button9, "Consultar");
            this.button9.Click += new System.EventHandler(this.RegistrarPagamento);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.Dica.SetToolTip(this.button10, "Sair");
            this.button10.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pesquisar);
            // 
            // pbPesquisar
            // 
            this.pbPesquisar.Click += new System.EventHandler(this.Carregar);
            // 
            // pnMarcaMenu
            // 
            this.pnMarcaMenu.Location = new System.Drawing.Point(0, 491);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(535, 145);
            this.lblTitulo.Size = new System.Drawing.Size(113, 34);
            this.lblTitulo.Text = "Contas";
            // 
            // pbSetaVoltar
            // 
            this.pbSetaVoltar.Visible = false;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Location = new System.Drawing.Point(861, 37);
            // 
            // lblFuncaoUsuario
            // 
            this.lblFuncaoUsuario.Location = new System.Drawing.Point(861, 67);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbPagos);
            this.panel3.Controls.Add(this.rbNaoPagos);
            this.panel3.Location = new System.Drawing.Point(1144, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 54);
            this.panel3.TabIndex = 18;
            // 
            // rbPagos
            // 
            this.rbPagos.AutoSize = true;
            this.rbPagos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPagos.Location = new System.Drawing.Point(0, 27);
            this.rbPagos.Name = "rbPagos";
            this.rbPagos.Size = new System.Drawing.Size(92, 27);
            this.rbPagos.TabIndex = 16;
            this.rbPagos.Text = "Pagas";
            this.rbPagos.UseVisualStyleBackColor = true;
            this.rbPagos.CheckedChanged += new System.EventHandler(this.Carregar);
            // 
            // rbNaoPagos
            // 
            this.rbNaoPagos.AutoSize = true;
            this.rbNaoPagos.Checked = true;
            this.rbNaoPagos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNaoPagos.Location = new System.Drawing.Point(0, 0);
            this.rbNaoPagos.Name = "rbNaoPagos";
            this.rbNaoPagos.Size = new System.Drawing.Size(140, 27);
            this.rbNaoPagos.TabIndex = 15;
            this.rbNaoPagos.TabStop = true;
            this.rbNaoPagos.Text = "Não Pagas";
            this.rbNaoPagos.UseVisualStyleBackColor = true;
            this.rbNaoPagos.CheckedChanged += new System.EventHandler(this.Carregar);
            // 
            // ContasLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 825);
            this.Controls.Add(this.panel3);
            this.Name = "ContasLista";
            this.Text = "ContasLista";
            this.Load += new System.EventHandler(this.Carregar);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.pbSetaVoltar, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.button7, 0);
            this.Controls.SetChildIndex(this.button8, 0);
            this.Controls.SetChildIndex(this.button9, 0);
            this.Controls.SetChildIndex(this.button10, 0);
            this.Controls.SetChildIndex(this.pbPesquisar, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.Logo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbPagos;
        private System.Windows.Forms.RadioButton rbNaoPagos;
    }
}