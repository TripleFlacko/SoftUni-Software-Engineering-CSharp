using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string pass = Console.ReadLine();
            string passVerification = "";


            while (pass != passVerification)
            {
                passVerification = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}