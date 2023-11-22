using System;
using System.Diagnostics.CodeAnalysis;

namespace uppgfit_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Skrv in tal "+ (i+1) +" av 3.");
                tal[i] = int.Parse(Console.ReadLine());
            }
            int sum = tal[0] + tal[1] + tal[2];
            Console.WriteLine("Summan av talen blir "+ sum);
            Console.ReadKey();
        }
    }
}
