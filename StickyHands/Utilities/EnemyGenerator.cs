using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Utilities
{
   public class EnemyGenerator
    {
        public Enemy GenerateEnemy(Window consoleWindow, Random rand)
        {
            //Random rand = new Random(0);
            char coinSymbol = '@';
            Position enemyPosition = new Position(rand.Next(3, consoleWindow.FrameWidth - 1), rand.Next(5, consoleWindow.FrameHeight - 1));
            Enemy newEnemy = new Enemy(coinSymbol, enemyPosition);
            return newEnemy;
        }

    }
}
