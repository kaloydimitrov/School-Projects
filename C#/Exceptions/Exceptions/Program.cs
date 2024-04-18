using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            // 	int number = int.Parse(Console.ReadLine());

            // 	if (number < 0)
            // 	{
            // 		throw new Exception("По-малко е от 0!");
            // 	}
            // }
            // catch (Exception e)
            // {
            // 	Console.WriteLine(e.Message);
            // }
            // finally
            // {
            // 	Console.WriteLine("Винаги ще се изпълни!");
            // }


            // TODO: try, catch, exception


            string stringInput = Console.ReadLine();
            string[] stringArray = stringInput.Split(" ");

            int exceptionsCount = 0;

            while (true)
            {
                string currentCommand = Console.ReadLine();
                string[] commandArray = currentCommand.Split(" ");

                if (currentCommand.Contains("Replace"))
                {
                    int index = int.Parse(commandArray[1]);
                    string element = commandArray[2];

                    stringArray[index] = element;
                }
                else if (currentCommand.Contains("Print"))
                {
                    int start = int.Parse(commandArray[1]);
                    int end = int.Parse(commandArray[2]);

                    List<string> newList = new List<string>();

                    for (int i = start; i <= end; i++)
                    {
                        newList.Add(stringArray[i]);
                    }

                    Console.WriteLine(string.Join(", ", newList));
                }
                else if (currentCommand.Contains("Show"))
                {
                    int index = int.Parse(commandArray[1]);

                    Console.WriteLine(stringArray[index]);
                }
            }
            
        }
    }
}
