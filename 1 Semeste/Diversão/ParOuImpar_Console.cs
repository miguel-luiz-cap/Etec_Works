using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_ou_impar
{
	class Program
	{
		static void Main(string[] args)
		{
			// Variaveis
			int par_impar, placar_player, placar_pc, numero_player, numero_maquina, resultado;
			Random getrandom = new Random();
			char Jogar_Novamente;

			// Placar Zerado
			placar_player = 0;
			placar_pc = 0;

			// Titulo da janela e cor
			Console.Title = " ---------- [Par ou Impar] ---------";
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Clear();

		inicio:
			Console.WriteLine("----------------------------------------------------------------------------------");
			Console.WriteLine("\t\t------------[Par ou impar]--------------");
			Console.WriteLine("\t------------ [Placar] [Jogador: " + placar_player + "] [Maquina: " + placar_pc + "] --------------");
			Console.WriteLine("----------------------------------------------------------------------------------\n");
			
			escolha_par_impar:
			Console.Write("------>\tEscolha Par ou Impar (0 - Par | 1 - Impar): ");
			try {
				par_impar = Int32.Parse(Console.ReadLine());
			}
			catch {
				goto escolha_par_impar;
			}

			if (par_impar != 0 && par_impar != 1) {
				goto escolha_par_impar;
			}

			Console.WriteLine("\n------>\t Voce escolheu: " + (par_impar == 0 ? "Par" : "Impar"));

			digite_numero:
			Console.Write("\n------>\t Digite seu Número: ");
			try {
				numero_player = Int32.Parse(Console.ReadLine());
			}
			catch {
				goto digite_numero;
			}

			// Numero da maquina
			numero_maquina = getrandom.Next(0, 999);

			// Resultado
			resultado = numero_player + numero_maquina;

			Console.WriteLine("\n\n----------------------------------------");
			Console.WriteLine("------>\t Seu Numero: " + numero_player);
			Console.WriteLine("------>\t Numero da Maquina: " + numero_maquina);
			Console.WriteLine("------>\t Resultado: " + resultado + ((resultado % 2) == 0 ? " (Par)" : " (Impar)"));
			Console.WriteLine("----------------------------------------");

			// Checar se o boy Ganhou
			if((resultado % 2) == 0 && par_impar == 0 || (resultado % 2) != 0 && par_impar == 1)
			{
				Console.Write("\n\n----------------------------------------");
				Console.Write("\n------>\t VOCÊ GANHOU \t<------");
				Console.Write("\n----------------------------------------");
				placar_player++; // Somar o Placar do Jogador
			}
			else
			{
				Console.Write("\n\n----------------------------------------");
				Console.Write("\n------>\t VOCÊ PERDEU \t<------");
				Console.Write("\n----------------------------------------");
				placar_pc++; // Somar o Placar da Maquina
			}

			// A Bendita Pergunta
			Console.Write("\n\n------>\t JOGAR NOVAMENTE (S/N): ");
			Jogar_Novamente = char.Parse(Console.ReadLine());

			if(Jogar_Novamente == 's' || Jogar_Novamente == 'S')
			{
				Console.Clear();
				goto inicio;
			}
		}
	}
}
