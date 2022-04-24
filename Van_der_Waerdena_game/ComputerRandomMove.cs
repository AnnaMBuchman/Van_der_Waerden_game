using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_der_Waerdena_game
{
    static class ComputerRandomStrategy
    {
        static public int MakeMove(int coinsLength)
        {
            Random rnd = new Random();
            return rnd.Next(coinsLength);
        }

    }
}
