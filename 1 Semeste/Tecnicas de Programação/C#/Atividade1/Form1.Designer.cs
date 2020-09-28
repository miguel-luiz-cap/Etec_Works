namespace Aula_TP_01_09_20
{
    partial class frmProjeto01
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnApagar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblEsporte = new System.Windows.Forms.Label();
			this.txtEsporte = new System.Windows.Forms.TextBox();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnApagar
			// 
			this.btnApagar.Location = new System.Drawing.Point(69, 88);
			this.btnApagar.Name = "btnApagar";
			this.btnApagar.Size = new System.Drawing.Size(75, 23);
			this.btnApagar.TabIndex = 0;
			this.btnApagar.Text = "Executar";
			this.btnApagar.UseVisualStyleBackColor = true;
			this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(390, 88);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 23);
			this.btnSair.TabIndex = 1;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(69, 40);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(100, 20);
			this.txtNome.TabIndex = 2;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.Location = new System.Drawing.Point(33, 13);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(176, 24);
			this.lblNome.TabIndex = 3;
			this.lblNome.Text = "Digite seu Nome";
			// 
			// lblEsporte
			// 
			this.lblEsporte.AutoSize = true;
			this.lblEsporte.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEsporte.Location = new System.Drawing.Point(226, 13);
			this.lblEsporte.Name = "lblEsporte";
			this.lblEsporte.Size = new System.Drawing.Size(300, 24);
			this.lblEsporte.TabIndex = 4;
			this.lblEsporte.Text = "Qual o seu esporte Favorito?";
			// 
			// txtEsporte
			// 
			this.txtEsporte.Location = new System.Drawing.Point(296, 40);
			this.txtEsporte.Name = "txtEsporte";
			this.txtEsporte.Size = new System.Drawing.Size(169, 20);
			this.txtEsporte.TabIndex = 5;
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(230, 88);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpar.TabIndex = 6;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// frmProjeto01
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 123);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.txtEsporte);
			this.Controls.Add(this.lblEsporte);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnApagar);
			this.Name = "frmProjeto01";
			this.Text = "MessageBox";
			//this.Load += new System.EventHandler(this.frmProjeto01_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblEsporte;
		private System.Windows.Forms.TextBox txtEsporte;
		private System.Windows.Forms.Button btnLimpar;
	}
}

