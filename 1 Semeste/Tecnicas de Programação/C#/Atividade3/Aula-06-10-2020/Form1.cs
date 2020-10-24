using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_06_10_2020
{
	public partial class frmCompras : Form
	{
		public frmCompras()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void txtProduto_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
				e.Handled = true;
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			if (txtProduto.Text == null || txtProduto.Text.Equals(""))
			{
				txtProduto.Focus();
				return;
			}

			txtVtotal.Text = Convert.ToString(Convert.ToDecimal(txtProduto.Text) * nudQTD.Value);

			lblForma.Visible = true;
			radParcelado.Visible = true;
			radVista.Visible = true;
		}

		private void radVista_CheckedChanged(object sender, EventArgs e)
		{
			txtFinal.Text = (Convert.ToDecimal(txtVtotal.Text) * 0.9m ).ToString();
			txtFinal.Visible = true;
			lblMsg.Text = "Valor com desconto em 10%:";
			lblMsg.Visible = true;
		}

		private void radParcelado_CheckedChanged(object sender, EventArgs e)
		{
			txtFinal.Text = (Math.Round(Convert.ToDecimal(txtVtotal.Text) / 3, 2)).ToString();
			txtFinal.Visible = true;
			lblMsg.Text = "Valor de cada parcela:";
			lblMsg.Visible = true;
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			radParcelado.Checked = false;
			radVista.Checked = false;
			radVista.Visible = false;
			radParcelado.Visible = false;
			lblForma.Visible = false;
			lblMsg.Visible = false;

			nudQTD.Value = 1;
			txtProduto.Clear();
			txtVtotal.Clear();
			txtFinal.Clear();
			txtProduto.Focus();
		}
	}
}