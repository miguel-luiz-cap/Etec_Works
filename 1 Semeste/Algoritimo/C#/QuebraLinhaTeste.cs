using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuebraCaracteresTeste
{
	class Program
	{
		static void Main(string[] args)
		{
			string texto = "91818-1919-54-789-411";
			string[] retornoSplit = texto.Split('-');

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(retornoSplit[i]);
			}
			Console.ReadKey();
		}
	}
}
