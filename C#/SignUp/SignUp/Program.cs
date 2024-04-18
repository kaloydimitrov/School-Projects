using System;

namespace SignUp
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            while (true)
            {
                string new_username = Console.ReadLine();
                string new_password = Console.ReadLine();

                if (new_username == username && new_password == password)
                {
                    Console.WriteLine($"Welcome {username}");
                    break;
                }

                Console.WriteLine("Wrong user name or password,");
                Console.WriteLine("try again");
            }
        }
    }
}
