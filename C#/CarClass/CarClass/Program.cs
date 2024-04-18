using System;

namespace CarClass
{
    class Engine
    {
        public int volume;
        public int power;

        public Engine(int newVolume, int newPower)
        {
            this.volume = newVolume;
            this.power = newPower;
        }
    }

    class Car
    {
        private string brand;
        private string model;
        private Engine engine; 

        public Car()
        {
            this.brand = "Не е въведена марка!";
            this.model = "Не е въведен модел!";
            Engine newEngine = new Engine(0, 0);
            engine = newEngine;
        }

        public Car(Car currentCar)
        {
            this.brand = currentCar.brand;
            this.model = currentCar.model;
            Engine newEngine = new Engine(0, 0);
            engine = newEngine;
        }

        public Car(string newBrand, string newModel, Engine newEngine)
        {
            this.Brand = newBrand;
            this.Model = newModel;
            this.engine = newEngine;
        }

        public string Brand
        {
            get { return this.brand; }
            set
            {
                this.brand = value;
            }
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                this.model = value;
            }
        }
        public void printInformation()
        {
            Console.WriteLine($"Brand: {this.Brand}\nModel: {this.Model}\nEngine Volume: {this.engine.volume}\nEngine Power: {this.engine.power}");
        }

        public void changeRef(ref Engine currentEngine)
        {
            Engine newEngine = new Engine(5, 600);
            currentEngine = newEngine;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------ Първа кола ------------------------");
            Engine firstCarEngine = new Engine(200, 300);
            Car firstCar = new Car("BMW", "X1", firstCarEngine);
            firstCar.printInformation();

            Console.WriteLine("------------------------ Втора кола ------------------------");
            Car secondCar = new Car();
            secondCar.printInformation();

            Console.WriteLine("------------------------ Трета кола ------------------------");
            Car thirdCar = new Car(firstCar);
            thirdCar.printInformation();

            Console.WriteLine("------------------------ Четвърта кола ------------------------");
            Engine fourthCarEngine = new Engine(400, 600);
            Car fouthCar = new Car("Toyota", "Supra", fourthCarEngine);
            fouthCar.printInformation();
            fouthCar.changeRef(ref fourthCarEngine);
            fouthCar.printInformation();
        }
    }
}