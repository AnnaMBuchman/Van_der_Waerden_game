using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_der_Waerdena_game
{
    static class ComputerKMinusOneStrategy
    {
        static public int MakeMove(List<bool> coinsList, decimal k)
        {
            for(int i = 0; i < coinsList.Count; i++)
            {
                if(coinsList[i])
                {
                    if (i == coinsList.Count - 1)
                        return i + 1;
                    for (int j = 1; j < k-1 && i+j<coinsList.Count; j++)
                    {
                        if (!coinsList[i + j])
                            return i + j;
                        else if (j == k - 2)
                            i = j + i;
                    }
                }
            }
            for(int i = 0;i < coinsList.Count-1; i++)
            {
                if(!coinsList[i] && !coinsList[i+1])
                    return i+1;

            }
            return 0;
        }

    }
}
