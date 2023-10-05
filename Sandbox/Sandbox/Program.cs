double a, b, c, P, p, S;

a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());

P = a + b + c;
p = P / 2;
S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

Console.WriteLine(S);
