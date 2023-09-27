int[,] matrix = { { 1, 2, 3, 4 }, { 3, 5, 6, 9 }, { 1, 2, 3, 4 } };

for (int r = 0; r < matrix.GetLength(0); r++)
{
    for (int c = 0; c < matrix.GetLength(1); c++)
    {
        Console.Write(matrix[r, c]);
    }
    Console.WriteLine();
}

Console.WriteLine("\n-------------------- Задача 0 --------------------\n");

int a1 = 3;
int b1;
b1 = a1++;

Console.WriteLine(a1);
Console.WriteLine(b1);

Console.WriteLine();

int a2 = 3;
int b2;
b2 = ++a2;

Console.WriteLine(a2);
Console.WriteLine(b2);

Console.WriteLine();

int a3 = 3;
int b3 = 5;
a3--;
b3++;
b3 = a3++ + b3;

Console.WriteLine(a3);
Console.WriteLine(b3);

Console.WriteLine();

int a4 = 3;
int b4 = 5;
a4--;
++b4;
a4 = a4 + b4;

Console.WriteLine(a4);
Console.WriteLine(b4);

Console.WriteLine("\n-------------------- Задача 1 --------------------\n");

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n-------------------- Задача 2 --------------------\n");

string star = "*";

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(star);
    star += "*";
}

Console.WriteLine("\n-------------------- Задача 3 --------------------\n");

for (int letter = 'a'; letter <= 'z'; letter++)
{
    Console.WriteLine(letter);
}

Console.WriteLine("\n-------------------- Задача 4 --------------------\n");

Console.Write($"Numbers: ");
int num = int.Parse(Console.ReadLine());
double sum = 0;

for (int i = 0; i < num; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    string userInput = Console.ReadLine();
    sum += double.Parse(userInput);
}

Console.WriteLine($"The sum of these numbers is: {sum}");

Console.WriteLine("\n-------------------- Задача 5 --------------------\n");

Console.Write($"Numbers: ");
int loops = int.Parse(Console.ReadLine());
int biggest_number = int.MinValue;


for (int i = 0; i < loops; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    int userInput = int.Parse(Console.ReadLine());
    
    if (userInput > biggest_number)
    {
        biggest_number = userInput;
    }
}

Console.WriteLine($"Biggest number is: {biggest_number}");

Console.WriteLine("\n-------------------- Задача 6 --------------------\n");

Console.Write($"Numbers: ");
int nums = int.Parse(Console.ReadLine());
int lowest_number = int.MaxValue;


for (int i = 0; i < nums; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    int userInput = int.Parse(Console.ReadLine());

    if (userInput < lowest_number)
    {
        lowest_number = userInput;
    }
}

Console.WriteLine($"Lowest number is: {lowest_number}");

Console.WriteLine("\n-------------------- Задача 7 --------------------\n");

List<int> numbers_seven = new List<int>();

for (int numbr = 1; numbr <= 300; numbr++)
{
    if (numbr % 10 == 7)
    {
        numbers_seven.Add(numbr);
    }
}

Console.WriteLine("Numbers that end with '7':");
foreach (int numbr in numbers_seven)
{
    Console.Write($"({numbr}) ");
}
