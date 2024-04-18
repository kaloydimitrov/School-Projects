using System;

namespace Methods04
{
    class Program
    {
        static int calc(int num1, string sign, int num2)
        {
            int result = 0;

            switch (sign)
            {
                case "/":
                    result = num1 / num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
            }

            return result;

        }

        static void Main(string[] args)
        {
            Console.WriteLine(calc(2, "*", 2));
        }
    }
}
