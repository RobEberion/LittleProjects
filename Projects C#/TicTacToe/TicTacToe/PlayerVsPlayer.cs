using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe;

namespace TicTacToe
{
    internal class PlayerVsPlayer : Menu
    {
        public override void DisplayMenu()
        {
            String[,] tabelle =
                {
                {"   ", "1", "2", "3"},
                {"   ", "_", "_", "_"},
                {"A |", "*", "*", "*"},
                {"B |", "*", "*", "*"},
                {"C |", "*", "*", "*"}
                };

            string[] possibleturn = 
                { "1A, ", "2A, ", "3A, ", "1B, ", "2B, ", "3B, ", "1C, ", "2C, ", "3C, " };
            
            int startNumber = 0;

            while (true)
            {
                ShowArray(tabelle);

                Players player1 = new Players();
                player1.name = "Spieler Eins";
                player1.sign = "X";

                Players player2 = new Players();
                player2.name = "Spieler Zwei";
                player2.sign = "O";

                string playMoveSign = "";
                string aktivePlayer = "";
                

                if (startNumber == 0)
                {
                    Random rnd = new Random();
                    startNumber = rnd.Next(1, 3);
                }

                switch (startNumber)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        player1.PlayerLayoutName(player1.name);
                        Console.ForegroundColor = ConsoleColor.White;
                        player1.PlayerLayout1();
                        Console.ForegroundColor = ConsoleColor.Red;
                        player1.PlayerLayoutSign(player1.sign);
                        Console.ForegroundColor = ConsoleColor.White;
                        player1.PlayerLayout2();
                        Console.ForegroundColor = ConsoleColor.Red;
                        ShowPossibleTurn(possibleturn);
                        Console.ForegroundColor = ConsoleColor.White;
                        playMoveSign = player1.sign;
                        aktivePlayer = player1.name;
                        startNumber++;
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        player1.PlayerLayoutName(player2.name);
                        Console.ForegroundColor = ConsoleColor.White;
                        player1.PlayerLayout1();
                        Console.ForegroundColor = ConsoleColor.Green;
                        player1.PlayerLayoutSign(player2.sign);
                        Console.ForegroundColor = ConsoleColor.White;
                        player1.PlayerLayout2();
                        Console.ForegroundColor= ConsoleColor.Green;
                        ShowPossibleTurn(possibleturn);
                        Console.ForegroundColor = ConsoleColor.White;
                        playMoveSign = player2.sign;
                        aktivePlayer = player2.name;
                        startNumber--;
                        break;
                }

                PlayMoveInput(tabelle, playMoveSign, possibleturn);

                HowToWin(tabelle, aktivePlayer);


                Console.Clear();
                GameLogo();
            }
        }

