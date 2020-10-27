namespace Visual_Exemplo3
{
	partial class frm_Signos
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
			this.mtxt_DataNasc = new System.Windows.Forms.MaskedTextBox();
			this.lbl_DataNasc = new System.Windows.Forms.Label();
			this.btn_Exibir = new System.Windows.Forms.Button();
			this.btn_Apagar = new System.Windows.Forms.Button();
			this.btn_Sair = new System.Windows.Forms.Button();
			this.lbl_Signo = new System.Windows.Forms.Label();
			this.pic_Signos = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_Signos)).BeginInit();
			this.SuspendLayout();
			// 
			// mtxt_DataNasc
			// 
			this.mtxt_DataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxt_DataNasc.Location = new System.Drawing.Point(32, 58);
			this.mtxt_DataNasc.Mask = "00/00/0000";
			this.mtxt_DataNasc.Name = "mtxt_DataNasc";
			this.mtxt_DataNasc.Size = new System.Drawing.Size(237, 21);
			this.mtxt_DataNasc.TabIndex = 0;
			this.mtxt_DataNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mtxt_DataNasc.ValidatingType = typeof(System.DateTime);
			// 
			// lbl_DataNasc
			// 
			this.lbl_DataNasc.AutoSize = true;
			this.lbl_DataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_DataNasc.Location = new System.Drawing.Point(28, 35);
			this.lbl_DataNasc.Name = "lbl_DataNasc";
			this.lbl_DataNasc.Size = new System.Drawing.Size(241, 20);
			this.lbl_DataNasc.TabIndex = 1;
			this.lbl_DataNasc.Text = "Digite a data de Nascimento:";
			// 
			// btn_Exibir
			// 
			this.btn_Exibir.Location = new System.Drawing.Point(32, 85);
			this.btn_Exibir.Name = "btn_Exibir";
			this.btn_Exibir.Size = new System.Drawing.Size(237, 36);
			this.btn_Exibir.TabIndex = 2;
			this.btn_Exibir.Text = "Exibir";
			this.btn_Exibir.UseVisualStyleBackColor = true;
			this.btn_Exibir.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn_Apagar
			// 
			this.btn_Apagar.Location = new System.Drawing.Point(194, 154);
			this.btn_Apagar.Name = "btn_Apagar";
			this.btn_Apagar.Size = new System.Drawing.Size(75, 23);
			this.btn_Apagar.TabIndex = 3;
			this.btn_Apagar.Text = "Apagar";
			this.btn_Apagar.UseVisualStyleBackColor = true;
			this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
			// 
			// btn_Sair
			// 
			this.btn_Sair.Location = new System.Drawing.Point(194, 231);
			this.btn_Sair.Name = "btn_Sair";
			this.btn_Sair.Size = new System.Drawing.Size(75, 23);
			this.btn_Sair.TabIndex = 4;
			this.btn_Sair.Text = "Fechar";
			this.btn_Sair.UseVisualStyleBackColor = true;
			this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
			// 
			// lbl_Signo
			// 
			this.lbl_Signo.AutoSize = true;
			this.lbl_Signo.Location = new System.Drawing.Point(29, 138);
			this.lbl_Signo.Name = "lbl_Signo";
			this.lbl_Signo.Size = new System.Drawing.Size(40, 13);
			this.lbl_Signo.TabIndex = 6;
			this.lbl_Signo.Text = "Signo: ";
			// 
			// pic_Signos
			// 
			this.pic_Signos.Location = new System.Drawing.Point(32, 154);
			this.pic_Signos.Name = "pic_Signos";
			this.pic_Signos.Size = new System.Drawing.Size(100, 100);
			this.pic_Signos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_Signos.TabIndex = 7;
			this.pic_Signos.TabStop = false;
			// 
			// frm_Signos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 271);
			this.Controls.Add(this.pic_Signos);
			this.Controls.Add(this.lbl_Signo);
			this.Controls.Add(this.btn_Sair);
			this.Controls.Add(this.btn_Apagar);
			this.Controls.Add(this.btn_Exibir);
			this.Controls.Add(this.lbl_DataNasc);
			this.Controls.Add(this.mtxt_DataNasc);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(310, 310);
			this.MinimumSize = new System.Drawing.Size(310, 310);
			this.Name = "frm_Signos";
			this.Text = "Signos";
			((System.ComponentModel.ISupportInitialize)(this.pic_Signos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox mtxt_DataNasc;
		private System.Windows.Forms.Label lbl_DataNasc;
		private System.Windows.Forms.Button btn_Exibir;
		private System.Windows.Forms.Button btn_Apagar;
		private System.Windows.Forms.Button btn_Sair;
		private System.Windows.Forms.Label lbl_Signo;
		private System.Windows.Forms.PictureBox pic_Signos;
	}
}

