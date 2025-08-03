using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.SnakeLadder
{
    public class SnakeAndLadderDemo
    {
        public static void Run()
        {
            GameManager gameManager = GameManager.GetInstance();
            List<string>playerList1 = new List<string> { "Player1", "Player2", "Player3"};
            List<string> playerList2 = new List<string> { "Player4", "Player5", "Player6" };
            gameManager.StartNewGame(playerList1);
            gameManager.StartNewGame(playerList2);
        }
    }
}
