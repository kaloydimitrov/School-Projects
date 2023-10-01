double eps = 0.001;
double a = double.Parse(Console.ReadLine());
double x = a / 2;


while (true)
{
    double xs = x;
    x = (x + a / x) / 2;

    if ((xs - x) < eps)
    {
        break;
    }

    Console.WriteLine(x);
}