        private void ShowArray(String[,] tabelle)
        {
            for (int i = 0; i < tabelle.GetLength(0); i++)
            {
                for (int j = 0; j < tabelle.GetLength(1); j++)
                {
                    if (tabelle[i, j] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(tabelle[i, j] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (tabelle[i, j] == "O")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(tabelle[i, j] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(tabelle[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void ShowPossibleTurn(string[] possibleturn)
        {
            for (int i = 0; i < possibleturn.GetLength(0); i++)
            {
                Console.Write(possibleturn[i]);
            }
            Console.WriteLine();
        }

        private void PlayMoveInput(String[,] tabelle, string playMoveSign, string[] possibleTurn)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Gib dein Spielzug ein: ");
                string eingabe = Console.ReadLine();
                string eingabeLow = eingabe.ToLower();

                bool correctinput = true;

                string notEnable = ("ist bereits belegt!");

                switch (eingabeLow)
                {
                    case "1a":
                        if (tabelle[2, 1] != "*")
                        {
                            Console.WriteLine(notEnable);
                            correctinput = false;
                            break;
                        }
                        else
                        {
                            tabelle[2, 1] = playMoveSign;
                            possibleTurn[0] = "";
                            break;
                        }
                    case "2a":
                        if (tabelle[2, 2] != "*")
                        {
                            Console.WriteLine(notEnable);
                            correctinput = false;
                            break;
                        }
                        else
                        {
                            tabelle[2, 2] = playMoveSign;
                            possibleTurn[1] = "";
                            break;
                        }
                    case "3a":
                        if (tabelle[2, 3] != "*")
                        {
                            Console.WriteLine(notEnable);
                            correctinput = false;
                            break;
                        }
                        else
                        {
                            tabelle[2, 3] = playMoveSign;
                            possibleTurn[2] = "";
                            break;
                        }
                    //-----------------------------------------------
                    case "1b":
                        if (tabelle[3, 1] != "*")
                        {
                            Console.WriteLine(notEnable);
                            correctinput = false;
                            break;
                        }
                        else
                        {
                            tabelle[3, 1] = playMoveSign;
                            possibleTurn[3] = "";
                            break;
                        }
                    case "2b":
                        if (tabelle[3, 2] != "*")
                        {
                            Console.WriteLine(notEnable);
                            correctinput = false;
                            break;
                        }
                        else
                        {
                            tabelle[3, 2] = playMoveSign;
                            possibleTurn[4] = "";
                            break;
                        }
                    case "3b":
                        if (tabelle[3, 3] != "*")
                        {
                            Console.WriteLine(notEnable);
                            correctinput = false;
                            break;
                        }
                        else
                        {
                            tabelle[3, 3] = playMoveSign;
                            possibleTurn[5] = "";
                            break;
                        }
                    //------------------------------------------------
                    case "1c":
                        if (tabelle[4, 1] != "*")
                        {
                            Console.WriteLine(notEnable);
                            correctinput = false;
                            break;
                        }
                        else
                        {
                            tabelle[4, 1] = playMoveSign;
                            possibleTurn[6] = "";
                            break;
                        }
                    case "2c":
                        if (tabelle[4, 2] != "*")
                        {
                            Console.WriteLine(notEnable);
                            correctinput = false;
                            break;
                        }
                        else
                        {
                            tabelle[4, 2] = playMoveSign;
                            possibleTurn[7] = "";
                            break;
                        }
                    case "3c":
                        if (tabelle[4, 3] != "*")
                        {
                            Console.WriteLine(notEnable);
                            correctinput = false;
                            break;
                        }
                        else
                        {
                            tabelle[4, 3] = playMoveSign;
                            possibleTurn[8] = "";
                            break;
                        }
                    default:
                        {
                            correctinput = false;
                            Console.WriteLine("Ungültige Eingabe, versuche es erneut! :(");
                            break;
                        }
                }
                if (correctinput)
                    break;
            }
        }

        private void HowToWin(String[,] tabelle, string aktivePlayer)
        {
            Menu nextMenu;
            
            if
            (
            (((tabelle[2, 1].Equals(tabelle[2, 2])) & (tabelle[2, 1].Equals(tabelle[2, 3])))
            & 
            ((tabelle[2, 1] != "*")))
            ||
            (((tabelle[3, 1].Equals(tabelle[3, 2])) & (tabelle[3, 1].Equals(tabelle[3, 3])))
            &
            ((tabelle[3, 1] != "*")))
            ||
            (((tabelle[4, 1].Equals(tabelle[4, 2])) & (tabelle[4, 1].Equals(tabelle[4, 3])))
            &
            ((tabelle[4, 1] != "*")))
            )
            {
                Console.Clear();
                GameLogo();
                ShowArray(tabelle);
                Console.WriteLine("Herzlichen Glückwunsch " + aktivePlayer + ", du hast mit einer horizontalen Reihe gewonnen! :D");
                Console.ReadKey();
                nextMenu = new StartMenu();

            }
            else if
            (
            (((tabelle[2, 1].Equals(tabelle[3, 1])) & (tabelle[2, 1].Equals(tabelle[4, 1])))
            &
            ((tabelle[2, 1] != "*")))
            ||
            (((tabelle[2, 2].Equals(tabelle[3, 2])) & (tabelle[2, 2].Equals(tabelle[4, 2])))
            &
            ((tabelle[2, 2] != "*")))
            ||
            (((tabelle[2, 3].Equals(tabelle[3, 3])) & (tabelle[2, 3].Equals(tabelle[4, 3])))
            &
            ((tabelle[2, 3] != "*")))
            )
            {
                Console.Clear();
                GameLogo();
                ShowArray(tabelle);
                Console.WriteLine("Herzlichen Glückwunsch " + aktivePlayer + ", du hast mit einer vertikal Reihe gewonnen! :D");
                Console.ReadKey();
                nextMenu = new StartMenu();
            }
            else if
            (
            (((tabelle[2, 1].Equals(tabelle[3, 2])) & (tabelle[2, 1].Equals(tabelle[4, 3])))
            &
            ((tabelle[2, 1] != "*")))
            ||
            (((tabelle[2, 3].Equals(tabelle[3, 2])) & (tabelle[2, 3].Equals(tabelle[4, 1])))
            &
            ((tabelle[2, 3] != "*")))
            )
            {
                Console.Clear();
                GameLogo();
                ShowArray(tabelle);
                Console.WriteLine("Herzlichen Glückwunsch " + aktivePlayer + ", du hast mit einer diagonalen Reihe gewonnen! :D");
                Console.ReadKey();
                nextMenu = new StartMenu();
            }
            else if 
            (tabelle[2, 1] != "*" & tabelle[2, 2] != "*" & tabelle[2, 3] != "*"
            & tabelle[3, 1] != "*" & tabelle[3, 2] != "*" & tabelle[3, 3] != "*"
            & tabelle[4, 1] != "*" & tabelle[4, 2] != "*" & tabelle[4, 3] != "*")
            {
                Console.Clear();
                GameLogo();
                ShowArray(tabelle);
                Console.WriteLine("Unentschieden. :)");
                Console.ReadKey();
                nextMenu = new StartMenu();
            }
        }

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
