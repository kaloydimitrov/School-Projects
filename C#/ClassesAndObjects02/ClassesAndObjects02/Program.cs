using System;

namespace ClassesAndObjects02
{
    public class Student
    {
        public string clas;
        public string id;
        public string name;

        private double dBEL, dForeign, dMath, dPhys, dChem, dBio;

        public double Average
        {
            get { return (this.dBEL + this.dForeign + this.dMath + this.dPhys + this.dChem + this.dBio) / 6; }
            set { Console.WriteLine("You can't set an average!"); }
        }

        public double BEL
        {
            get { return this.dBEL; }
            set { 
                if (value >= 2 && value <= 6) { this.dBEL = value; }
                else { Console.WriteLine($"{value} is invalid grade!"); }
            }
        }

        public double Foreign
        {
            get { return this.dForeign; }
            set
            {
                if (value >= 2 && value <= 6) { this.dForeign = value; }
                else { Console.WriteLine($"{value} is invalid grade!"); }
            }
        }

        public double Math
        {
            get { return this.dMath; }
            set
            {
                if (value >= 2 && value <= 6) { this.dMath = value; }
                else { Console.WriteLine($"{value} is invalid grade!"); }
            }
        }

        public double Phys
        {
            get { return this.dPhys; }
            set
            {
                if (value >= 2 && value <= 6) { this.dPhys = value; }
                else { Console.WriteLine($"{value} is invalid grade!"); }
            }
        }

        public double Chem
        {
            get { return this.dChem; }
            set
            {
                if (value >= 2 && value <= 6) { this.dChem = value; }
                else { Console.WriteLine($"{value} is invalid grade!"); }
            }
        }

        public double Bio
        {
            get { return this.dBio; }
            set
            {
                if (value >= 2 && value <= 6) { this.dBio = value; }
                else { Console.WriteLine($"{value} is invalid grade!"); }
            }
        }

        public void getRemark()
        {
            Console.WriteLine("\n---------------------- С П Р А В К А ----------------------");
            Console.WriteLine($"За уcпexa на {this.name} (ученик от {this.clas}; № {this.id}):");
            Console.WriteLine("БEЛ          | {0,4:0.00}", this.BEL);
            Console.WriteLine("Чужд език    | {0,4:0.00}", this.Foreign);
            Console.WriteLine("Maтематика   | {0,4:0.00}", this.Math);
            Console.WriteLine("Физика       | {0,4:0.00}", this.Phys);
            Console.WriteLine("Xимия        | {0,4:0.00}", this.Chem);
            Console.WriteLine("Биология     | {0,4:0.00}", this.Bio);
            Console.WriteLine("Среден успех | {0,4:0.00}", this.Average);
        }

        public void changeInfo()
        {
            Console.Write("Въведете име: "); this.name = Console.ReadLine();
            Console.Write("Въведете клас: "); this.clas = Console.ReadLine();
            Console.Write("Въведете номер: "); this.id = Console.ReadLine();

            Console.Write("Оценка БЕЛ: "); this.BEL = double.Parse(Console.ReadLine());
            Console.Write("Оценка Чужд език: "); this.Foreign = double.Parse(Console.ReadLine());
            Console.Write("Оценка Математика: "); this.Math = double.Parse(Console.ReadLine());
            Console.Write("Оцrнка Физика: "); this.Phys = double.Parse(Console.ReadLine());
            Console.Write("Оценка Химия: "); this.Chem = double.Parse(Console.ReadLine());
            Console.Write("Оценка Биобогия: "); this.Bio = double.Parse(Console.ReadLine());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.changeInfo();
            std.getRemark();
        }
    }
}