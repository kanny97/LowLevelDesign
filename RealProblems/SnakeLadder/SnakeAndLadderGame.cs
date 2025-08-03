using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.SnakeLadder
{
    public class SnakeAndLadderGame
    {
        private readonly Board Board;
        private readonly List<Player> Players;
        private readonly Dice Dice;
        private int CurrentPlayerIndex;
        public SnakeAndLadderGame(List<string> playerNames)
        {
            Board = new Board();
            Dice = new Dice();
            Players = new List<Player>();
            CurrentPlayerIndex = 0;
            foreach (string playerName in playerNames)
            {
                Players.Add(new Player(playerName));        
            }
        }
        public void Play()
        {
            while (!IsGameOver())
            {
                Player currentPlayer = Players[CurrentPlayerIndex];
                int totalPlayers = Players.Count;
                int currPosition = currentPlayer.CurrentPosition;
                //Roll dice and get new position after resolving snake or leader start
                int rolledNumber = Dice.Roll();
                int newPosition = currPosition + rolledNumber;
                if (newPosition <= Board.GetBoardSize())
                {
                    newPosition = Board.GetNewPosition(newPosition);
                    Console.WriteLine($"Number {rolledNumber} was rolled in dice and {currentPlayer.Name} moves from Position {currPosition} to {newPosition}");
                    currentPlayer.SetCurrentPosition(newPosition);
                }
                if (newPosition == Board.GetBoardSize())
                {
                    Console.WriteLine($"Player {currentPlayer.Name} wins the game");
                    break;
                }
                CurrentPlayerIndex = (CurrentPlayerIndex + 1) % totalPlayers;
            }
        }
        private bool IsGameOver()
        {
            foreach (var player in Players)
            {
                if (player.CurrentPosition == Board.GetBoardSize())
                    return true;
            }
            return false;
        }
    }
}
