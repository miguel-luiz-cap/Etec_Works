using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arredondadmento
{
	class Program
	{
		static void Main(string[] args)
		{
			double valor;
			int casas;

			Console.Write("Digite um valor decimal: ");
			valor = double.Parse(Console.ReadLine());
			
			Console.Write("\nDigite o numero de casas: ");
			casas = int.Parse(Console.ReadLine());

			Console.WriteLine(Math.Round(valor, casas));
			Console.ReadKey();
		}
	}
}
