using System;

namespace ArchProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string archName = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {archName} will need {projects * 3} hours to complete {projects} project/s.");
        }
    }
}
