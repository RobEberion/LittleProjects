using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class StartMenu : Menu
    {
        public override void DisplayMenu()
        {
            Console.WriteLine("[1] Spiel Starten");
            Console.WriteLine("[2] Spiel Beenden");
            Console.WriteLine();

            InputOption();
        }

        private void InputOption()
        {
            string input;
            Menu nextMenu;

            while (true)
            {
                Console.Write("Eingabe: ");
                input = Console.ReadLine();

                bool correctInput = true;

                switch (input)
                {
                    case "1":
                        nextMenu = new StartMenuOption();
                        break;

                    case "2":
                        break;
                    default:
                        correctInput = false;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ungültige Eingabe!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

                if (correctInput)
                    break;
            }
        }
    }
}
