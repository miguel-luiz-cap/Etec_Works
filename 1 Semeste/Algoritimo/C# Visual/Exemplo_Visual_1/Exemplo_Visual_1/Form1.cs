using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_Visual_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_Exibir_Click(object sender, EventArgs e)
		{
			DateTime hoje = DateTime.Now;
			txt_Data.Text = hoje.ToString();
			txtData.Text = hoje.ToLongDateString();
			txtHora.Text = hoje.ToShortTimeString();

			txtDia.Text = hoje.Day.ToString();
			txtMes.Text = hoje.Month.ToString();
			txtAno.Text = hoje.Year.ToString();
			txtSemana.Text = hoje.DayOfWeek.ToString();
		}

		private void btn_Reset_Click(object sender, EventArgs e)
		{
			txt_Data.Clear();
			txtHora.Clear();
			txtData.Clear();

			txtDia.Clear();
			txtMes.Clear();
			txtAno.Clear();
			txtSemana.Clear();
		}

		private void btn_Sair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
