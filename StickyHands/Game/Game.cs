using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Diagnostics;
using System.Threading;

namespace Game
{
    class Game
    {
        static void Main(string[] args)
        {
            Window consoleWindow = new Window();
            Printer printer = new Printer(consoleWindow);
            StartupHelper startupHelper = new StartupHelper(consoleWindow);
            CoinGenerator coinGenerator = new CoinGenerator();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Random random = new Random();
            Timer timer = new Timer(t =>
            {
                if (watch.Elapsed.Seconds % 3 == 0)
                {
                    Coin newCoin = coinGenerator.GenerateCoin(consoleWindow, random);
                    printer.PrintCoin(newCoin);
                }
                printer.PrintTime(watch.Elapsed);
            }, null, 1000, 1000);

            startupHelper.SetProperties();
            printer.PrintFrame();
            Player player = new Player("Nikolay");
            printer.PrintInfo(player);

            while (true)
            {

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    Direction newDirection = GetDirection(key.Key);
                    printer.ClearPlayer(player);
                    player.Move(newDirection);
                    printer.PrintPlayer(player);

                }
            }
        }

        static Direction GetDirection(ConsoleKey key)
        {
            Direction resultDirection = Direction.Left;
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    resultDirection = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    resultDirection = Direction.Right;
                    break;
                case ConsoleKey.UpArrow:
                    resultDirection = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    resultDirection = Direction.Down;
                    break;
            }
            return resultDirection;
        }
    }
}
