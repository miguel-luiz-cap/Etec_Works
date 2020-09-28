using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaEmail
{
	class Program
	{
		static void Main(string[] args)
		{
			string email;
			int posicao;

			Console.Write("Digite seu email: ");
			email = Console.ReadLine();
			posicao = email.IndexOf("@");

			if (posicao >= 0)
			{
				Console.WriteLine("OK");
			}
			else
			{
				Console.WriteLine("Tem algo errado");
			}
			Console.WriteLine(posicao);
			Console.ReadKey();
		}
	}
}
