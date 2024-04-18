using System;
using System.Text.RegularExpressions;

namespace ClassesAndObjects04
{
    class Person {
        private string name;
        private int age;

        public string Name
        {
            get { return this.name; }
            set {
                if (Regex.IsMatch(value, @"^[a-zA-Z]+$") && Regex.IsMatch(value.Substring(0, 1), @"^[A-Z]+$"))
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine($"{value} in not a valid name!");
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine($"{value} is not a valid age!");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person();
            newPerson.Name = "Kaloyan";
            newPerson.Age = 100;
        }
    }
}