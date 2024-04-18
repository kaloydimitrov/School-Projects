using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Числа: "); int times = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < times; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers.Insert(0, currentNumber);
            }

            Console.WriteLine("-----------------------------------------------");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
