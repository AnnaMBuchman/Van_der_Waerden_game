using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_der_Waerdena_game
{
    public class Game
    {
        private readonly bool isComputerStarts;
        private readonly decimal maxNumberOfChips;
        private bool v;
        private NumericUpDown numberChips;

        public Game(bool isComputerStarts, decimal maxNumberOfChips)
        {
            this.isComputerStarts = isComputerStarts;
            this.maxNumberOfChips = maxNumberOfChips;
        }

        public Game(bool v, NumericUpDown numberChips)
        {
            this.v = v;
            this.numberChips = numberChips;
        }
    }
}
