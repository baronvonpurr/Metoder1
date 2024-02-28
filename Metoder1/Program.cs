using System;

namespace Metoder1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Skriv in ett tal");
                tal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Summan är: " + Addera(tal[0], tal[1], tal[2]));
        }

        static int Addera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }
    }
}