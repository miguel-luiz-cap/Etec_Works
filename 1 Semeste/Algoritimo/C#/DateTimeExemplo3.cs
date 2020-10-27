using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime hoje = DateTime.Now;

			Console.WriteLine("Hora Atual: " + hoje.TimeOfDay);
			Console.WriteLine("Dia atual: " + hoje.Day);
			Console.WriteLine("Dia da semana: " + hoje.DayOfWeek);
			Console.WriteLine("Mês Atual: " + hoje.Month);
			Console.WriteLine("Ano Atual: " + hoje.Year);
			Console.ReadKey();
		}
	}
}
