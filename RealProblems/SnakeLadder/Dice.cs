using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.SnakeLadder
{
    public class Dice
    {
        private const int MinValue = 1;
        private const int MaxValue = 6;        

        public int Roll()
        {
            Random random = new Random();
            return random.Next(MinValue, MaxValue + 1);
        }
    }
}
