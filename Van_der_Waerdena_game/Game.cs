namespace Van_der_Waerdena_game
{
    public class Game
    {
        public readonly decimal maxNumberOfChips;
        
        //computer always true, human always false
        public List<bool> coinsList = new List<bool>();
        
        public Game(bool isComputerStarts, decimal maxNumberOfChips)
        {
            this.maxNumberOfChips = maxNumberOfChips;
            if (isComputerStarts) coinsList.Add(true);
            else
            {
                coinsList.Add(false);

                addCoin(true, ComputerRandomStrategy.MakeMove(coinsList.Count));
            }
        }
        public WhoWinsCheck.WhoWins addCoin(bool isComputerMove, int where)
        {
            coinsList.Insert(where, isComputerMove);
            return WhoWinsCheck.checkWhoWins(coinsList,maxNumberOfChips);
        }

        public int getConisListCount()
        {
            return coinsList.Count;
        }

    }
}
