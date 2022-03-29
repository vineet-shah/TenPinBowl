using System;
using System.Collections.Generic;

namespace TenPinBowl
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the game frame points.");
            Console.WriteLine("Strike = 10");
            Console.WriteLine("None pins striked = 0 ");
            Console.WriteLine("");

            // int[] scoreSystem = new int[] { 10, 9, 1, 5, 5, 7, 2, 10, 10, 10, 9, 0, 8, 2, 9, 1, 10 };
            GameTenPin gtp = new GameTenPin();
            int counter = 0, LastframeValue = 0; 
            while(counter < 21)
            {
                if (LastframeValue < 10 && counter == 20)
                {
                    break;
                }

                Console.WriteLine($"Cumilative Roll - {counter + 1}");
                int value = Convert.ToInt32(Console.ReadLine());
                if(counter >= 18)
                {
                    LastframeValue += value;
                }
                if (value == 10 && counter != 21) 
                {
                    counter += 2;
                }
                else
                {
                    counter++;
                }

                gtp.roll(value);
            }

            Console.WriteLine($"Game score - { gtp.score()}");
            Console.ReadLine();

        }
    }
}
