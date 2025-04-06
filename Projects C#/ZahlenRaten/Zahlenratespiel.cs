//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Projektsammlung.Spiele
//{
//    internal class Zahlenratespiel
//    {
//        static void Main(string[] args)
//        {
//            int MinValue = 0;
//            int MaxValue = 1000;
//            int Again = 1;

//            Random rnd = new Random();
//            int RandomNumber = rnd.Next(MinValue, MaxValue);
//            //Console.WriteLine(RandomNumber);

//            Console.WriteLine($"Hallo, ich merke mir eine Zahl zwischen {MinValue} und {MaxValue}.");
//            Console.WriteLine("Was ist meine Zahl?");
//            int Number = Convert.ToInt32(Console.ReadLine());

//            while (Number != RandomNumber)
//            {
//                Again++;

//                if ((Number < RandomNumber) && ((RandomNumber - Number) >= 300))
//                {
//                    Console.WriteLine("Die Zahl ist sehr viel größer!");
//                    Number = Convert.ToInt32(Console.ReadLine());
//                }
//                else if ((Number < RandomNumber) && ((RandomNumber - Number) >= 150))
//                {
//                    Console.WriteLine("Die Zahl ist viel größer!");
//                    Number = Convert.ToInt32(Console.ReadLine());
//                }
//                else if ((Number < RandomNumber) && ((RandomNumber - Number) >= 50))
//                {
//                    Console.WriteLine("Die Zahl ist größer!");
//                    Number = Convert.ToInt32(Console.ReadLine());
//                }
//                else if ((Number < RandomNumber) && ((RandomNumber - Number) >= 10))
//                {
//                    Console.WriteLine("Die Zahl ist ein bisschen größer!");
//                    Number = Convert.ToInt32(Console.ReadLine());
//                }
//                else if ((Number < RandomNumber) && ((RandomNumber - Number) < 10))
//                {
//                    Console.WriteLine("Die Zahl ist ein kleines bisschen größer!");
//                    Number = Convert.ToInt32(Console.ReadLine());
//                }
//                else if ((Number > RandomNumber) && ((Number - RandomNumber) >= 300))
//                {
//                    Console.WriteLine("Die Zahl ist sehr viel kleiner!");
//                    Number = Convert.ToInt32(Console.ReadLine());
//                }
//                else if ((Number > RandomNumber) && ((Number - RandomNumber) >= 150))
//                {
//                    Console.WriteLine("Die Zahl ist viel kleiner!");
//                    Number = Convert.ToInt32(Console.ReadLine());
//                }
//                else if ((Number > RandomNumber) && ((Number - RandomNumber) >= 50))
//                {
//                    Console.WriteLine("Die Zahl ist kleiner!");
//                    Number = Convert.ToInt32(Console.ReadLine());
//                }
//                else if ((Number > RandomNumber) && ((Number - RandomNumber) >= 10))
//                {
//                    Console.WriteLine("Die Zahl ist ein bisschen kleiner!");
//                    Number = Convert.ToInt32(Console.ReadLine());
//                }
//                else if ((Number > RandomNumber) && ((Number - RandomNumber) < 10))
//                {
//                    Console.WriteLine("Die Zahl ist ein kleines bisschen kleiner!");
//                    Number = Convert.ToInt32(Console.ReadLine());
//                }

//            }

//            Console.WriteLine($"Herzlichen Glückwunsch!!! Die Zahl {RandomNumber} ist richtig, du hast {Again} Versuche gebraucht. :) ");
//            Console.ReadKey();
//        }
//    }
//}
