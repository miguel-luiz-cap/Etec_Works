using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
	class Program
	{
		static void Main(string[] args)
		{
			inicio:

			Console.Title = "-- Programa Soma --";
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Clear();

			int n1, n2, r;
			char resposta;
			Console.Write("\t\t\t--- Programa Soma ----");
			Console.Write("\n\nDigite um Valor: ");
			n1 = Int32.Parse(Console.ReadLine());

			Console.Write("\n\nDigite outro Valor: ");
			n2 = Int32.Parse(Console.ReadLine());

			r = n1 + n2;

			Console.WriteLine("\n\nO Resultado é: " + r);
			Console.WriteLine("\n\nDeseja Continuar (S/N): ");
			resposta = char.Parse(Console.ReadLine());

			if(resposta == 'S' || resposta == 's') {
				Console.Clear();
				goto inicio;
			}

			Console.WriteLine("Programa sera fechado...");
			Console.ReadKey();
		}
	}
}
