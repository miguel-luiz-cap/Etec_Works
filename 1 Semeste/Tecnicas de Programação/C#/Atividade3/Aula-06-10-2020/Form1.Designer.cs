namespace Aula_06_10_2020
{
	partial class frmCompras
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
			this.txtProduto = new System.Windows.Forms.TextBox();
			this.txtVtotal = new System.Windows.Forms.TextBox();
			this.nudQTD = new System.Windows.Forms.NumericUpDown();
			this.lblProduto = new System.Windows.Forms.Label();
			this.lblQTD = new System.Windows.Forms.Label();
			this.lblVTotal = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblForma = new System.Windows.Forms.Label();
			this.radVista = new System.Windows.Forms.RadioButton();
			this.radParcelado = new System.Windows.Forms.RadioButton();
			this.txtFinal = new System.Windows.Forms.TextBox();
			this.lblMsg = new System.Windows.Forms.Label();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudQTD)).BeginInit();
			this.SuspendLayout();
			// 
			// txtProduto
			// 
			this.txtProduto.Location = new System.Drawing.Point(182, 19);
			this.txtProduto.Name = "txtProduto";
			this.txtProduto.Size = new System.Drawing.Size(76, 20);
			this.txtProduto.TabIndex = 0;
			this.txtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduto_KeyPress);
			// 
			// txtVtotal
			// 
			this.txtVtotal.Enabled = false;
			this.txtVtotal.Location = new System.Drawing.Point(182, 78);
			this.txtVtotal.Name = "txtVtotal";
			this.txtVtotal.Size = new System.Drawing.Size(76, 20);
			this.txtVtotal.TabIndex = 1;
			this.txtVtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nudQTD
			// 
			this.nudQTD.Location = new System.Drawing.Point(182, 49);
			this.nudQTD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudQTD.Name = "nudQTD";
			this.nudQTD.Size = new System.Drawing.Size(76, 20);
			this.nudQTD.TabIndex = 2;
			this.nudQTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudQTD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lblProduto
			// 
			this.lblProduto.AutoSize = true;
			this.lblProduto.Location = new System.Drawing.Point(22, 22);
			this.lblProduto.Name = "lblProduto";
			this.lblProduto.Size = new System.Drawing.Size(154, 13);
			this.lblProduto.TabIndex = 3;
			this.lblProduto.Text = "Informe o valor do produto (R$)";
			// 
			// lblQTD
			// 
			this.lblQTD.AutoSize = true;
			this.lblQTD.Location = new System.Drawing.Point(72, 51);
			this.lblQTD.Name = "lblQTD";
			this.lblQTD.Size = new System.Drawing.Size(104, 13);
			this.lblQTD.TabIndex = 4;
			this.lblQTD.Text = "Infome a quantidade";
			// 
			// lblVTotal
			// 
			this.lblVTotal.AutoSize = true;
			this.lblVTotal.Location = new System.Drawing.Point(99, 81);
			this.lblVTotal.Name = "lblVTotal";
			this.lblVTotal.Size = new System.Drawing.Size(77, 13);
			this.lblVTotal.TabIndex = 5;
			this.lblVTotal.Text = "Valor total (R$)";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(12, 76);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 6;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// lblForma
			// 
			this.lblForma.AutoSize = true;
			this.lblForma.Location = new System.Drawing.Point(88, 127);
			this.lblForma.Name = "lblForma";
			this.lblForma.Size = new System.Drawing.Size(107, 13);
			this.lblForma.TabIndex = 7;
			this.lblForma.Text = "Forma de pagamento";
			this.lblForma.Visible = false;
			// 
			// radVista
			// 
			this.radVista.AutoSize = true;
			this.radVista.Location = new System.Drawing.Point(39, 155);
			this.radVista.Name = "radVista";
			this.radVista.Size = new System.Drawing.Size(58, 17);
			this.radVista.TabIndex = 8;
			this.radVista.TabStop = true;
			this.radVista.Text = "A Vista";
			this.radVista.UseVisualStyleBackColor = true;
			this.radVista.Visible = false;
			this.radVista.CheckedChanged += new System.EventHandler(this.radVista_CheckedChanged);
			// 
			// radParcelado
			// 
			this.radParcelado.AutoSize = true;
			this.radParcelado.Location = new System.Drawing.Point(141, 155);
			this.radParcelado.Name = "radParcelado";
			this.radParcelado.Size = new System.Drawing.Size(130, 17);
			this.radParcelado.TabIndex = 9;
			this.radParcelado.TabStop = true;
			this.radParcelado.Text = "Parcelado em 3 vezes";
			this.radParcelado.UseVisualStyleBackColor = true;
			this.radParcelado.Visible = false;
			this.radParcelado.CheckedChanged += new System.EventHandler(this.radParcelado_CheckedChanged);
			// 
			// txtFinal
			// 
			this.txtFinal.Location = new System.Drawing.Point(162, 203);
			this.txtFinal.Name = "txtFinal";
			this.txtFinal.ReadOnly = true;
			this.txtFinal.Size = new System.Drawing.Size(100, 20);
			this.txtFinal.TabIndex = 10;
			this.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtFinal.Visible = false;
			// 
			// lblMsg
			// 
			this.lblMsg.AutoSize = true;
			this.lblMsg.Location = new System.Drawing.Point(12, 206);
			this.lblMsg.Name = "lblMsg";
			this.lblMsg.Size = new System.Drawing.Size(76, 13);
			this.lblMsg.TabIndex = 11;
			this.lblMsg.Text = "VALOR FINAL";
			this.lblMsg.Visible = false;
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(55, 248);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpar.TabIndex = 12;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(154, 248);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 23);
			this.btnSair.TabIndex = 13;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.button3_Click);
			// 
			// frmCompras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 282);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.lblMsg);
			this.Controls.Add(this.txtFinal);
			this.Controls.Add(this.radParcelado);
			this.Controls.Add(this.radVista);
			this.Controls.Add(this.lblForma);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblVTotal);
			this.Controls.Add(this.lblQTD);
			this.Controls.Add(this.lblProduto);
			this.Controls.Add(this.nudQTD);
			this.Controls.Add(this.txtVtotal);
			this.Controls.Add(this.txtProduto);
			this.Name = "frmCompras";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Compras";
			((System.ComponentModel.ISupportInitialize)(this.nudQTD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtProduto;
		private System.Windows.Forms.TextBox txtVtotal;
		private System.Windows.Forms.NumericUpDown nudQTD;
		private System.Windows.Forms.Label lblProduto;
		private System.Windows.Forms.Label lblQTD;
		private System.Windows.Forms.Label lblVTotal;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblForma;
		private System.Windows.Forms.RadioButton radVista;
		private System.Windows.Forms.RadioButton radParcelado;
		private System.Windows.Forms.TextBox txtFinal;
		private System.Windows.Forms.Label lblMsg;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnSair;
	}
}

