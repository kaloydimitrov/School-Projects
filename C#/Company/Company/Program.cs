using System;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 130.0;
            double g = 2010;

            while (x >= 10)
            {
                x *= 0.9;
                g += 1;
            }

            Console.WriteLine(g);
        }
    }
}
