using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar_Visual
{
	class Placar
	{
		public static int placar_pc = 0;
		public static int placar_player = 0;

        public static void SetWinner(int winner)
        {
            if (winner >= 1)
                placar_player++;

            else
                placar_pc++;
        }
        public static int GetWinner(int winner)
        {
            if (winner >= 1)
                return placar_player;

            return placar_pc;
        }
    }

}
