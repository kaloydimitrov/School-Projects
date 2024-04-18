using System;

namespace Conditions2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            if (n > 0)
            {
                Console.WriteLine($"S: {n * n}");
                Console.WriteLine($"P: {n * 4}");
            }
        }
    }
}
