using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.SnakeLadder
{
    public class Player
    {
        public string Name {  get; set; }
        public int CurrentPosition { get; private set; }
        public Player(string name)
        {
            Name = name;
            CurrentPosition = 0;
        }
        public void SetCurrentPosition(int position)
        {
            this.CurrentPosition = position;
        }        
    }
}
