using System;

namespace Yard
{
    class Program
    {
        static void Main(string[] args)
        {
            double yard = double.Parse(Console.ReadLine());

            double price = yard * 7.61;
            double discount = price * 0.18;

            Console.WriteLine($"The final price is: {price - discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
