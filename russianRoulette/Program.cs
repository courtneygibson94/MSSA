using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace russianRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] green = {0};
            int[] red = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31 };
            int[] black = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32 };
            Random random = new Random();

            Console.WriteLine("How many times would you like to spine the wheel");
            int spins = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < spins; i++)
            {
                int color = random.Next(0, 3);
                if (color == 0)
                {
                    System.Threading.Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("green 0");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                    
                else if (color == 1)
                {
                    System.Threading.Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"red:{red[random.Next(red.Length)]}");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else if (color == 2)
                {
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine($"Black:{black[random.Next(red.Length)]}");

                }
            }
            



        }
    }
}
