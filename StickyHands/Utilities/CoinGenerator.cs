using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class CoinGenerator
    {
        private Dictionary<char, int> coinsAvailible =  new Dictionary<char, int>();
        private char[] coins = { '$', '£', '€', '¥', '¢' };
        public CoinGenerator()
        {
            this.Coins = new HashSet<Coin>();
            coinsAvailible.Add('$', 10);
            coinsAvailible.Add('£', 20);
            coinsAvailible.Add('€', 30);
            coinsAvailible.Add('¥', 5);
            coinsAvailible.Add('¢', 1);
        }
        public HashSet<Coin> Coins { get; set; }

        public Coin GenerateCoin(Window consoleWindow, Random rand)
        {
            //Random rand = new Random(0);
            char coinSymbol = coins[rand.Next(4)];
            Position coinPosition = new Position(rand.Next(3, consoleWindow.FrameWidth - 1), rand.Next(5, consoleWindow.FrameHeight - 1));
            Coin newCoin = new Coin(coinSymbol, coinsAvailible[coinSymbol], coinPosition);
            Coins.Add(newCoin);
            return newCoin;
        }
    }
}
