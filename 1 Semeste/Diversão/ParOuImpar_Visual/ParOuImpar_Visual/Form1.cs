using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParOuImpar_Visual
{
	public partial class frm_ParImpar : Form
	{
		public frm_ParImpar()
		{
			InitializeComponent();
		}

		private void btn_Jogar_Click(object sender, EventArgs e)
		{
			lbl_Resultado.Visible = true;
			int numero_player, numero_maquina, resultado;
			Random getrandom = new Random();

			numero_player = Convert.ToInt32(num_User.Value);
			numero_maquina = getrandom.Next(0, 100);
			resultado = numero_player + numero_maquina;

			lbl_Resultado.Text = "Você: " + numero_player + "\nMáquina: " + numero_maquina + "\nResultado:" + resultado + ((resultado % 2 == 0) ? " (Par)" : " (Impar)");

			if (resultado % 2 == 0 && rad_Par.Checked || resultado % 2 != 0 && rad_Impar.Checked)
			{
				Placar.SetWinner(1);
				lbl_Resultado.Text += "\n\nVOCÊ GANHOU !!!!";
			}
			else
			{
				Placar.SetWinner(0);
				lbl_Resultado.Text += "\n\nVOCÊ PERDEU !!!!";
			}

			lbl_Placar.Text = "[Você] " +  Placar.GetWinner(1) + " X " + Placar.GetWinner(0) + " [Máquina]";
			btn_Jogar.Enabled = false;
			btn_Limpar.Visible = true;
			btn_Sair.Visible = true;
		}

		private void btn_Sair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btn_Limpar_Click(object sender, EventArgs e)
		{
			lbl_Resultado.Visible = false;
			btn_Jogar.Enabled = true;
			btn_Limpar.Visible = false;
			btn_Sair.Visible = false;
		}
	}
}
