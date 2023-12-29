using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearFireworks
{
    class Game
    {
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
    }
}
