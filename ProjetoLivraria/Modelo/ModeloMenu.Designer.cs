namespace ProjetoLivraria.Modelo
{
    partial class ModeloMenu
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
            this.btnOpcao = new System.Windows.Forms.Button();
            this.btnOpcao1 = new System.Windows.Forms.Button();
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
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Size = new System.Drawing.Size(1081, 108);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // btnOpcao
            // 
            this.btnOpcao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnOpcao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnOpcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcao.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcao.Location = new System.Drawing.Point(841, 230);
            this.btnOpcao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpcao.Name = "btnOpcao";
            this.btnOpcao.Size = new System.Drawing.Size(485, 527);
            this.btnOpcao.TabIndex = 19;
            this.btnOpcao.Text = "Texto";
            this.btnOpcao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpcao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpcao.UseVisualStyleBackColor = true;
            // 
            // btnOpcao1
            // 
            this.btnOpcao1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcao1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnOpcao1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(198)))));
            this.btnOpcao1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcao1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcao1.Location = new System.Drawing.Point(349, 230);
            this.btnOpcao1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpcao1.Name = "btnOpcao1";
            this.btnOpcao1.Size = new System.Drawing.Size(485, 527);
            this.btnOpcao1.TabIndex = 18;
            this.btnOpcao1.Text = "Texto";
            this.btnOpcao1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpcao1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpcao1.UseVisualStyleBackColor = true;
            // 
            // ModeloMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 788);
            this.Controls.Add(this.btnOpcao);
            this.Controls.Add(this.btnOpcao1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "ModeloMenu";
            this.Text = "ModeloMenu";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.pbSetaVoltar, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.btnOpcao1, 0);
            this.Controls.SetChildIndex(this.btnOpcao, 0);
            this.Controls.SetChildIndex(this.Logo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbSetaVoltar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnOpcao;
        public System.Windows.Forms.Button btnOpcao1;
    }
}