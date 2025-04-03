using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class StartMenuOption : Menu
    {
        public override void DisplayMenu()
        {
            Console.WriteLine("[1] Spieler gegen Spieler");
            Console.WriteLine("[2] Spieler gegen CPU");
            Console.WriteLine("[3] Zurück");
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
                        nextMenu = new PlayerVsPlayer();
                        break;

                    case "2":
                        Console.WriteLine("Noch nicht verfügbar! Such dir etwas anderes aus. :P");
                        Console.WriteLine("Eingabe nötig, um fortzufahren.");
                        Console.ReadKey();
                        nextMenu = new StartMenuOption();
                        //nextMenu = new PlayerVsComputer();
                        break;

                    case "3":
                        nextMenu = new StartMenu();
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
