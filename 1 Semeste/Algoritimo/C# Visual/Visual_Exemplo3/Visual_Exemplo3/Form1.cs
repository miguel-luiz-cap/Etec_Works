using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Exemplo3
{
	public partial class frm_Signos : Form
	{
		public frm_Signos()
		{
			InitializeComponent();
		}

		private void btn_Sair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime nasc;
			int dia, mes;
			string signo = "";

			try
			{
				nasc = Convert.ToDateTime(mtxt_DataNasc.Text);

				dia = nasc.Day;
				mes = nasc.Month;

				// Áries 21 / 03 a 20 / 04
				if (mes == 3 && dia >= 21 || mes == 4 && dia <= 20)
				{
					signo = "Áries";
					pic_Signos.Image = Properties.Resources.aries;
				}

				// Touro 21 / 04 a 20 / 05
				else if (mes == 4 && dia >= 21 || mes == 5 && dia <= 20)
				{
					signo = "Touro";
					pic_Signos.Image = Properties.Resources.touro;
				}

				// Gêmeos 21 / 05 a 20 / 06
				else if (mes == 5 && dia >= 21 || mes == 6 && dia <= 20)
				{
					signo = "Gêmeos";
					pic_Signos.Image = Properties.Resources.gemeos;
				}

				// Câncer 21 / 06 a 21 / 07
				else if (mes == 6 && dia >= 21 || mes == 7 && dia <= 21)
				{
					signo = "Câncer";
					pic_Signos.Image = Properties.Resources.cancer;
				}

				// Leão 22 / 07 a 22 / 08
				else if (mes == 7 && dia >= 22 || mes == 8 && dia <= 22)
				{
					signo = "Leão";
					pic_Signos.Image = Properties.Resources.leao;
				}

				// Virgem 23 / 08 a 22 / 09
				else if (mes == 8 && dia >= 23 || mes == 9 && dia <= 22)
				{
					signo = "Virgem";
					pic_Signos.Image = Properties.Resources.virgem;
				}

				// Libra 23/09 a 22/10
				else if (mes == 9 && dia >= 23 || mes == 10 && dia <= 22)
				{
					signo = "Libra";
					pic_Signos.Image = Properties.Resources.libra;
				}

				// Escorpião 23/10 a 21/11
				else if (mes == 10 && dia >= 23 || mes == 11 && dia <= 21)
				{
					signo = "Escorpião";
					pic_Signos.Image = Properties.Resources.escorpiao;
				}

				// Sagitário 22/11 a 21/12
				else if (mes == 11 && dia >= 22 || mes == 12 && dia <= 21)
				{
					signo = "Sagitário";
					pic_Signos.Image = Properties.Resources.sagitario;
				}

				// Capricórnio 22/12 a 20/01
				else if (mes == 12 && dia >= 22 || mes == 1 && dia <= 20)
				{
					signo = "Capricórnio";
					pic_Signos.Image = Properties.Resources.capricornio;
				}

				// Aquário 21/01 a 19/02
				else if (mes == 1 && dia >= 21 || mes == 2 && dia <= 19)
				{
					signo = "Aquário";
					pic_Signos.Image = Properties.Resources.aquario;
				}

				// Peixes 20/02 a 20/03
				else if (mes == 2 && dia >= 20 || mes == 3 && dia <= 20)
				{
					signo = "Peixes";
					pic_Signos.Image = Properties.Resources.peixes;
				}
				lbl_Signo.Text += signo;
			}
			catch
			{
				MessageBox.Show("Data Inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_Apagar_Click(object sender, EventArgs e)
		{
			mtxt_DataNasc.Clear();
			lbl_Signo.Text = "Signo: ";
			pic_Signos.Image = null;
			mtxt_DataNasc.Focus();
		}

	}
}
