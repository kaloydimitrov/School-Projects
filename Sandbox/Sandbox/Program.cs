Console.WriteLine("\n---------------- Задача 1 ----------------\n");

string command = Console.ReadLine();
double biggest_num = int.MinValue;

while (command != "Stop")
{
    double current_num = double.Parse(command);

    if (current_num > biggest_num)
    {
        biggest_num = current_num;
    }

    command = Console.ReadLine();
}

Console.WriteLine($"Biggest number is {biggest_num}");

Console.WriteLine("\n---------------- Задача 2 ----------------\n");

string comm = Console.ReadLine();
int count = 0;

while (comm != "край")
{
    count += 1;
    comm = Console.ReadLine();
}

if (count > 6)
{
    Console.WriteLine("Искаш да си голям пътешественик");
}
else if (count > 3)
{
    Console.WriteLine("Искаш да пътуваш много");
}
else if (count > 0)
{
    Console.WriteLine("Искаш да попътуваш малко");
}

Console.WriteLine("\n---------------- Задача 3 ----------------\n");

string commnd = Console.ReadLine();
double total_sum = 0;

while (commnd != "NoMoreMoney")
{
    if (double.Parse(commnd) < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    Console.WriteLine($"Increase: {commnd}");

    total_sum += double.Parse(commnd);

    commnd = Console.ReadLine();
}

Console.WriteLine($"Total: {total_sum}");
