using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaNome
{
	class Program
	{
		static void Main(string[] args)
		{
			String nome;
			int quantidade;

			Console.Write("Digite o nome: ");
			nome = Console.ReadLine();

			quantidade = nome.Length;
			Console.WriteLine(nome.ToUpper());

			if (quantidade > 20)
			{
				Console.WriteLine("Nome longo!");
			}
			else
			{
				Console.WriteLine("Nome curto!");
			}
			Console.WriteLine("Possui: " + quantidade + " caracteres!");
			Console.ReadKey();
		}
	}
}
