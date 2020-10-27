using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Exemplo2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			txt_Data.Clear();
			txt_DataNasc.Clear();
			txt_Dia.Clear();
			txt_Idade.Clear();
		}

		private void btn_Sair_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btn_Exibir_Click(object sender, EventArgs e)
		{
			DateTime hoje, nasc;
			hoje = DateTime.Now;
			double idade;
			int TotalDia;

			try
			{
				txt_Data.Text = hoje.ToString();
				nasc = Convert.ToDateTime(txt_DataNasc.Text);
				TotalDia = hoje.Subtract(nasc).Days;
				txt_Dia.Text = TotalDia.ToString();
				//Console.WriteLine("Dias Vividos: " + TotalDia);

				idade = TotalDia / 365.25;
				txt_Idade.Text = Math.Round(idade, 1).ToString();
			}
			catch
			{
				MessageBox.Show("Data Inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			DateTime hoje = DateTime.Now;
			status_label.Text = hoje.ToString();
		}
	}
}
