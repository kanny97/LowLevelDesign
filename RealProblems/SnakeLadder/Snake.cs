using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.SnakeLadder
{
    public class Snake
    {
        public int Start { get; }
        public int End { get; }
        public Snake(int start, int end)
        {
            this.Start = start;
            this.End = end;
        }
    }
}
