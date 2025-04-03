using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Players
    {
            public string name {get; set;}
            public string sign {get; set;}

        public void PlayerLayoutName(string name)
        {    
            Console.WriteLine(name);
        }
        public void PlayerLayout1()
            { 
                Console.WriteLine();
                Console.Write("Dein Symbol: ");
            }
        public void PlayerLayoutSign(string sign) 
        {
            Console.WriteLine(sign); 
        }
        public void PlayerLayout2()
        {
            Console.WriteLine();
            Console.Write("Mögliche Spielzüge: ");
        }

        

    }
}
