using System;

namespace Methods01
{
    class Program
    {
        static string getGrades(double grade)
        {
            string returnGrade = String.Empty;

            if (grade >= 2.00 && grade <= 2.99)
            {
                returnGrade = "Fail";
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                returnGrade = "Poor";
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                returnGrade = "Good";
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                returnGrade = "Very good";
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                returnGrade = "Excellent";
            }

            return returnGrade;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(getGrades(2.99));
        }
    }
}
