using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            IList<int> scoreSystem = new List<int>();
            int counter = 0;
            while(counter <= 21)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                if (value == 10 && counter != 21) 
                {
                    counter += 2;
                }
                else
                {
                    counter++;
                }

                scoreSystem.Add(value);
            }
            GameTenPin gtp = new GameTenPin();

            foreach (var item in scoreSystem)
            {
                gtp.roll(item);
            }

            Console.WriteLine($"Game score - { gtp.score()}");
            Console.ReadLine();

        }
    }
}
