using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo4
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime hoje, nasc;
			hoje = DateTime.Now;
			double idade;
			int TotalDia;

			Console.WriteLine("Digite sua data de nascimento:");
			nasc = Convert.ToDateTime(Console.ReadLine());

			TotalDia = hoje.Subtract(nasc).Days;
			Console.WriteLine("Dias Vividos: " + TotalDia);

			idade = TotalDia / 365.25;
			Console.WriteLine("Idade: " + Math.Round(idade, 1));
			Console.ReadKey();
		}
	}
}
