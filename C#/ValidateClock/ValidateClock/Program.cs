Console.Write("Hours: ");
int hours = int.Parse(Console.ReadLine());
Console.Write("Minutes: ");
int minutes = int.Parse(Console.ReadLine());

if ((hours >= 0 && hours <= 23) && (minutes >= 0 && minutes <= 59))
{
    Console.WriteLine($"{hours}:{minutes}");
}
else
{
    Console.WriteLine("Not valid minutes or hours!");
}