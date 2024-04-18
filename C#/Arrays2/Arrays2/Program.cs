using System;
using System.Collections.Generic;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Брой числа: "); int times = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = 0; i < times; i++)
            {
                Console.Write($"Число {i + 1}: "); int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
                
                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }

                numbers.Insert(0, currentNumber);
            }

            Console.WriteLine("-----------------------------------------------");

            int maxNumberCount = 0;
            int minNumberCount = 0;

            foreach (int number in numbers)
            {
                if (number == maxNumber)
                {
                    maxNumberCount++;
                } 
                
                if (number == minNumber)
                {
                    minNumberCount++;
                }
            }

            Console.WriteLine($"Най-голямо число: {maxNumber} (среща се {maxNumberCount} пъти)");
            Console.WriteLine($"Най-малко число: {minNumber} (среща се {minNumberCount} пъти)");
        }
    }
}
