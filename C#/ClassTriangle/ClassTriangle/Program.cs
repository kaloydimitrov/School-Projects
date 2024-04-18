using System;

namespace ClassTriangle
{
    class Program
    {
        class Triangle
        {
            public double Area(double a, double b, double c)
            {
                double p = (a + b + c) / 2.0;
                return Math.Sqrt(p * (p-a) * (p-b) * (p-c));
            }
            public double Area(float a, double b, double angle)
            {
                return a * b * Math.Sin(angle) / 2;
            }
            public double Area(double a, double h)
            {
                return a * h / 2.0;
            }
            public double Area(double a, double b, double c, double R)
            {
                return a * b * c / (double)(4 * R);
            }
            public double Area(float a, double b, double c, double r)
            {
                double p = (a + b + c) / 2;
                return p * r;
            }
        }

        static void Main(string[] args)
        {
            double a = 6;
            double b = 8;
            double c = 10;
            double h = 8;
            double R = 5;
            double r = 2;
            double α = 1.5707963267948966;

            Triangle t1 = new Triangle();
            
            
            double area = t1.Area(a, b, c, r);
            Console.WriteLine(area);
        }
    }
}
