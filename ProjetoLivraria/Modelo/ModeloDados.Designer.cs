namespace ProjetoLivraria.Modelo
{
    partial class ModeloDados
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
            this.pnPrincipal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Location = new System.Drawing.Point(635, 30);
            this.lblNomeUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeUsuario.Size = new System.Drawing.Size(184, 30);
            this.lblNomeUsuario.Text = "Bem Vindo(a) ";
            // 
            // lblFuncaoUsuario
            // 
            this.lblFuncaoUsuario.Location = new System.Drawing.Point(635, 54);
            this.lblFuncaoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuncaoUsuario.Size = new System.Drawing.Size(0, 21);
            this.lblFuncaoUsuario.Text = "";
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Location = new System.Drawing.Point(349, 196);
            this.pnPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(999, 560);
            this.pnPrincipal.TabIndex = 14;
            // 
            // ModeloDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 788);
            this.Controls.Add(this.pnPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "ModeloDados";
            this.Text = "ModeloDados";
            this.Load += new System.EventHandler(this.ModeloDados_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.pbSetaVoltar, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.pnPrincipal, 0);
            this.Controls.SetChildIndex(this.Logo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnPrincipal;
    }
}