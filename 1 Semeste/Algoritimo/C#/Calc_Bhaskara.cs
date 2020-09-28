using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
	class Program
	{
		static void Main(string[] args)
		{
			double Valor_A, Valor_B, Valor_C, X1, X2, Delta, Raiz_delta;
			char sim_nao;

		Inicio:
			Console.Clear();
			Console.Write("\t\t---------- Bhaskara ---------\n\n");

		Numero1:
			Console.Write("----->\tEscreva o Valor de A: ");
			try	{
				Valor_A = double.Parse(Console.ReadLine());
			}
			catch {
				goto Numero1;
			}
		
		Numero2:
			Console.Write("\n----->\tEscreva o Valor de B: ");
			try	{
				Valor_B = double.Parse(Console.ReadLine());
			}
			catch {
				goto Numero2;
			}
		
		Numero3:
			Console.Write("\n----->\tEscreva o Valor de C: ");
			try	{
				Valor_C = double.Parse(Console.ReadLine());
			}
			catch {
				goto Numero3;
			}

			Delta = Math.Pow(Valor_B, 2) - 4 * Valor_A * Valor_C;

			if(Delta < 0) {
				Console.Write("\n----->\tDelta é negativo, portanto sem solução real (Valor delta = " + Delta + ") ");
				goto Fim;
			}
			Raiz_delta = Math.Sqrt(Delta);
			Raiz_delta = Math.Round(Raiz_delta);

			X1 = (Valor_B * (-1) + Raiz_delta) / 2 * Valor_A;
			X2 = (Valor_B * (-1) - Raiz_delta) / 2 * Valor_A;
			X1 = Math.Round(X1);
			X2 = Math.Round(X2);

			Console.Write("\n------------------------------------------");
			Console.Write("\n---->\t Resultado:");
			Console.Write("\n---->\t Valor X' = " + X1);
			Console.Write("\n---->\t Valor X'' = " + X2);
			Console.Write("\n------------------------------------------");

		Fim:
			Console.Write("\n\nDeseja Calcular novamente? (S/N) ");
			try {
				sim_nao = Char.Parse(Console.ReadLine());
			}
			catch {
				goto Fim;
			}

			if (sim_nao == 's' || sim_nao == 'S')
				goto Inicio;
			else if (sim_nao != 'n' && sim_nao != 'N')
				goto Fim;
		}
	}
}
