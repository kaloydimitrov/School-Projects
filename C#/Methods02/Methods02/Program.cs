using System;

namespace Methods02
{
    class Program
    {
        static string positiveOrNor(int number)
        {
            if (number > 0)
            {
                return $"The number {number} is positive.";
            }
            else if (number < 0)
            {
                return $"The number {number} is negative.";
            }
            else
            {
                return $"The number {number} is zero.";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(positiveOrNor(1));
            Console.WriteLine(positiveOrNor(-1));
            Console.WriteLine(positiveOrNor(0));
        }
    }
}
