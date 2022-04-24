namespace Van_der_Waerdena_game
{
    public class Game
    {
        private readonly bool isComputerStarts;
        private readonly decimal maxNumberOfChips;
        
        //computer always true, human always false
        public List<bool> coinsList = new List<bool>();
        public enum whoWins {Noneone, Computer, Human, Remis}        
        
        public Game(bool isComputerStarts, decimal maxNumberOfChips)
        {
            this.isComputerStarts = isComputerStarts;
            this.maxNumberOfChips = maxNumberOfChips;
            if (isComputerStarts) coinsList.Add(true);
            else
            {
                coinsList.Add(false);
                addCoin(true, ComputerRandomStrategy.MakeMove(coinsList.Count));
            }
        }
        public whoWins addCoin(bool isComputerMove, int where)
        {
            coinsList.Insert(where, isComputerMove);
            return checkWhoWins();

        }

        public int getConisListCount()
        {
            return coinsList.Count;
        }

        public whoWins checkWhoWins()
        {
            int coinsCount = getConisListCount();
            if((coinsCount+1)/2 < maxNumberOfChips)
                return whoWins.Noneone;
            bool computerLose = false;
            bool humanLose = false;
            for (int step = 1; step < (coinsCount-1)/maxNumberOfChips+1; step++)
            {
                for(int firstCountCheck=0; firstCountCheck + step*maxNumberOfChips < coinsCount; firstCountCheck++)
                {
                    bool first = coinsList[firstCountCheck];
                    for(int i=1; i < maxNumberOfChips; i++)
                    {
                        if (coinsList[firstCountCheck + i * step] != first)
                            break;
                        if (i + 1 == maxNumberOfChips)
                        {
                            if (first) computerLose = true;
                            else humanLose = true;
                        }
                    }
                }
            }
            if (computerLose && humanLose) return whoWins.Remis;
            if (computerLose) return whoWins.Human;
            if(humanLose) return whoWins.Computer;
            return whoWins.Noneone;
        }





        

    }
}
