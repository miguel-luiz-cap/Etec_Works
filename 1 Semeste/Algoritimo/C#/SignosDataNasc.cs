using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo5
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime nasc;
			int dia, mes;
			string signo;

		data_nasc:
			Console.WriteLine("Digite sua data de nascimento:");
			try
			{
				nasc = Convert.ToDateTime(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Data Invalida !!");
				goto data_nasc;
			}

			dia = nasc.Day;
			mes = nasc.Month;

			// Áries 21 / 03 a 20 / 04
			if (mes == 3 && dia >= 21 || mes == 4 && dia <= 20)
				signo = "Áries";

			// Touro 21 / 04 a 20 / 05
			else if (mes == 4 && dia >= 21 || mes == 5 && dia <= 20)
				signo = "Touro";

			// Gêmeos 21 / 05 a 20 / 06
			else if (mes == 5 && dia >= 21 || mes == 6 && dia <= 20)
				signo = "Gêmeos";

			// Câncer 21 / 06 a 21 / 07
			else if (mes == 6 && dia >= 21 || mes == 7 && dia <= 21)
				signo = "Câncer";

			// Leão 22 / 07 a 22 / 08
			else if (mes == 7 && dia >= 22 || mes == 8 && dia <= 22)
				signo = "Leão";

			// Virgem 23 / 08 a 22 / 09
			else if (mes == 8 && dia >= 23 || mes == 9 && dia <= 22)
				signo = "Virgem";

			// Libra 23/09 a 22/10
			else if (mes == 9 && dia >= 23 || mes == 10 && dia <= 22)
				signo = "Libra";

			// Escorpião 23/10 a 21/11
			else if (mes == 10 && dia >= 23 || mes == 11 && dia <= 21)
				signo = "Escorpião";

			// Sagitário 22/11 a 21/12
			else if (mes == 11 && dia >= 22 || mes == 12 && dia <= 21)
				signo = "Sagitário";

			// Capricórnio 22/12 a 20/01
			else if (mes == 12 && dia >= 22 || mes == 1 && dia <= 20)
				signo = "Capricórnio";

			// Aquário 21/01 a 19/02
			else if (mes == 1 && dia >= 21 || mes == 2 && dia <= 19)
				signo = "Aquário";

			// Peixes 20/02 a 20/03
			else if (mes == 2 && dia >= 20 || mes == 3 && dia <= 20)
				signo = "Peixes";

			else signo = "Nenhum";

			Console.WriteLine("Signo: " + signo);
			Console.ReadKey();
		}
	}
}
