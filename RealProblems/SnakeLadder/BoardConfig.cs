using System.Collections.Generic;

namespace RealProblems.SnakeLadder
{
    public class BoardConfig
    {
        public List<SnakeConfig> Snakes { get; set; }
        public List<LadderConfig> Ladders { get; set; }
    }

    public class SnakeConfig
    {
        public int Start { get; set; }
        public int End { get; set; }
    }

    public class LadderConfig
    {
        public int Start { get; set; }
        public int End { get; set; }
    }
}
