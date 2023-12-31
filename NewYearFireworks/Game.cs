using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearFireworks
{
    class Game
    {
        public bool Gameover = false;
        public void Start()
        {
            Console.Title = "Fireworks";
            RunMainMenu();
        }
        private void RunMainMenu()
        {
            string Prompt = @"
 ________ .-./`) .-------.        .-''-.  .--.      .--.    ,-----.    .-------.    .--.   .--.   
|        |\ .-.')|  _ _   \     .'_ _   \ |  |_     |  |  .'  .-,  '.  |  _ _   \   |  | _/  /    
|   .----'/ `-' \| ( ' )  |    / ( ` )   '| _( )_   |  | / ,-.|  \ _ \ | ( ' )  |   | (`' ) /     
|  _|____  `-'`""`|(_ o _) /   . (_ o _)  ||(_ o _)  |  |;  \  '_ /  | :|(_ o _) /   |(_ ()_)      
|_( )_   | .---. | (_,_).' __ |  (_,_)___|| (_,_) \ |  ||  _`,/ \ _/  || (_,_).' __ | (_,_)   __  
(_ o._)__| |   | |  |\ \  |  |'  \   .---.|  |/    \|  |: (  '\_/ \   ;|  |\ \  |  ||  |\ \  |  | 
|(_,_)     |   | |  | \ `'   / \  `-'    /|  '  /\  `  | \ `""/  \  ) / |  | \ `'   /|  | \ `'   / 
|   |      |   | |  |  \    /   \       / |    /  \    |  '. \_/``"".'  |  |  \    / |  |  \    /  
'---'      '---' ''-'   `'-'     `'-..-'  `---'    `---`    '-----'    ''-'   `'-'  `--'   `'-'   
(C) 2023 Luu Thai Hung. All rights reserved.                                                                                                  
This game renders multiple fireworks
(UP/DOWN: MOVE)
(ENTER: SELECT)";
            string[] Options = new string[] { "Play", "Credit", "Exit" };
            Menu main = new Menu(Options, Prompt);
            int selectedIndex = main.Run();
            switch (selectedIndex)
            {
                case 2:
                    Exit();
                    break;
                case 1:
                    Credits();
                    break;
                case 0:
                    Begin();
                    break;
            }
        }
        private void Exit()
        {
            Console.WriteLine("Good bye");
        }
        private void Credits()
        {
            Console.Clear();
            string Credits = @"
V<<----[[CREDIT]]---->>V  V<<<-----[[DESCRIPTION]]----->>>V
|      |        |      |  |        |             |        |
^______^________^______^  ^________^_____________^________^
|Creator: Luu Thai Hung|  |This game is made to celebrate |
|Date: 12/29/2023      |  |new year. It generates multiple|
|Version: 1.1          |  |firewoks with different colors.|
|______________________|  |_______________________________|
";
            Console.WriteLine(Credits);
            Console.WriteLine("Press any key to go back to Main Menu");
            Console.ReadKey();
            Console.Clear();
            RunMainMenu();
        }
        private void PrintScreen(int[,] Screen)
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < Screen.GetLength(0); i++)
            {
                for (int j = 0; j < Screen.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    switch (Screen[i , j])
                    {
                        case 0:
                            Console.Write(" ");
                            break;
                        case 1:
                            Console.Write("|");
                            break;
                        case 2:
                            Console.Write("*");
                            break;
                        case 3:
                            Console.Write("O");
                            break;
                        case 4:
                            Console.Write("|");
                            break;
                        case 5:
                            Console.Write("\\");
                            break;
                        case 6:
                            Console.Write("/");
                            break;
                        case 7:
                            Console.Write("-");
                            break;
                        case 8:
                            Console.Write("-");
                            break;
                        case 9:
                            Console.Write("|");
                            break;
                        case 10:
                            Console.Write("/");
                            break;
                        case 11:
                            Console.Write("\\");
                            break;
                        case 12:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("|");
                            break;
                        case 13:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("*");
                            break;
                        case 14:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("O");
                            break;
                        case 15:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("|");
                            break;
                        case 16:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\\");
                            break;
                        case 17:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("/");
                            break;
                        case 18:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("-");
                            break;
                        case 19:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("-");
                            break;
                        case 20:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("|");
                            break;
                        case 21:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("/");
                            break;
                        case 22:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\\");
                            break;
                        case 23:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("|");
                            break;
                        case 24:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("*");
                            break;
                        case 25:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("O");
                            break;
                        case 26:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("|");
                            break;
                        case 27:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\\");
                            break;
                        case 28:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("/");
                            break;
                        case 29:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("-");
                            break;
                        case 30:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("-");
                            break;
                        case 31:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("|");
                            break;
                        case 32:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("/");
                            break;
                        case 33:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\\");
                            break;
                    }
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
        static void InitFireworks(int[,] Board, int attempts)
        {
            Random random = new Random();
            for (int i = 1; i <= attempts; i++)
            {
                int randomX = random.Next(5, 95);
                int randomY = random.Next(20, 24);
                int randomcolor = random.Next(0, 3);

                int colornum = 0;
                switch (randomcolor)
                {
                    case 0:
                        colornum = 0;
                        break;
                    case 1:
                        colornum = 11;
                        break;
                    case 2:
                        colornum = 22;
                        break;
                    default: colornum = 0; break;
                }
                Firework fw = new Firework(Board, randomX, randomY, colornum);
                fw.BeginFiring();
                Thread.Sleep(random.Next(1000, 2000));
            }
        }
        private void Begin()
        {
            Console.Clear();
            int height = 25; int width = 100;
            int[,] Screen = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Screen[i, j] = 0;
                }
            }
            Console.Write("Input attempts: ");
            int attempts = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Thread init = new Thread(() => { InitFireworks(Screen, attempts); });
            init.Start();
            Thread start = new Thread(() => {
                while (true)
                {
                    PrintScreen(Screen);
                    Thread.Sleep(500);
                }
            });
            start.Start();
        }
    }
}
