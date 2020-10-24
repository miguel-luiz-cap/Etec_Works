using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_29_09_2020
{
	public partial class frmVeiculos : Form
	{
		public frmVeiculos()
		{
			InitializeComponent();
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void radCarros_CheckedChanged(object sender, EventArgs e)
		{
			// Deixar os carros visiveis //

			// Aston
			picAston.Visible = true;
			radAston.Visible = true;

			// Bugatti
			picBugatti.Visible = true;
			radBugatti.Visible = true;

			// Deixar as motos invisiveis //

			// Harley devidson
			picHarley.Visible = false;
			radHarley.Visible = false;

			// Ducati
			picDucati.Visible = false;
			radDucati.Visible = false;
		}

		private void radMotos_CheckedChanged(object sender, EventArgs e)
		{
			// Deixar os carros invisiveis //

			// Aston
			picAston.Visible = false;
			radAston.Visible = false;

			// Bugatti
			picBugatti.Visible = false;
			radBugatti.Visible = false;

			// Deixar as motos visiveis //

			// Harley devidson
			picHarley.Visible = true;
			radHarley.Visible = true;

			// Ducati
			picDucati.Visible = true;
			radDucati.Visible = true;
		}

		private void radBugatti_CheckedChanged(object sender, EventArgs e)
		{
			picAston.Visible = false;
			radAston.Visible = false;

			lblMensagem.Visible = true;
			lblMensagem.Text = "O carro selecionado foi um " + radBugatti.Text;
		}

		private void radAston_CheckedChanged(object sender, EventArgs e)
		{
			picBugatti.Visible = false;
			radBugatti.Visible = false;

			lblMensagem.Visible = true;
			lblMensagem.Text = "O carro selecionado foi um " + radAston.Text;
		}

		private void radHarley_CheckedChanged(object sender, EventArgs e)
		{
			picDucati.Visible = false;
			radDucati.Visible = false;

			lblMensagem.Visible = true;
			lblMensagem.Text = "A moto selecionada foi uma " + radHarley.Text;
		}

		private void radDucati_CheckedChanged(object sender, EventArgs e)
		{
			picHarley.Visible = false;
			radHarley.Visible = false;

			lblMensagem.Visible = true;
			lblMensagem.Text = "A moto selecionada foi uma " + radDucati.Text;
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			radCarros.Checked = false;
			radMotos.Checked = false;
			radBugatti.Checked = false;
			radAston.Checked = false;
			radHarley.Checked = false;
			radDucati.Checked = false;
			picAston.Visible = false;
			radAston.Visible = false;
			picBugatti.Visible = false;
			radBugatti.Visible = false;
			picHarley.Visible = false;
			radHarley.Visible = false;
			picDucati.Visible = false;
			radDucati.Visible = false;
			lblMensagem.Visible = false;
		}
	}
}
