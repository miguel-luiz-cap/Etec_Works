using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodificaTelefone
{
	class Program
	{
		static void Main(string[] args)
		{
			string telefone;
			string telmasc;

			Console.Write("Digite o número do telefone: ");
			telefone = Console.ReadLine();

			// 97777-6666
			// 97777-****
			telmasc = telefone.Replace(telefone.Substring(6, 4), "****");
			Console.WriteLine(telmasc);
			Console.ReadKey();
		}
	}
}
