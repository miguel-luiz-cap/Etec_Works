using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfirmaEmailTeste
{
	class Program
	{
		static void Main(string[] args)
		{
			string email1, email2;
			bool resp;

			Console.Write("Digite seu email: ");
			email1 = Console.ReadLine();

			Console.Write("Confirme seu email: ");
			email2 = Console.ReadLine();

			resp = email1.Equals(email2);

			if (resp == true)
			{
				Console.WriteLine("Email confere!");
			}
			else
			{
				Console.WriteLine("Email não confere!");
			}

			Console.ReadKey();
		}
	}
}
