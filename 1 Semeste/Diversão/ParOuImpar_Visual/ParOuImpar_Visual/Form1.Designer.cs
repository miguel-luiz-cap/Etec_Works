namespace ParOuImpar_Visual
{
	partial class frm_ParImpar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ParImpar));
			this.rad_Par = new System.Windows.Forms.RadioButton();
			this.rad_Impar = new System.Windows.Forms.RadioButton();
			this.lbl_ParImpar = new System.Windows.Forms.Label();
			this.num_User = new System.Windows.Forms.NumericUpDown();
			this.lbl_DigiteNumero = new System.Windows.Forms.Label();
			this.lbl_Title = new System.Windows.Forms.Label();
			this.lbl_Resultado = new System.Windows.Forms.Label();
			this.lbl_Placar = new System.Windows.Forms.Label();
			this.btn_Jogar = new System.Windows.Forms.Button();
			this.btn_Limpar = new System.Windows.Forms.Button();
			this.btn_Sair = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.num_User)).BeginInit();
			this.SuspendLayout();
			// 
			// rad_Par
			// 
			this.rad_Par.AutoSize = true;
			this.rad_Par.Checked = true;
			this.rad_Par.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rad_Par.ForeColor = System.Drawing.SystemColors.Control;
			this.rad_Par.Location = new System.Drawing.Point(90, 133);
			this.rad_Par.Name = "rad_Par";
			this.rad_Par.Size = new System.Drawing.Size(50, 24);
			this.rad_Par.TabIndex = 0;
			this.rad_Par.TabStop = true;
			this.rad_Par.Text = "Par";
			this.rad_Par.UseVisualStyleBackColor = true;
			// 
			// rad_Impar
			// 
			this.rad_Impar.AutoSize = true;
			this.rad_Impar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rad_Impar.ForeColor = System.Drawing.SystemColors.Control;
			this.rad_Impar.Location = new System.Drawing.Point(147, 133);
			this.rad_Impar.Name = "rad_Impar";
			this.rad_Impar.Size = new System.Drawing.Size(69, 24);
			this.rad_Impar.TabIndex = 0;
			this.rad_Impar.Text = "Impar";
			this.rad_Impar.UseVisualStyleBackColor = true;
			// 
			// lbl_ParImpar
			// 
			this.lbl_ParImpar.AutoSize = true;
			this.lbl_ParImpar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_ParImpar.ForeColor = System.Drawing.SystemColors.Control;
			this.lbl_ParImpar.Location = new System.Drawing.Point(19, 135);
			this.lbl_ParImpar.Name = "lbl_ParImpar";
			this.lbl_ParImpar.Size = new System.Drawing.Size(65, 20);
			this.lbl_ParImpar.TabIndex = 1;
			this.lbl_ParImpar.Text = "Escolha:";
			// 
			// num_User
			// 
			this.num_User.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.num_User.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.num_User.ForeColor = System.Drawing.SystemColors.Control;
			this.num_User.Location = new System.Drawing.Point(159, 163);
			this.num_User.Name = "num_User";
			this.num_User.Size = new System.Drawing.Size(45, 28);
			this.num_User.TabIndex = 2;
			// 
			// lbl_DigiteNumero
			// 
			this.lbl_DigiteNumero.AutoSize = true;
			this.lbl_DigiteNumero.BackColor = System.Drawing.Color.Transparent;
			this.lbl_DigiteNumero.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_DigiteNumero.ForeColor = System.Drawing.SystemColors.Control;
			this.lbl_DigiteNumero.Location = new System.Drawing.Point(7, 167);
			this.lbl_DigiteNumero.Name = "lbl_DigiteNumero";
			this.lbl_DigiteNumero.Size = new System.Drawing.Size(146, 20);
			this.lbl_DigiteNumero.TabIndex = 3;
			this.lbl_DigiteNumero.Text = "Escolha um Número:";
			// 
			// lbl_Title
			// 
			this.lbl_Title.AutoSize = true;
			this.lbl_Title.Font = new System.Drawing.Font("Pricedown Bl", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.lbl_Title.ForeColor = System.Drawing.SystemColors.Control;
			this.lbl_Title.Location = new System.Drawing.Point(25, 0);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(342, 67);
			this.lbl_Title.TabIndex = 4;
			this.lbl_Title.Text = "PAR OU IMPAR";
			// 
			// lbl_Resultado
			// 
			this.lbl_Resultado.AutoSize = true;
			this.lbl_Resultado.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Resultado.ForeColor = System.Drawing.SystemColors.Control;
			this.lbl_Resultado.Location = new System.Drawing.Point(63, 213);
			this.lbl_Resultado.Name = "lbl_Resultado";
			this.lbl_Resultado.Size = new System.Drawing.Size(250, 190);
			this.lbl_Resultado.TabIndex = 5;
			this.lbl_Resultado.Text = "Você: X\r\nMáquina: X\r\nResultado: X (X)\r\n\r\nVOCÊ GANHOU !!\r\n";
			this.lbl_Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_Resultado.Visible = false;
			// 
			// lbl_Placar
			// 
			this.lbl_Placar.AutoSize = true;
			this.lbl_Placar.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Placar.ForeColor = System.Drawing.SystemColors.Control;
			this.lbl_Placar.Location = new System.Drawing.Point(65, 80);
			this.lbl_Placar.Name = "lbl_Placar";
			this.lbl_Placar.Size = new System.Drawing.Size(261, 30);
			this.lbl_Placar.TabIndex = 7;
			this.lbl_Placar.Text = "[Você] 0 X 0 [Máquina] ";
			// 
			// btn_Jogar
			// 
			this.btn_Jogar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_Jogar.Font = new System.Drawing.Font("WLM Carton", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Jogar.ForeColor = System.Drawing.SystemColors.Control;
			this.btn_Jogar.Location = new System.Drawing.Point(222, 138);
			this.btn_Jogar.Name = "btn_Jogar";
			this.btn_Jogar.Size = new System.Drawing.Size(150, 55);
			this.btn_Jogar.TabIndex = 8;
			this.btn_Jogar.Text = "Jogar";
			this.btn_Jogar.UseVisualStyleBackColor = false;
			this.btn_Jogar.Click += new System.EventHandler(this.btn_Jogar_Click);
			// 
			// btn_Limpar
			// 
			this.btn_Limpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_Limpar.Font = new System.Drawing.Font("WLM Carton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Limpar.ForeColor = System.Drawing.SystemColors.Control;
			this.btn_Limpar.Location = new System.Drawing.Point(60, 429);
			this.btn_Limpar.Name = "btn_Limpar";
			this.btn_Limpar.Size = new System.Drawing.Size(110, 45);
			this.btn_Limpar.TabIndex = 9;
			this.btn_Limpar.Text = "Jogar Novamente";
			this.btn_Limpar.UseVisualStyleBackColor = false;
			this.btn_Limpar.Visible = false;
			this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
			// 
			// btn_Sair
			// 
			this.btn_Sair.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_Sair.Font = new System.Drawing.Font("WLM Carton", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Sair.ForeColor = System.Drawing.SystemColors.Control;
			this.btn_Sair.Location = new System.Drawing.Point(222, 429);
			this.btn_Sair.Name = "btn_Sair";
			this.btn_Sair.Size = new System.Drawing.Size(110, 45);
			this.btn_Sair.TabIndex = 9;
			this.btn_Sair.Text = "Sair";
			this.btn_Sair.UseVisualStyleBackColor = false;
			this.btn_Sair.Visible = false;
			this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("WLM Carton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(24, 490);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(348, 12);
			this.label1.TabIndex = 10;
			this.label1.Text = "Programa desnvolvido por: Miguel Luiz Capristano";
			// 
			// frm_ParImpar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(384, 511);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Sair);
			this.Controls.Add(this.btn_Limpar);
			this.Controls.Add(this.btn_Jogar);
			this.Controls.Add(this.lbl_Placar);
			this.Controls.Add(this.lbl_Resultado);
			this.Controls.Add(this.lbl_Title);
			this.Controls.Add(this.lbl_DigiteNumero);
			this.Controls.Add(this.num_User);
			this.Controls.Add(this.lbl_ParImpar);
			this.Controls.Add(this.rad_Impar);
			this.Controls.Add(this.rad_Par);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(400, 550);
			this.MinimumSize = new System.Drawing.Size(400, 550);
			this.Name = "frm_ParImpar";
			this.Text = "Par ou Impar";
			((System.ComponentModel.ISupportInitialize)(this.num_User)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton rad_Par;
		private System.Windows.Forms.RadioButton rad_Impar;
		private System.Windows.Forms.Label lbl_ParImpar;
		private System.Windows.Forms.NumericUpDown num_User;
		private System.Windows.Forms.Label lbl_DigiteNumero;
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.Label lbl_Resultado;
		private System.Windows.Forms.Label lbl_Placar;
		private System.Windows.Forms.Button btn_Jogar;
		private System.Windows.Forms.Button btn_Limpar;
		private System.Windows.Forms.Button btn_Sair;
		private System.Windows.Forms.Label label1;
	}
}

