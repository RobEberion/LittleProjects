using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektsammlung.Spiele
{
    internal class Hangman
    {
        static void Main(string[] args)
        {
            MainMenu();

        }

        static void MainMenu()
        {
            while (true)
            {
                PrintHead();

                Console.WriteLine("Wähle eine Aktion aus:");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[1] Spielen");
                Console.WriteLine("[2] Beenden");
                Console.ResetColor();
                Console.WriteLine();

                Console.Write("Aktion: ");

                int action = 0;

                do
                {
                    try
                    {
                        action = Convert.ToInt32(Console.ReadLine());
                        if (action != 1 && action != 2)
                        {

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nur 1 oder 2!");
                            Console.WriteLine();
                            Console.WriteLine("Versuche es erneut!");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        }
                    }
                    catch (Exception)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Du hast nur die Wahl zwischen 1 und 2.");
                        Console.WriteLine();
                        Console.WriteLine("Versuche es erneut!");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                    }
                } while (action != 1 && action != 2);

                bool end = false;

                switch (action)
                {
                    case 1:
                        StartGame();
                        break;

                    case 2:
                        end = true;
                        break;
                }

                if (end)
                {
                    break;
                }

                Console.Clear();
            }

            static void StartGame()
            {
                string[] words = new string[]
                {
                    "Apfelkuchen",
                    "Gemüsesuppe",
                    "Kraftfahrzeug",
                    "Lastwagen",
                    "VideoSpiele",
                    "Reagenzglas",
                    "Briefmarke",
                    "Papierkorb",
                    "Aufenthalt",
                    "Abnehmen",
                    "Wanderung",
                    "Operationssaal",
                    "Telefonbuch",
                    "Kugelschreiber",
                    "Zusammenfassung",
                    "Ziegelsteine",
                    "Krebstier",
                    "Staubsauger",
                    "Sonnensegel",
                    "Konsonanten",
                    "Funktion",
                    "Gleichgewicht",
                    "Thermostat",
                    "Verbrennung",
                    "Viehzucht",
                    "Nachmittag",
                    "Traurigkeit",
                    "Gefrierfach",
                    "Scheinwerfer",
                    "Mittagsschlaf",
                    "Blitzableiter",
                    "Geschlossen",
                    "Zigarettenstummel",
                    "Backenzahn",
                    "Polizeistation",
                    "Bergsteiger",
                    "Lagerfeuer",
                    "Friseursalon",
                    "Himmelsrichtungen",
                    "Leichtathletik",
                    "Sammlung"
                };

                Random rnd = new Random();
                int index = rnd.Next(0, words.Length);
                string word = words[index].ToLower();
                GameLoop(word);

            }

            static void GameLoop(string word)
            {
                int lives = 10;
                string hiddenWord = "";

                for (int i = 0; i < word.Length; i++)
                {
                    hiddenWord += "_";
                }

                while (true)
                {

                    char character = '|';

                    while (character == '|')
                    {
                        Console.Clear();

                        PrintHead();

                        Console.WriteLine($"Gesuchtes Wort: {hiddenWord}");
                        Console.Write("Noch übrige Versuche: ");

                        for (int i = 0; i < lives; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("+");
                            Console.ResetColor();
                        }

                        Console.WriteLine();

                        try
                        {
                            Console.Write("Buchstabe: ");
                            character = Convert.ToChar(Console.ReadLine().ToLower());
                        }
                        catch (FormatException)
                        {                            Console.ForegroundColor = ConsoleColor.Red;                            Console.WriteLine("Nur ein Buchstabe bitte!");
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                    }




                    bool foundCharacterInWord = false;

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == character)
                        {
                            foundCharacterInWord = true;
                            break;
                        }
                    }

                    string tempHiddenWord = hiddenWord;
                    hiddenWord = "";

                    if (foundCharacterInWord)
                    {
                        for (int i = 0; i < word.Length; i++)
                        {
                            if (word[i] == character)
                            {
                                hiddenWord += character;
                            }
                            else if (tempHiddenWord[i] != '_')
                            {
                                hiddenWord += tempHiddenWord[i];
                            }
                            else
                            {
                                hiddenWord += '_';
                            }
                        }

                        if (hiddenWord == word)
                        {
                            Console.Clear();
                            PrintHead();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Gewonnen!!!");
                            Console.WriteLine($"Das Wort war: {word}");
                            Console.ReadKey();
                            Console.ResetColor();
                            break;
                        }

                    }
                    else
                    {
                        hiddenWord = tempHiddenWord;

                        if (lives > 1)
                        {
                            lives -= 1;
                        }
                        else
                        {
                            Console.Clear();
                            PrintHead();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("GAME OVER!!!");
                            Console.ReadKey();
                            Console.ResetColor();
                            break;
                        }

                    }
                }
            }
            static void PrintHead()
            {
                Console.WriteLine("|---------------------------|");
                Console.Write("| O(^-^)=O ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("HANGMAN");
                Console.ResetColor();
                Console.WriteLine(" O=(-.-)O |");
                Console.WriteLine("|---------------------------|");
                Console.WriteLine();
            }
        }
    }
}
