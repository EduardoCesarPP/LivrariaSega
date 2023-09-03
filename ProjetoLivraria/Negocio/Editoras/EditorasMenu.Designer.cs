namespace ProjetoLivraria.Negocio.Editoras
{
    partial class EditorasMenu
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
            this.SuspendLayout();
            // 
            // btnOpcao
            // 
            this.btnOpcao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnOpcao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnOpcao.Image = global::ProjetoLivraria.Properties.Resources.btnPedidos;
            this.btnOpcao.Text = "\r\nPedidos";
            this.btnOpcao.Click += new System.EventHandler(this.Opcao);
            // 
            // btnOpcao1
            // 
            this.btnOpcao1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnOpcao1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnOpcao1.Image = global::ProjetoLivraria.Properties.Resources.btnEditoras;
            this.btnOpcao1.Text = "\r\nNossas Editoras";
            this.btnOpcao1.Click += new System.EventHandler(this.Opcao);
            // 
            // pnMarcaMenu
            // 
            this.pnMarcaMenu.Location = new System.Drawing.Point(0, 331);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(535, 145);
            this.lblTitulo.Size = new System.Drawing.Size(122, 34);
            this.lblTitulo.Text = "Editoras";
            // 
            // pbSetaVoltar
            // 
            this.pbSetaVoltar.Visible = false;
            // 
            // EditorasMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 825);
            this.Name = "EditorasMenu";
            this.Text = "EditorasMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}