using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Models
{
    public class Player
    {
        public Player(string name)
        {
            this.Name = name;
            this.Position = new Position(Console.WindowWidth / 2, Console.WindowHeight / 2);
            this.Points = 0;
        }
        public string Name { get; set; }
        public int Points { get; set; }
        public Position Position { get; set; }
        public IDictionary<char, int> CoinsCollected { get; set; }
    }
}
