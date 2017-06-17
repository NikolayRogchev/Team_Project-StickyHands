using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Player
    {
        public Player(string name)
        {
            this.Name = name;
            this.Position = new Position(Console.WindowWidth / 2, Console.WindowHeight / 2);
            this.CoinsCollected = new Stack<Coin>();
            this.Points = 0;
            this.Body = "O";
        }
        public string Name { get; set; }
        public int Points { get; set; }
        public Position Position { get; set; }
        public Stack<Coin> CoinsCollected { get; set; }
        public string Body { get; set; }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    this.Position.Y--;
                    break;
                case Direction.Down:
                    this.Position.Y++;
                    break;
                case Direction.Left:
                    this.Position.X--;
                    break;
                case Direction.Right:
                    this.Position.X++;
                    break;
            }
        }

        
        public string GetStats()
        {
            string info = GetPlayerInfo();
            string stats = GetPlayerStats();
            return string.Format($"{info}{Environment.NewLine}{stats}");
        }

        public string GetPlayerStats()
        {
            return string.Format($"\tTotal coins collected: [{this.CoinsCollected.Count}]. Total points: [{this.Points}]");
        }

        private string GetPlayerInfo()
        {
            return "Player: " + this.Name;
        }
        
    }

    public enum Direction
    {
        Up, Down, Left, Right
    }
}
