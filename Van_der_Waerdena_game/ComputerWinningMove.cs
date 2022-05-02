using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_der_Waerdena_game
{
    static class ComputerWinningStrategy
    {
        static public int MakeMove(List<bool> coinsList, decimal k)
        {
            
            int remis = -1;
            int noneone = -1;
            for (int i = 0; i <= coinsList.Count; i++)
            {
                List<bool> coins = new List<bool>(coinsList);
                coins.Insert(i, true);
                WhoWinsCheck.WhoWins result = WhoWinsCheck.checkWhoWins(coins, k);
                if (result == WhoWinsCheck.WhoWins.Computer)
                    return i;
                if (result == WhoWinsCheck.WhoWins.Remis)
                    remis = i;
                if (result == WhoWinsCheck.WhoWins.Noneone)
                    noneone = i;
            }
            if (noneone != -1)
                return noneone;
            if (remis != -1)
                return remis;
            return coinsList.Count;
        }

    }
}
