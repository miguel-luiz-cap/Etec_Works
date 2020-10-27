namespace Visual_Exemplo2
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
			this.components = new System.ComponentModel.Container();
			this.lbl_DataNasc = new System.Windows.Forms.Label();
			this.lbl_Data = new System.Windows.Forms.Label();
			this.btn_Exibir = new System.Windows.Forms.Button();
			this.btn_Apagar = new System.Windows.Forms.Button();
			this.btn_Sair = new System.Windows.Forms.Button();
			this.lbl_Dia = new System.Windows.Forms.Label();
			this.lbl_Idade = new System.Windows.Forms.Label();
			this.txt_Dia = new System.Windows.Forms.TextBox();
			this.txt_Idade = new System.Windows.Forms.TextBox();
			this.txt_DataNasc = new System.Windows.Forms.MaskedTextBox();
			this.txt_Data = new System.Windows.Forms.MaskedTextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.status_label = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_DataNasc
			// 
			this.lbl_DataNasc.AutoSize = true;
			this.lbl_DataNasc.Location = new System.Drawing.Point(40, 36);
			this.lbl_DataNasc.Name = "lbl_DataNasc";
			this.lbl_DataNasc.Size = new System.Drawing.Size(107, 13);
			this.lbl_DataNasc.TabIndex = 0;
			this.lbl_DataNasc.Text = "Data de Nascimento:";
			// 
			// lbl_Data
			// 
			this.lbl_Data.AutoSize = true;
			this.lbl_Data.Location = new System.Drawing.Point(43, 74);
			this.lbl_Data.Name = "lbl_Data";
			this.lbl_Data.Size = new System.Drawing.Size(60, 13);
			this.lbl_Data.TabIndex = 3;
			this.lbl_Data.Text = "Data Atual:";
			// 
			// btn_Exibir
			// 
			this.btn_Exibir.Location = new System.Drawing.Point(153, 120);
			this.btn_Exibir.Name = "btn_Exibir";
			this.btn_Exibir.Size = new System.Drawing.Size(75, 23);
			this.btn_Exibir.TabIndex = 4;
			this.btn_Exibir.Text = "Exibir";
			this.btn_Exibir.UseVisualStyleBackColor = true;
			this.btn_Exibir.Click += new System.EventHandler(this.btn_Exibir_Click);
			// 
			// btn_Apagar
			// 
			this.btn_Apagar.Location = new System.Drawing.Point(281, 120);
			this.btn_Apagar.Name = "btn_Apagar";
			this.btn_Apagar.Size = new System.Drawing.Size(75, 23);
			this.btn_Apagar.TabIndex = 5;
			this.btn_Apagar.Text = "Apagar";
			this.btn_Apagar.UseVisualStyleBackColor = true;
			this.btn_Apagar.Click += new System.EventHandler(this.button2_Click);
			// 
			// btn_Sair
			// 
			this.btn_Sair.Location = new System.Drawing.Point(408, 120);
			this.btn_Sair.Name = "btn_Sair";
			this.btn_Sair.Size = new System.Drawing.Size(75, 23);
			this.btn_Sair.TabIndex = 5;
			this.btn_Sair.Text = "Fechar";
			this.btn_Sair.UseVisualStyleBackColor = true;
			this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
			// 
			// lbl_Dia
			// 
			this.lbl_Dia.AutoSize = true;
			this.lbl_Dia.Location = new System.Drawing.Point(54, 173);
			this.lbl_Dia.Name = "lbl_Dia";
			this.lbl_Dia.Size = new System.Drawing.Size(26, 13);
			this.lbl_Dia.TabIndex = 6;
			this.lbl_Dia.Text = "Dia:";
			// 
			// lbl_Idade
			// 
			this.lbl_Idade.AutoSize = true;
			this.lbl_Idade.Location = new System.Drawing.Point(43, 200);
			this.lbl_Idade.Name = "lbl_Idade";
			this.lbl_Idade.Size = new System.Drawing.Size(37, 13);
			this.lbl_Idade.TabIndex = 7;
			this.lbl_Idade.Text = "Idade:";
			// 
			// txt_Dia
			// 
			this.txt_Dia.Location = new System.Drawing.Point(86, 170);
			this.txt_Dia.Name = "txt_Dia";
			this.txt_Dia.ReadOnly = true;
			this.txt_Dia.Size = new System.Drawing.Size(100, 20);
			this.txt_Dia.TabIndex = 8;
			// 
			// txt_Idade
			// 
			this.txt_Idade.Location = new System.Drawing.Point(86, 197);
			this.txt_Idade.Name = "txt_Idade";
			this.txt_Idade.ReadOnly = true;
			this.txt_Idade.Size = new System.Drawing.Size(100, 20);
			this.txt_Idade.TabIndex = 8;
			// 
			// txt_DataNasc
			// 
			this.txt_DataNasc.Location = new System.Drawing.Point(153, 29);
			this.txt_DataNasc.Mask = "00/00/0000";
			this.txt_DataNasc.Name = "txt_DataNasc";
			this.txt_DataNasc.Size = new System.Drawing.Size(330, 20);
			this.txt_DataNasc.TabIndex = 9;
			this.txt_DataNasc.ValidatingType = typeof(System.DateTime);
			// 
			// txt_Data
			// 
			this.txt_Data.Location = new System.Drawing.Point(153, 71);
			this.txt_Data.Mask = "00/00/0000";
			this.txt_Data.Name = "txt_Data";
			this.txt_Data.ReadOnly = true;
			this.txt_Data.Size = new System.Drawing.Size(330, 20);
			this.txt_Data.TabIndex = 9;
			this.txt_Data.ValidatingType = typeof(System.DateTime);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_label});
			this.statusStrip1.Location = new System.Drawing.Point(0, 235);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(549, 35);
			this.statusStrip1.TabIndex = 10;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// status_label
			// 
			this.status_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.status_label.Name = "status_label";
			this.status_label.Size = new System.Drawing.Size(223, 30);
			this.status_label.Text = "toolStripStatusLabel1";
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(549, 270);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.txt_Data);
			this.Controls.Add(this.txt_DataNasc);
			this.Controls.Add(this.txt_Idade);
			this.Controls.Add(this.txt_Dia);
			this.Controls.Add(this.lbl_Idade);
			this.Controls.Add(this.lbl_Dia);
			this.Controls.Add(this.btn_Sair);
			this.Controls.Add(this.btn_Apagar);
			this.Controls.Add(this.btn_Exibir);
			this.Controls.Add(this.lbl_Data);
			this.Controls.Add(this.lbl_DataNasc);
			this.Name = "Form1";
			this.Text = "Form1";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_DataNasc;
		private System.Windows.Forms.Label lbl_Data;
		private System.Windows.Forms.Button btn_Exibir;
		private System.Windows.Forms.Button btn_Apagar;
		private System.Windows.Forms.Button btn_Sair;
		private System.Windows.Forms.Label lbl_Dia;
		private System.Windows.Forms.Label lbl_Idade;
		private System.Windows.Forms.TextBox txt_Dia;
		private System.Windows.Forms.TextBox txt_Idade;
		private System.Windows.Forms.MaskedTextBox txt_DataNasc;
		private System.Windows.Forms.MaskedTextBox txt_Data;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel status_label;
		private System.Windows.Forms.Timer timer;
	}
}

