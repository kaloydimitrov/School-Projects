using System;

namespace Methods
{
    class Program
    {
        static int biggerN(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(biggerN(1, 2));
        }
    }
}
