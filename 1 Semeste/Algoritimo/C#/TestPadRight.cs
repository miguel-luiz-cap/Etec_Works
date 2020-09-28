using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Pad_Right
{
	class Program
	{
		static void Main(string[] args)
		{
			string teste = " Miguel Luiz Capristano ";
			string nova = teste.PadRight(45, '-');
			nova = nova.PadLeft(60, '-');
			if (teste.StartsWith(" Miguel"))
			{
				Console.WriteLine(nova);
			}
			Console.ReadKey();
		}
	}
}
