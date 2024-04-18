using System;

namespace Arrays3
{
    class Program
    {
        static int countElements(int[] arr, int el)
        {
            int count = 0;

            foreach (int element in arr)
            {
                if (element == el)
                {
                    count++;
                }
            }

            return count;
        } 

        static bool checkElement(int[] arr, int el)
        {
            foreach (int element in arr)
            {
                if (element == el)
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            Console.Write("Колко елемента да има в масива?: "); int elements = int.Parse(Console.ReadLine());
            int[] array = new int[elements];

            for (int index = 0; index < elements; index++)
            {
                Console.Write($"Число {index + 1}: "); array[index] = int.Parse(Console.ReadLine());
            }

            Console.Write($"Кое число да проверим дали съществува?: "); 
        }
    }
}
