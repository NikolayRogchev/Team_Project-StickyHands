using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Printer
    {

        public Printer(Window window)
        {
            this.Window = window;
        }

        public Printer()
        {
            this.Window = new Window();
        }

        public Window Window { get; set; }

        public void PrintFrame()
        {
            for (int row = 0; row <= Window.FrameHeight; row++)
            {
                if (row == 0)
                {
                    Console.WriteLine();
                    // todo: Print player stats
                    continue;
                }
                char firstSymbol = Window.VerticalBorder;
                char lastSymbol = Window.VerticalBorder;
                char middleSymbol = Window.EmptySpace;
                if (row == 1 || row == Window.FrameHeight)
                {
                    middleSymbol = Window.HorizontalBorder;
                    if (row == 1)
                    {
                        firstSymbol = Window.TopLeftCornerBorder;
                        lastSymbol = Window.TopRightCornerBorder;
                    }
                    else
                    {
                        firstSymbol = Window.BottomLeftCornerBorder;
                        lastSymbol = Window.BottomRightCornerBorder;
                    }

                }

                if (row != Window.FrameHeight)
                {
                    Console.WriteLine($" {firstSymbol}{new string(middleSymbol, Window.Width - 2)}{lastSymbol}");
                }
                else
                {
                    Console.WriteLine($" {firstSymbol}{new string(middleSymbol, Window.Width - 2)}{lastSymbol}");
                }
            }
        }
    }
}
