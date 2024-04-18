using System;

namespace Conditions3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Не");
            }
        }
    }
}
