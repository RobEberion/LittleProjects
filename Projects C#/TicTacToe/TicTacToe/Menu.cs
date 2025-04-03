using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    abstract class Menu
    {
        public Menu()
        {
            //Console.Clear();

            GameLogo();

            DisplayMenu();
        }
        public abstract void DisplayMenu();

        private void GameLogo()
        {
            Console.WriteLine("|-|-----------|-|");
            Console.Write("| |");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Tic");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Tac");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Toe ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("| |");
            Console.WriteLine("|-|-----------|-|");
            Console.WriteLine();
        }
    }
}
