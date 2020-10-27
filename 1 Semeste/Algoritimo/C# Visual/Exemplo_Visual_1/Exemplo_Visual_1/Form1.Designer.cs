namespace Exemplo_Visual_1
{
	partial class Form1
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
			this.btn_Exibir = new System.Windows.Forms.Button();
			this.txt_Data = new System.Windows.Forms.TextBox();
			this.btn_Reset = new System.Windows.Forms.Button();
			this.btn_Sair = new System.Windows.Forms.Button();
			this.txtHora = new System.Windows.Forms.TextBox();
			this.txtData = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblDia = new System.Windows.Forms.Label();
			this.lblMes = new System.Windows.Forms.Label();
			this.lblAno = new System.Windows.Forms.Label();
			this.lblSemana = new System.Windows.Forms.Label();
			this.txtDia = new System.Windows.Forms.TextBox();
			this.txtMes = new System.Windows.Forms.TextBox();
			this.txtAno = new System.Windows.Forms.TextBox();
			this.txtSemana = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn_Exibir
			// 
			this.btn_Exibir.Location = new System.Drawing.Point(7, 12);
			this.btn_Exibir.Name = "btn_Exibir";
			this.btn_Exibir.Size = new System.Drawing.Size(75, 29);
			this.btn_Exibir.TabIndex = 0;
			this.btn_Exibir.Text = "Exibir";
			this.btn_Exibir.UseVisualStyleBackColor = true;
			this.btn_Exibir.Click += new System.EventHandler(this.btn_Exibir_Click);
			// 
			// txt_Data
			// 
			this.txt_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Data.Location = new System.Drawing.Point(88, 12);
			this.txt_Data.Name = "txt_Data";
			this.txt_Data.ReadOnly = true;
			this.txt_Data.Size = new System.Drawing.Size(509, 29);
			this.txt_Data.TabIndex = 1;
			// 
			// btn_Reset
			// 
			this.btn_Reset.Location = new System.Drawing.Point(603, 12);
			this.btn_Reset.Name = "btn_Reset";
			this.btn_Reset.Size = new System.Drawing.Size(75, 29);
			this.btn_Reset.TabIndex = 2;
			this.btn_Reset.Text = "Apagar";
			this.btn_Reset.UseVisualStyleBackColor = true;
			this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
			// 
			// btn_Sair
			// 
			this.btn_Sair.Location = new System.Drawing.Point(603, 207);
			this.btn_Sair.Name = "btn_Sair";
			this.btn_Sair.Size = new System.Drawing.Size(75, 23);
			this.btn_Sair.TabIndex = 3;
			this.btn_Sair.Text = "Sair";
			this.btn_Sair.UseVisualStyleBackColor = true;
			this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
			// 
			// txtHora
			// 
			this.txtHora.Location = new System.Drawing.Point(111, 53);
			this.txtHora.Name = "txtHora";
			this.txtHora.ReadOnly = true;
			this.txtHora.Size = new System.Drawing.Size(324, 20);
			this.txtHora.TabIndex = 4;
			// 
			// txtData
			// 
			this.txtData.Location = new System.Drawing.Point(111, 80);
			this.txtData.Name = "txtData";
			this.txtData.ReadOnly = true;
			this.txtData.Size = new System.Drawing.Size(324, 20);
			this.txtData.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(72, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Hora:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(72, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Data:";
			// 
			// lblDia
			// 
			this.lblDia.AutoSize = true;
			this.lblDia.Location = new System.Drawing.Point(79, 114);
			this.lblDia.Name = "lblDia";
			this.lblDia.Size = new System.Drawing.Size(26, 13);
			this.lblDia.TabIndex = 8;
			this.lblDia.Text = "Dia:";
			// 
			// lblMes
			// 
			this.lblMes.AutoSize = true;
			this.lblMes.Location = new System.Drawing.Point(75, 141);
			this.lblMes.Name = "lblMes";
			this.lblMes.Size = new System.Drawing.Size(30, 13);
			this.lblMes.TabIndex = 9;
			this.lblMes.Text = "Mês:";
			// 
			// lblAno
			// 
			this.lblAno.AutoSize = true;
			this.lblAno.Location = new System.Drawing.Point(76, 171);
			this.lblAno.Name = "lblAno";
			this.lblAno.Size = new System.Drawing.Size(29, 13);
			this.lblAno.TabIndex = 10;
			this.lblAno.Text = "Ano:";
			// 
			// lblSemana
			// 
			this.lblSemana.AutoSize = true;
			this.lblSemana.Location = new System.Drawing.Point(22, 207);
			this.lblSemana.Name = "lblSemana";
			this.lblSemana.Size = new System.Drawing.Size(83, 13);
			this.lblSemana.TabIndex = 11;
			this.lblSemana.Text = "Dia da Semana:";
			// 
			// txtDia
			// 
			this.txtDia.Location = new System.Drawing.Point(111, 111);
			this.txtDia.Name = "txtDia";
			this.txtDia.ReadOnly = true;
			this.txtDia.Size = new System.Drawing.Size(324, 20);
			this.txtDia.TabIndex = 12;
			// 
			// txtMes
			// 
			this.txtMes.Location = new System.Drawing.Point(111, 138);
			this.txtMes.Name = "txtMes";
			this.txtMes.ReadOnly = true;
			this.txtMes.Size = new System.Drawing.Size(324, 20);
			this.txtMes.TabIndex = 13;
			// 
			// txtAno
			// 
			this.txtAno.Location = new System.Drawing.Point(111, 164);
			this.txtAno.Name = "txtAno";
			this.txtAno.ReadOnly = true;
			this.txtAno.Size = new System.Drawing.Size(324, 20);
			this.txtAno.TabIndex = 14;
			// 
			// txtSemana
			// 
			this.txtSemana.Location = new System.Drawing.Point(111, 204);
			this.txtSemana.Name = "txtSemana";
			this.txtSemana.ReadOnly = true;
			this.txtSemana.Size = new System.Drawing.Size(324, 20);
			this.txtSemana.TabIndex = 15;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(698, 243);
			this.Controls.Add(this.txtSemana);
			this.Controls.Add(this.txtAno);
			this.Controls.Add(this.txtMes);
			this.Controls.Add(this.txtDia);
			this.Controls.Add(this.lblSemana);
			this.Controls.Add(this.lblAno);
			this.Controls.Add(this.lblMes);
			this.Controls.Add(this.lblDia);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtData);
			this.Controls.Add(this.txtHora);
			this.Controls.Add(this.btn_Sair);
			this.Controls.Add(this.btn_Reset);
			this.Controls.Add(this.txt_Data);
			this.Controls.Add(this.btn_Exibir);
			this.Name = "Form1";
			this.Text = "Data Hora";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Exibir;
		private System.Windows.Forms.TextBox txt_Data;
		private System.Windows.Forms.Button btn_Reset;
		private System.Windows.Forms.Button btn_Sair;
		private System.Windows.Forms.TextBox txtHora;
		private System.Windows.Forms.TextBox txtData;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblDia;
		private System.Windows.Forms.Label lblMes;
		private System.Windows.Forms.Label lblAno;
		private System.Windows.Forms.Label lblSemana;
		private System.Windows.Forms.TextBox txtDia;
		private System.Windows.Forms.TextBox txtMes;
		private System.Windows.Forms.TextBox txtAno;
		private System.Windows.Forms.TextBox txtSemana;
	}
}

