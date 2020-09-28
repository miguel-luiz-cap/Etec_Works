using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciaisDoNome
{
	class Program
	{
		static void Main(string[] args)
		{
			string nome, sobrenome;
			string inome, isobrenome, iniciais;

			Console.Write("Digite o nome: ");
			nome = Console.ReadLine();

			Console.Write("Digite o sobrenome: ");
			sobrenome = Console.ReadLine();

			inome = nome.Substring(0, 1);
			isobrenome = sobrenome.Substring(0, 1);

			iniciais = inome + isobrenome;
			Console.WriteLine(iniciais.ToLower());

			Console.ReadKey();
		}
	}
}
