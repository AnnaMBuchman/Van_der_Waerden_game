using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Van_der_Waerdena_game
{
    static public class WhoWinsCheck
    {
        public enum WhoWins { Noneone, Computer, Human, Remis }
        static public WhoWins checkWhoWins(List<bool> coinsListCopy, decimal maxNumberOfChips)
        {
            int coinsCount = coinsListCopy.Count();
            if ((coinsCount + 1) / 2 < maxNumberOfChips)
                return WhoWins.Noneone;
            bool computerLose = false;
            bool humanLose = false;
            for (int step = 1; step <= (coinsCount) / maxNumberOfChips + 1; step++)
            {
                for (int firstCountCheck = 0; firstCountCheck + 1 + step * (maxNumberOfChips - 1) <= coinsCount; firstCountCheck++)
                {
                    bool first = coinsListCopy[firstCountCheck];
                    for (int i = 1; i < maxNumberOfChips; i++)
                    {
                        if (coinsListCopy[firstCountCheck + i * step] != first)
                            break;
                        if (i + 1 == maxNumberOfChips)
                        {
                            if (first) computerLose = true;
                            else humanLose = true;
                        }
                    }
                }
            }
            if (computerLose && humanLose) return WhoWins.Remis;
            if (computerLose) return WhoWins.Human;
            if (humanLose) return WhoWins.Computer;
            return WhoWins.Noneone;
        }
    }
}
