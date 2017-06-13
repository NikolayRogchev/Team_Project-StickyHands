using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Game
{
    class Game
    {
        static void Main(string[] args)
        {
            Window consoleWindow = new Window();
            Printer printer = new Printer(consoleWindow);
            StartupHelper startupHelper = new StartupHelper(consoleWindow);
            startupHelper.SetProperties();
            printer.PrintFrame();
            Console.ReadKey();
        }
    }
}
