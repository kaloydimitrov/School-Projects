using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;

            Console.Write("Въведи a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Въведи b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Въведи c: ");
            c = double.Parse(Console.ReadLine());
            Console.Write("Въведи d: ");
            d = double.Parse(Console.ReadLine());

            Console.WriteLine(c <= b && b <= d || c <= a && a <= d);
        }
    }
}
