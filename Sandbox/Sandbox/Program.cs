Console.Write("Страна A: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Страна B: ");
double b = double.Parse(Console.ReadLine());

if ((a > 0) && (b > 0))
{
    Console.WriteLine($"Периметър: {(a + b) * 2}");
    Console.WriteLine($"Лице: {a * b}");
}
else
{
    Console.WriteLine("Трябва А и B да се по-големи от 0!");
}
