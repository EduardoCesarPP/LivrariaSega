namespace ProjetoLivraria.Negocio.Livros.Estoque
{
    partial class EstoqueMenu
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
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpcao
            // 
            this.btnOpcao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnOpcao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnOpcao.Image = global::ProjetoLivraria.Properties.Resources.btnEstoqueHomologacao;
            this.btnOpcao.Text = "\r\nHomologação";
            this.btnOpcao.Click += new System.EventHandler(this.Opcao);
            // 
            // btnOpcao1
            // 
            this.btnOpcao1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnOpcao1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnOpcao1.Image = global::ProjetoLivraria.Properties.Resources.btnEstoqueConsulta;
            this.btnOpcao1.Text = "\r\nConsulta";
            this.btnOpcao1.Click += new System.EventHandler(this.Opcao);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(179, 25);
            this.lblTitulo.Text = "Livros > Estoque";
            // 
            // pbSetaVoltar
            // 
            this.pbSetaVoltar.Click += new System.EventHandler(this.PbSetaVoltar_Click);
            // 
            // lblFuncaoUsuario
            // 
            this.lblFuncaoUsuario.Location = new System.Drawing.Point(476, 44);
            this.lblFuncaoUsuario.Size = new System.Drawing.Size(0, 19);
            this.lblFuncaoUsuario.Text = "";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Location = new System.Drawing.Point(476, 24);
            this.lblNomeUsuario.Size = new System.Drawing.Size(142, 22);
            this.lblNomeUsuario.Text = "Bem Vindo(a) ";
            // 
            // EstoqueMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 640);
            this.Name = "EstoqueMenu";
            this.Text = "EstoqueMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}