using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime hoje = DateTime.Now;
			string hora = DateTime.Now.ToShortTimeString(); // Hora
			string data = DateTime.Now.ToShortDateString(); // Data
			Console.WriteLine("Data: " + data + " Hora: " + hora);
			Console.ReadKey();
		}
	}
}
