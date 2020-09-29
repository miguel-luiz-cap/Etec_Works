using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
	class Program
	{
		static void Main(string[] args)
		{
			string nome, nome_min, senha, sz_n_chamada;
			int n_chamada;

			Console.Write("Digite seu nome: ");
			nome = Console.ReadLine();

			Console.Write("\nDigite o numero de chamada: ");
			n_chamada = Int32.Parse(Console.ReadLine());
			sz_n_chamada = n_chamada.ToString();
			sz_n_chamada = sz_n_chamada.PadLeft(5, '0');
			nome_min = nome.ToLower();

			//      -Primeira Letra-           -Ultima Letra-                             -Numero chamada-
			senha = nome_min.Substring(0, 1) + nome_min.Substring(nome_min.Length-1, 1) + sz_n_chamada;

			Console.Write("\nNome: " + nome);
			Console.Write("\nNumero de chamada: " + n_chamada);
			Console.Write("\nSenha: " + senha);

			Console.ReadKey();
		}
	}
}
