using Models;
using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Diagnostics;

namespace Game
{
    class Game
    {
        static void Main(string[] args)
        {
            Window consoleWindow = new Window();
            Printer printer = new Printer(consoleWindow);
            StartupHelper startupHelper = new StartupHelper(consoleWindow);
            Stopwatch watch = new Stopwatch();
            watch.Start();
            System.Threading.Timer timer = new System.Threading.Timer(t => printer.PrintTime(watch.Elapsed), null, 1000, 1000);
            //timer.Start();

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
                    //Thread.Sleep(10);
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
