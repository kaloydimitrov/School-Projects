using System;

namespace ClassesAndObjects01
{
    class Program
    {
        public class Car
        { 
            public string brand;
            public string model;
            public int engineVolume;
            public int yearProd;
        }

        static void Main(string[] args)
        {
            Car myCar = new Car();
            Console.Write("Въведете марка: ");
            myCar.brand = Console.ReadLine();

            Console.Write("Въведете модел: ");
            myCar.model = Console.ReadLine();

            Console.Write("Въведете обем на двигателя: ");
            myCar.engineVolume = int.Parse(Console.ReadLine());

            Console.Write("Въведете година на производство: ");
            myCar.yearProd = int.Parse(Console.ReadLine());

            double annualTax = 0.2 * myCar.engineVolume;
            if (myCar.yearProd <= 2000) {
                annualTax += 70.00;
            }
            else if (myCar.yearProd <= 2010) {
                annualTax += 60.00;
            }
            else {
                annualTax += 50.00;
            }

            Console.WriteLine("Данъкът на {0}, {1}", myCar.brand, myCar.model);
            Console.WriteLine("с обем на двигателя {0}", myCar.engineVolume);
            Console.WriteLine("произведена през {0} година", myCar.yearProd);
            Console.WriteLine("e {0, 6:###00} лева.", annualTax);
        }
    }
}
