using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparandoIdades
{
	class Program
	{
		static void Main(string[] args)
		{
			string nome1, nome2;
			int idade1, idade2;
			char resposta;

			Console.Title = "Comparando idades";
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.Black;

			inicio:
			Console.Clear();

			Console.Write("\tDigite os Dados da Primeira Pessoa\n");

			Console.Write("\nNome da Pessoa: ");
			nome1 = Console.ReadLine();
			
			Console.Write("Idade da Pessoa: ");
			idade1 = int.Parse(Console.ReadLine());

			Console.Write("\n\n\tDigite os Dados da Segunda Pessoa\n");

			Console.Write("\nNome da Pessoa: ");
			nome2 = Console.ReadLine();
			
			Console.Write("\nIdade da Pessoa: ");
			idade2 = int.Parse(Console.ReadLine());

			if (idade1 > idade2)
			{
				Console.WriteLine("\n\tO " + nome1 + " é o mais velho");
			}
			else if (idade1 < idade2)
			{
				Console.WriteLine("\n\tO " + nome2 + " é o mais velho");
			}
			else
			{
				Console.WriteLine("\n\tO " + nome1 + " e o(a) " + nome2 +" tem a mesma idade");
			}
			
			Console.Write("\nDeseja Continuar? S/N ");
			resposta = char.Parse(Console.ReadLine());

			if(resposta == 's' || resposta == 'S')
			{
				goto inicio;
			}

		}
	}
}
