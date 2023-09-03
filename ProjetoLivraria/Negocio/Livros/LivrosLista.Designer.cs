namespace ProjetoLivraria.Negocio.Livros
{
    partial class LivrosLista
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
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.button7.Image = global::ProjetoLivraria.Properties.Resources.btnLivrosCadastrar;
            this.Dica.SetToolTip(this.button7, "Cadastrar");
            this.button7.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.button8.Image = global::ProjetoLivraria.Properties.Resources.btnLivrosAlterar;
            this.Dica.SetToolTip(this.button8, "Alterar");
            this.button8.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.button9.Image = global::ProjetoLivraria.Properties.Resources.btnLivrosConsultar;
            this.Dica.SetToolTip(this.button9, "Consultar");
            this.button9.Click += new System.EventHandler(this.AbrirFormulario);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.Dica.SetToolTip(this.button10, "Sair");
            this.button10.Click += new System.EventHandler(this.Voltar);
            // 
            // textBox1
            // 
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pesquisar);
            // 
            // pbPesquisar
            // 
            this.pbPesquisar.Click += new System.EventHandler(this.Carregar);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(294, 34);
            this.lblTitulo.Text = "Livros > Nossos Livros";
            // 
            // pbSetaVoltar
            // 
            this.pbSetaVoltar.Click += new System.EventHandler(this.Voltar);
            // 
            // lblFuncaoUsuario
            // 
            this.lblFuncaoUsuario.Location = new System.Drawing.Point(861, 67);
            this.lblFuncaoUsuario.Size = new System.Drawing.Size(0, 21);
            this.lblFuncaoUsuario.Text = "";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Location = new System.Drawing.Point(861, 37);
            this.lblNomeUsuario.Size = new System.Drawing.Size(184, 30);
            this.lblNomeUsuario.Text = "Bem Vindo(a) ";
            // 
            // LivrosLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 825);
            this.Name = "LivrosLista";
            this.Text = "";
            this.Load += new System.EventHandler(this.Carregar);
            ((System.ComponentModel.ISupportInitialize)(this.pbPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}