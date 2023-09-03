namespace ProjetoLivraria.Negocio.Editoras.Pedidos
{
    partial class PedidosLista
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
            this.rbNaoEntregues = new System.Windows.Forms.RadioButton();
            this.rbEntregues = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.button7.Image = global::ProjetoLivraria.Properties.Resources.btnPedidosNovo;
            this.button7.Text = "Novo Pedido";
            this.Dica.SetToolTip(this.button7, "Cadastrar");
            this.button7.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.button8.Image = global::ProjetoLivraria.Properties.Resources.btnPedidosConsultar;
            this.button8.Text = "Consultar";
            this.Dica.SetToolTip(this.button8, "Alterar");
            this.button8.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.button9.Image = global::ProjetoLivraria.Properties.Resources.btnPedidosRegistrar;
            this.button9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button9.Size = new System.Drawing.Size(172, 117);
            this.button9.Text = "Registrar Chegada";
            this.Dica.SetToolTip(this.button9, "Registrar ");
            this.button9.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.Dica.SetToolTip(this.button10, "Sair");
            // 
            // textBox1
            // 
            this.textBox1.Size = new System.Drawing.Size(103, 30);
            this.textBox1.Visible = false;
            // 
            // pbPesquisar
            // 
            this.pbPesquisar.Location = new System.Drawing.Point(369, 169);
            this.pbPesquisar.Visible = false;
            // 
            // pnMarcaMenu
            // 
            this.pnMarcaMenu.Location = new System.Drawing.Point(0, 269);
            this.pnMarcaMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(205, 25);
            this.lblTitulo.Text = "Editoras > Pedidos";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Location = new System.Drawing.Point(476, 20);
            // 
            // lblFuncaoUsuario
            // 
            this.lblFuncaoUsuario.Location = new System.Drawing.Point(476, 36);
            // 
            // rbNaoEntregues
            // 
            this.rbNaoEntregues.AutoSize = true;
            this.rbNaoEntregues.Checked = true;
            this.rbNaoEntregues.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNaoEntregues.Location = new System.Drawing.Point(0, 0);
            this.rbNaoEntregues.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNaoEntregues.Name = "rbNaoEntregues";
            this.rbNaoEntregues.Size = new System.Drawing.Size(144, 25);
            this.rbNaoEntregues.TabIndex = 15;
            this.rbNaoEntregues.TabStop = true;
            this.rbNaoEntregues.Text = "Não entregues";
            this.rbNaoEntregues.UseVisualStyleBackColor = true;
            this.rbNaoEntregues.CheckedChanged += new System.EventHandler(this.Carregar);
            // 
            // rbEntregues
            // 
            this.rbEntregues.AutoSize = true;
            this.rbEntregues.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEntregues.Location = new System.Drawing.Point(0, 22);
            this.rbEntregues.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbEntregues.Name = "rbEntregues";
            this.rbEntregues.Size = new System.Drawing.Size(106, 25);
            this.rbEntregues.TabIndex = 16;
            this.rbEntregues.Text = "Entregues";
            this.rbEntregues.UseVisualStyleBackColor = true;
            this.rbEntregues.CheckedChanged += new System.EventHandler(this.Carregar);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbEntregues);
            this.panel3.Controls.Add(this.rbNaoEntregues);
            this.panel3.Location = new System.Drawing.Point(858, 158);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 44);
            this.panel3.TabIndex = 17;
            // 
            // PedidosLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 640);
            this.Controls.Add(this.panel3);
            this.Name = "PedidosLista";
            this.Text = "PedidosLista";
            this.Load += new System.EventHandler(this.Carregar);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.Logo, 0);
            this.Controls.SetChildIndex(this.pbSetaVoltar, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.button7, 0);
            this.Controls.SetChildIndex(this.button8, 0);
            this.Controls.SetChildIndex(this.button9, 0);
            this.Controls.SetChildIndex(this.button10, 0);
            this.Controls.SetChildIndex(this.pbPesquisar, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
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

        private System.Windows.Forms.RadioButton rbNaoEntregues;
        private System.Windows.Forms.RadioButton rbEntregues;
        private System.Windows.Forms.Panel panel3;
    }
}