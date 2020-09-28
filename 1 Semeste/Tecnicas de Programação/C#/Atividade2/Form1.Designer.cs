namespace Aula_TP_22_09_2020
{
	partial class frmFeira
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
			this.lblFrutas = new System.Windows.Forms.Label();
			this.lblIncluirFruta = new System.Windows.Forms.Label();
			this.lblListaFrutas = new System.Windows.Forms.Label();
			this.btnAddFruta = new System.Windows.Forms.Button();
			this.btnRemFruta = new System.Windows.Forms.Button();
			this.lstFrutas = new System.Windows.Forms.ListBox();
			this.txtFruta = new System.Windows.Forms.TextBox();
			this.txtPastel = new System.Windows.Forms.TextBox();
			this.lstPastel = new System.Windows.Forms.ListBox();
			this.btnRemPastel = new System.Windows.Forms.Button();
			this.btnAddPastel = new System.Windows.Forms.Button();
			this.lblListaPastel = new System.Windows.Forms.Label();
			this.lblIncluirPastel = new System.Windows.Forms.Label();
			this.lblPastel = new System.Windows.Forms.Label();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblFrutas
			// 
			this.lblFrutas.AutoSize = true;
			this.lblFrutas.Location = new System.Drawing.Point(58, 13);
			this.lblFrutas.Name = "lblFrutas";
			this.lblFrutas.Size = new System.Drawing.Size(96, 13);
			this.lblFrutas.TabIndex = 0;
			this.lblFrutas.Text = "Barraca das Frutas";
			// 
			// lblIncluirFruta
			// 
			this.lblIncluirFruta.AutoSize = true;
			this.lblIncluirFruta.Location = new System.Drawing.Point(25, 38);
			this.lblIncluirFruta.Name = "lblIncluirFruta";
			this.lblIncluirFruta.Size = new System.Drawing.Size(62, 13);
			this.lblIncluirFruta.TabIndex = 1;
			this.lblIncluirFruta.Text = "Incluir Fruta";
			// 
			// lblListaFrutas
			// 
			this.lblListaFrutas.AutoSize = true;
			this.lblListaFrutas.Location = new System.Drawing.Point(130, 38);
			this.lblListaFrutas.Name = "lblListaFrutas";
			this.lblListaFrutas.Size = new System.Drawing.Size(76, 13);
			this.lblListaFrutas.TabIndex = 2;
			this.lblListaFrutas.Text = "Lista de Frutas";
			// 
			// btnAddFruta
			// 
			this.btnAddFruta.Location = new System.Drawing.Point(12, 97);
			this.btnAddFruta.Name = "btnAddFruta";
			this.btnAddFruta.Size = new System.Drawing.Size(90, 23);
			this.btnAddFruta.TabIndex = 3;
			this.btnAddFruta.Text = "Adicionar Fruta";
			this.btnAddFruta.UseVisualStyleBackColor = true;
			this.btnAddFruta.Click += new System.EventHandler(this.btnAddFruta_Click);
			// 
			// btnRemFruta
			// 
			this.btnRemFruta.Location = new System.Drawing.Point(12, 126);
			this.btnRemFruta.Name = "btnRemFruta";
			this.btnRemFruta.Size = new System.Drawing.Size(90, 23);
			this.btnRemFruta.TabIndex = 4;
			this.btnRemFruta.Text = "Remover Fruta";
			this.btnRemFruta.UseVisualStyleBackColor = true;
			this.btnRemFruta.Click += new System.EventHandler(this.btnRemFruta_Click);
			// 
			// lstFrutas
			// 
			this.lstFrutas.FormattingEnabled = true;
			this.lstFrutas.Location = new System.Drawing.Point(108, 54);
			this.lstFrutas.Name = "lstFrutas";
			this.lstFrutas.Size = new System.Drawing.Size(120, 95);
			this.lstFrutas.TabIndex = 5;
			// 
			// txtFruta
			// 
			this.txtFruta.Location = new System.Drawing.Point(12, 53);
			this.txtFruta.Name = "txtFruta";
			this.txtFruta.Size = new System.Drawing.Size(90, 20);
			this.txtFruta.TabIndex = 0;
			this.txtFruta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtPastel
			// 
			this.txtPastel.Location = new System.Drawing.Point(261, 53);
			this.txtPastel.Name = "txtPastel";
			this.txtPastel.Size = new System.Drawing.Size(98, 20);
			this.txtPastel.TabIndex = 13;
			this.txtPastel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lstPastel
			// 
			this.lstPastel.FormattingEnabled = true;
			this.lstPastel.Location = new System.Drawing.Point(365, 54);
			this.lstPastel.Name = "lstPastel";
			this.lstPastel.Size = new System.Drawing.Size(120, 95);
			this.lstPastel.TabIndex = 12;
			// 
			// btnRemPastel
			// 
			this.btnRemPastel.Location = new System.Drawing.Point(261, 126);
			this.btnRemPastel.Name = "btnRemPastel";
			this.btnRemPastel.Size = new System.Drawing.Size(98, 23);
			this.btnRemPastel.TabIndex = 11;
			this.btnRemPastel.Text = "Remover Pastel";
			this.btnRemPastel.UseVisualStyleBackColor = true;
			this.btnRemPastel.Click += new System.EventHandler(this.btnRemPastel_Click);
			// 
			// btnAddPastel
			// 
			this.btnAddPastel.Location = new System.Drawing.Point(261, 97);
			this.btnAddPastel.Name = "btnAddPastel";
			this.btnAddPastel.Size = new System.Drawing.Size(98, 23);
			this.btnAddPastel.TabIndex = 10;
			this.btnAddPastel.Text = "Adicionar Pastel";
			this.btnAddPastel.UseVisualStyleBackColor = true;
			this.btnAddPastel.Click += new System.EventHandler(this.btnAddPastel_Click);
			// 
			// lblListaPastel
			// 
			this.lblListaPastel.AutoSize = true;
			this.lblListaPastel.Location = new System.Drawing.Point(378, 38);
			this.lblListaPastel.Name = "lblListaPastel";
			this.lblListaPastel.Size = new System.Drawing.Size(86, 13);
			this.lblListaPastel.TabIndex = 9;
			this.lblListaPastel.Text = "Lista dos Pasteis";
			// 
			// lblIncluirPastel
			// 
			this.lblIncluirPastel.AutoSize = true;
			this.lblIncluirPastel.Location = new System.Drawing.Point(276, 38);
			this.lblIncluirPastel.Name = "lblIncluirPastel";
			this.lblIncluirPastel.Size = new System.Drawing.Size(67, 13);
			this.lblIncluirPastel.TabIndex = 8;
			this.lblIncluirPastel.Text = "Incluir Pastel";
			// 
			// lblPastel
			// 
			this.lblPastel.AutoSize = true;
			this.lblPastel.Location = new System.Drawing.Point(315, 13);
			this.lblPastel.Name = "lblPastel";
			this.lblPastel.Size = new System.Drawing.Size(91, 13);
			this.lblPastel.TabIndex = 7;
			this.lblPastel.Text = "Barraca do Pastel";
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(146, 169);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(82, 23);
			this.btnExcluir.TabIndex = 14;
			this.btnExcluir.Text = "Excluir TUDO";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(249, 169);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 23);
			this.btnSair.TabIndex = 15;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// frmFeira
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(499, 204);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.txtPastel);
			this.Controls.Add(this.lstPastel);
			this.Controls.Add(this.btnRemPastel);
			this.Controls.Add(this.btnAddPastel);
			this.Controls.Add(this.lblListaPastel);
			this.Controls.Add(this.lblIncluirPastel);
			this.Controls.Add(this.lblPastel);
			this.Controls.Add(this.txtFruta);
			this.Controls.Add(this.lstFrutas);
			this.Controls.Add(this.btnRemFruta);
			this.Controls.Add(this.btnAddFruta);
			this.Controls.Add(this.lblListaFrutas);
			this.Controls.Add(this.lblIncluirFruta);
			this.Controls.Add(this.lblFrutas);
			this.Name = "frmFeira";
			this.Text = "Lista de compras da feira";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFrutas;
		private System.Windows.Forms.Label lblIncluirFruta;
		private System.Windows.Forms.Label lblListaFrutas;
		private System.Windows.Forms.Button btnAddFruta;
		private System.Windows.Forms.Button btnRemFruta;
		private System.Windows.Forms.ListBox lstFrutas;
		private System.Windows.Forms.TextBox txtFruta;
		private System.Windows.Forms.TextBox txtPastel;
		private System.Windows.Forms.ListBox lstPastel;
		private System.Windows.Forms.Button btnRemPastel;
		private System.Windows.Forms.Button btnAddPastel;
		private System.Windows.Forms.Label lblListaPastel;
		private System.Windows.Forms.Label lblIncluirPastel;
		private System.Windows.Forms.Label lblPastel;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnSair;
	}
}

