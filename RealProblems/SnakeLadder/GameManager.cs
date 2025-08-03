using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.SnakeLadder
{
    public class GameManager
    {
        private static GameManager _instance;
        private static readonly object _lock = new object();
        private readonly List<SnakeAndLadderGame> _games;

        private GameManager() 
        { 
            _games = new List<SnakeAndLadderGame>(); 
        }
        public static GameManager GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new GameManager();
                    }
                }                
            }
            return _instance;
        }
        public void StartNewGame(List<string> playerNames)
        {
            SnakeAndLadderGame game = new SnakeAndLadderGame(playerNames);
            _games.Add(game);
            //Play each game via a new thread
            Thread gameThread = new Thread(new ThreadStart(game.Play));
            gameThread.Start();            
        }
    }
}
