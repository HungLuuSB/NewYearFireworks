using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NewYearFireworks
{
    class Menu
    {
        public Menu(string[] options, string prompt)
        {
            Options = options;
            Prompt = prompt;
            SelectedIndex = 0;
        }
        public int SelectedIndex;
        public string[] Options { get; }
        public string Prompt { get; }

        private void Display()
        {
            string prefix = " ";
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                if (i == SelectedIndex)
                {
                    prefix = ">";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"{prefix}[{Options[i]}] ");
                ResetColor();
            }
        }
        public int Run()
        {
            ConsoleKey keypressed;
            do
            {
                SetCursorPosition(0, 0);
                Display();
                ConsoleKeyInfo key = Console.ReadKey();
                keypressed = key.Key;

                if (keypressed == ConsoleKey.UpArrow)
                {
                    if (SelectedIndex == 0)
                        SelectedIndex = Options.Length - 1;
                    else
                        SelectedIndex--;
                }
                else if (keypressed == ConsoleKey.DownArrow)
                {
                    if (SelectedIndex == Options.Length - 1)
                        SelectedIndex = 0;
                    else
                        SelectedIndex++;
                }
            } while (keypressed != ConsoleKey.Enter);
            return SelectedIndex;
        }
    }
}
