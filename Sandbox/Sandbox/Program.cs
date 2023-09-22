Console.Write("Enter your grade: ");
double grade = Double.Parse(Console.ReadLine());

if (grade >= 5.50)
{
    Console.WriteLine("Excellent!");
}
else
{
    Console.WriteLine("Try Harder!");
}

Console.WriteLine("-------------------------------------");

Console.Write("First number: ");
int first_number = int.Parse(Console.ReadLine());
Console.Write("Second number: ");
int second_number = int.Parse(Console.ReadLine());

if (first_number > second_number)
{
    Console.WriteLine(first_number);
}
else if (second_number > first_number)
{
    Console.WriteLine(second_number);
}
else
{
    Console.WriteLine("Numbers are equal!");
}

Console.WriteLine("-------------------------------------");

int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}
