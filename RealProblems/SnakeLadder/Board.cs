using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RealProblems.SnakeLadder
{
    public class Board
    {
        private readonly List<Snake> Snakes;
        private readonly List<Ladder> Ladders;
        private const int BoardSize = 100;
        public Board(string configPath = "BoardConfig.json")
        {
            Snakes = new List<Snake>();
            Ladders = new List<Ladder>();
            InitializeBoard(configPath);
        }
        public int GetBoardSize()
        {
            return BoardSize;
        }
        private void AddSnake(int start, int end)
        {
            if (start < end || start < 1 || end < 1 || start > BoardSize || end > BoardSize)
            {
                throw new ArgumentException("Invalid snake positions.");
            }
            Snakes.Add(new Snake(start, end));
        }
        private void AddLadder(int start, int end)
        {
            if (start > end || start < 1 || end < 1 || start > BoardSize || end > BoardSize)
            {
                throw new ArgumentException("Invalid ladder positions.");
            }
            Ladders.Add(new Ladder(start, end));
        }
        private void InitializeBoard(string configPath)
        {
            if (!File.Exists(configPath))
            {
                throw new FileNotFoundException($"Config path {configPath} doesn't exist");
            }
            string json = File.ReadAllText(configPath);
            var config = JsonSerializer.Deserialize<BoardConfig>(json);

            if (config?.Snakes != null)
            {
                foreach (var snake in config.Snakes)
                {
                    AddSnake(snake.Start, snake.End);
                }
            }

            if (config?.Ladders != null)
            {
                foreach (var ladder in config.Ladders)
                {
                    AddLadder(ladder.Start, ladder.End);
                }
            }
        }
        public int GetNewPosition(int position)
        {
            foreach(var snake in Snakes)
            {
                if (snake.Start == position)
                {
                    return snake.End;
                }
            }
            foreach(var ladder in Ladders)
            {
                if (ladder.Start == position)
                {
                    return ladder.End;
                }
            }
            return position;
        }
    }
}
