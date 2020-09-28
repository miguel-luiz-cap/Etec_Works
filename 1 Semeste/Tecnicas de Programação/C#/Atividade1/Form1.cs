using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_TP_01_09_20
{
    public partial class frmProjeto01 : Form
    {
        public frmProjeto01()
        {
            InitializeComponent();
        }

		private void btnApagar_Click(object sender, EventArgs e)
		{
            MessageBox.Show("Ola " + txtNome.Text + "!", "AAAAA");
            MessageBox.Show("Seu Esporte Favorito eh " + txtEsporte.Text + "!!", "AAAAA");
            /*DialogResult resultado = MessageBox.Show("Teste", "AAAA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

			if (resultado == DialogResult.Yes) {
                MessageBox.Show("Clicou no Sim", "AAAA", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Clicou no Nao", "AAAA", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            else {
                MessageBox.Show("Clicou no Fodase", "AAAA", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }*/
        }

		private void btnSair_Click(object sender, EventArgs e)
		{
            DialogResult resultado = MessageBox.Show("Você deseja sair", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
                Close();
        }



		private void btnLimpar_Click(object sender, EventArgs e)
		{
            txtNome.Clear();
            txtEsporte.Clear();
            txtNome.Focus();
		}
	}
}
