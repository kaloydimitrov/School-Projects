using System;

namespace Methods05
{
    class Program
    {
        static int smallestNumber(int x, int y, int z)
        {
            int smallest = 0;

            if (x <= y && x <= z)
                smallest = x;
            if (y <= x && y <= z)
                smallest = y;
            if (z <= x && z <= y)
                smallest = z;

            return smallest;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(smallestNumber(1, 2, 3));
        }
    }
}
