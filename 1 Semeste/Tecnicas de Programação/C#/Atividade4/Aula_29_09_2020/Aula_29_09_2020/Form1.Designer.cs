namespace Aula_29_09_2020
{
	partial class frmVeiculos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeiculos));
			this.radCarros = new System.Windows.Forms.RadioButton();
			this.radMotos = new System.Windows.Forms.RadioButton();
			this.picBugatti = new System.Windows.Forms.PictureBox();
			this.radBugatti = new System.Windows.Forms.RadioButton();
			this.radAston = new System.Windows.Forms.RadioButton();
			this.picAston = new System.Windows.Forms.PictureBox();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.picDucati = new System.Windows.Forms.PictureBox();
			this.radHarley = new System.Windows.Forms.RadioButton();
			this.picHarley = new System.Windows.Forms.PictureBox();
			this.radDucati = new System.Windows.Forms.RadioButton();
			this.lblMensagem = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picBugatti)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picAston)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDucati)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picHarley)).BeginInit();
			this.SuspendLayout();
			// 
			// radCarros
			// 
			this.radCarros.AutoSize = true;
			this.radCarros.Location = new System.Drawing.Point(74, 19);
			this.radCarros.Name = "radCarros";
			this.radCarros.Size = new System.Drawing.Size(55, 17);
			this.radCarros.TabIndex = 3;
			this.radCarros.TabStop = true;
			this.radCarros.Text = "Carros";
			this.radCarros.UseVisualStyleBackColor = true;
			this.radCarros.CheckedChanged += new System.EventHandler(this.radCarros_CheckedChanged);
			// 
			// radMotos
			// 
			this.radMotos.AutoSize = true;
			this.radMotos.Location = new System.Drawing.Point(386, 19);
			this.radMotos.Name = "radMotos";
			this.radMotos.Size = new System.Drawing.Size(54, 17);
			this.radMotos.TabIndex = 4;
			this.radMotos.TabStop = true;
			this.radMotos.Text = "Motos";
			this.radMotos.UseVisualStyleBackColor = true;
			this.radMotos.CheckedChanged += new System.EventHandler(this.radMotos_CheckedChanged);
			// 
			// picBugatti
			// 
			this.picBugatti.Image = ((System.Drawing.Image)(resources.GetObject("picBugatti.Image")));
			this.picBugatti.Location = new System.Drawing.Point(12, 42);
			this.picBugatti.Name = "picBugatti";
			this.picBugatti.Size = new System.Drawing.Size(181, 118);
			this.picBugatti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBugatti.TabIndex = 2;
			this.picBugatti.TabStop = false;
			this.picBugatti.Visible = false;
			// 
			// radBugatti
			// 
			this.radBugatti.AutoSize = true;
			this.radBugatti.Location = new System.Drawing.Point(199, 88);
			this.radBugatti.Name = "radBugatti";
			this.radBugatti.Size = new System.Drawing.Size(58, 17);
			this.radBugatti.TabIndex = 3;
			this.radBugatti.TabStop = true;
			this.radBugatti.Text = "Bugatti";
			this.radBugatti.UseVisualStyleBackColor = true;
			this.radBugatti.Visible = false;
			this.radBugatti.CheckedChanged += new System.EventHandler(this.radBugatti_CheckedChanged);
			// 
			// radAston
			// 
			this.radAston.AutoSize = true;
			this.radAston.Location = new System.Drawing.Point(199, 238);
			this.radAston.Name = "radAston";
			this.radAston.Size = new System.Drawing.Size(84, 17);
			this.radAston.TabIndex = 5;
			this.radAston.TabStop = true;
			this.radAston.Text = "Aston Martin";
			this.radAston.UseVisualStyleBackColor = true;
			this.radAston.Visible = false;
			this.radAston.CheckedChanged += new System.EventHandler(this.radAston_CheckedChanged);
			// 
			// picAston
			// 
			this.picAston.Image = ((System.Drawing.Image)(resources.GetObject("picAston.Image")));
			this.picAston.Location = new System.Drawing.Point(12, 187);
			this.picAston.Name = "picAston";
			this.picAston.Size = new System.Drawing.Size(181, 117);
			this.picAston.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picAston.TabIndex = 4;
			this.picAston.TabStop = false;
			this.picAston.Visible = false;
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(189, 343);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpar.TabIndex = 0;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(308, 343);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 23);
			this.btnSair.TabIndex = 1;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// picDucati
			// 
			this.picDucati.Image = ((System.Drawing.Image)(resources.GetObject("picDucati.Image")));
			this.picDucati.Location = new System.Drawing.Point(317, 187);
			this.picDucati.Name = "picDucati";
			this.picDucati.Size = new System.Drawing.Size(188, 117);
			this.picDucati.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picDucati.TabIndex = 12;
			this.picDucati.TabStop = false;
			this.picDucati.Visible = false;
			// 
			// radHarley
			// 
			this.radHarley.AutoSize = true;
			this.radHarley.Location = new System.Drawing.Point(511, 88);
			this.radHarley.Name = "radHarley";
			this.radHarley.Size = new System.Drawing.Size(103, 17);
			this.radHarley.TabIndex = 11;
			this.radHarley.TabStop = true;
			this.radHarley.Text = "Harley Devidson";
			this.radHarley.UseVisualStyleBackColor = true;
			this.radHarley.Visible = false;
			this.radHarley.CheckedChanged += new System.EventHandler(this.radHarley_CheckedChanged);
			// 
			// picHarley
			// 
			this.picHarley.Image = ((System.Drawing.Image)(resources.GetObject("picHarley.Image")));
			this.picHarley.Location = new System.Drawing.Point(317, 42);
			this.picHarley.Name = "picHarley";
			this.picHarley.Size = new System.Drawing.Size(188, 118);
			this.picHarley.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picHarley.TabIndex = 10;
			this.picHarley.TabStop = false;
			this.picHarley.Visible = false;
			// 
			// radDucati
			// 
			this.radDucati.AutoSize = true;
			this.radDucati.Location = new System.Drawing.Point(511, 238);
			this.radDucati.Name = "radDucati";
			this.radDucati.Size = new System.Drawing.Size(56, 17);
			this.radDucati.TabIndex = 13;
			this.radDucati.TabStop = true;
			this.radDucati.Text = "Ducati";
			this.radDucati.UseVisualStyleBackColor = true;
			this.radDucati.Visible = false;
			this.radDucati.CheckedChanged += new System.EventHandler(this.radDucati_CheckedChanged);
			// 
			// lblMensagem
			// 
			this.lblMensagem.AutoSize = true;
			this.lblMensagem.Location = new System.Drawing.Point(33, 320);
			this.lblMensagem.Name = "lblMensagem";
			this.lblMensagem.Size = new System.Drawing.Size(117, 13);
			this.lblMensagem.TabIndex = 14;
			this.lblMensagem.Text = "O seu veiculo é: ?????";
			this.lblMensagem.Visible = false;
			// 
			// frmVeiculos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 389);
			this.Controls.Add(this.lblMensagem);
			this.Controls.Add(this.radDucati);
			this.Controls.Add(this.picDucati);
			this.Controls.Add(this.radHarley);
			this.Controls.Add(this.picHarley);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.radAston);
			this.Controls.Add(this.picAston);
			this.Controls.Add(this.radBugatti);
			this.Controls.Add(this.picBugatti);
			this.Controls.Add(this.radMotos);
			this.Controls.Add(this.radCarros);
			this.Name = "frmVeiculos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Veículos";
			((System.ComponentModel.ISupportInitialize)(this.picBugatti)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picAston)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDucati)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picHarley)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton radCarros;
		private System.Windows.Forms.RadioButton radMotos;
		private System.Windows.Forms.PictureBox picBugatti;
		private System.Windows.Forms.RadioButton radBugatti;
		private System.Windows.Forms.RadioButton radAston;
		private System.Windows.Forms.PictureBox picAston;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.PictureBox picDucati;
		private System.Windows.Forms.RadioButton radHarley;
		private System.Windows.Forms.PictureBox picHarley;
		private System.Windows.Forms.RadioButton radDucati;
		private System.Windows.Forms.Label lblMensagem;
	}
}

