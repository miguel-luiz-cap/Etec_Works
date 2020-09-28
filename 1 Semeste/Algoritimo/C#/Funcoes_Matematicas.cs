using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14_09_2020
{
	class Program
	{
		static void Main(string[] args)
		{
			double exp, valor, resultado;
			int id_operacao;
			char sim_nao;

			exp = 0;
			valor = 0;
			resultado = 0;

			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;

		Inicio:
			Console.Clear();
			Console.Write("\t\t----------------------------------------------------\n");
			Console.Write("\t\t----------- Funções Matemáticas --------------------\n");
			Console.Write("\t\t----------------------------------------------------\n\n");
		
		Escolher_Operacao:
			Console.Write("Qual a operação matematica você escolhe?\n[1 - Divisão | 2 - Multiplicação | 3 - Adição | 4 - Subtração | 5 - Potencia | 6 - Raiz Quadrada]\n");
			try {
				id_operacao = Int32.Parse(Console.ReadLine());
			}
			catch {
				goto Escolher_Operacao;
			}

			if(id_operacao < 1 || id_operacao > 6) {
				goto Escolher_Operacao;
			}


		Numero:
			Console.Write("\nDigite um Número: ");

			try {
				valor = Double.Parse(Console.ReadLine());
			}
			catch {
				goto Numero;
			}

		Numero_2:

			if (id_operacao != 6) { 
				Console.Write("\nDigite um outro Número: ");
				
					exp =try	{ Double.Parse(Console.ReadLine());
				}
				catch {
					goto Numero_2;
				}
			}

			switch(id_operacao)
			{
				case 1: {
					resultado = valor / exp;
					break;
				}
				case 2: {
					resultado = valor * exp;
					break;
				}
				case 3: {
					resultado = valor + exp;
					break;
				}
				case 4: {
					resultado = valor - exp;
					break;
				}
				case 5: {
					resultado = Math.Pow(valor, exp);
					break;
				}
				case 6: {
					resultado = Math.Sqrt(valor);
					break;
				}
			}

			Console.Write("\nResultado: " + resultado);

		Pergunta:
			Console.Write("\n\nFazer outro Calculo? (S/N) ");
			try {
				sim_nao = Char.Parse(Console.ReadLine());
			}
			catch {
				goto Pergunta;
			}

			if (sim_nao == 's' || sim_nao == 'S')
				goto Inicio;
			else if (sim_nao != 'n' && sim_nao != 'N')
				goto Pergunta;
		}
	}
}
