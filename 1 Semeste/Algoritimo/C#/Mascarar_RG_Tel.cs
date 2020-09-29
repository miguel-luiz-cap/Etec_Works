using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
	class Program
	{
		static void Main(string[] args)
		{
			string Nome, RG, RG_Masc, Telefone, Tel_Masc;
			int PosNome, PosParenteses;
			double Nota;

			Console.Write("Digite o nome do aluno: ");
			Nome = Console.ReadLine();

			Console.Write("\nDigite o RG do aluno: ");
			RG = Console.ReadLine();

			Console.Write("\nDigite o Telefone do aluno: ");
			Telefone = Console.ReadLine();

			Console.Write("\nDigite a Nota do aluno: ");
			Nota = Double.Parse(Console.ReadLine());

			PosNome = Nome.IndexOf(' ');
			RG_Masc = RG.Replace(RG.Substring(RG.Length - 2, 2), "**");

			try
			{
				PosParenteses = Telefone.IndexOf(")");
				if(PosParenteses > 0) 
					Tel_Masc = Telefone.Replace(Telefone.Substring(PosParenteses + 2, 5), "*****");
				else
					Tel_Masc = Telefone.Replace(Telefone.Substring(0, 5), "*****");
			}
			catch
			{
				Tel_Masc = Telefone.Replace(Telefone.Substring(0, 5), "*****");
			}

			Console.Write("\nNome: " + Nome.Substring(0, PosNome));
			Console.Write("\nRG: " + RG_Masc);
			Console.Write("\nTelefone: " + Tel_Masc);

			Console.ReadKey();
		}
	}
}
