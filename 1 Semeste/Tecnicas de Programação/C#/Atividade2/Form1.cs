using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_TP_22_09_2020
{
	public partial class frmFeira : Form
	{
		public frmFeira()
		{
			InitializeComponent();
		}

		private void btnAddFruta_Click(object sender, EventArgs e)
		{
			lstFrutas.Items.Add(txtFruta.Text);
			txtFruta.Clear();
			txtFruta.Focus();
		}

		private void btnAddPastel_Click(object sender, EventArgs e)
		{
			lstPastel.Items.Add(txtPastel.Text);
			txtPastel.Clear();
			txtPastel.Focus();
		}

		private void btnRemFruta_Click(object sender, EventArgs e)
		{
			lstFrutas.Items.Remove(lstFrutas.SelectedItem);
		}

		private void btnRemPastel_Click(object sender, EventArgs e)
		{
			lstPastel.Items.Remove(lstPastel.SelectedItem);
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			lstFrutas.Items.Clear();
			lstPastel.Items.Clear();
			txtFruta.Clear();
			txtPastel.Clear();
			txtPastel.Focus();
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
