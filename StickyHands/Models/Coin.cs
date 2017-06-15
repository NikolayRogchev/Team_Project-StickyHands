using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Coin
    {
        public Coin(char symbol, int value)
        {
            this.Symbol = symbol;
            this.Value = value;
        }
        public char Symbol { get; set; }
        public int Value { get; set; }
    }
}
