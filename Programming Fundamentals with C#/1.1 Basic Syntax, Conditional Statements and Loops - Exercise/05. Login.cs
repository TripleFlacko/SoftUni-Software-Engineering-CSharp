using System;

namespace _05.Login
{
    class Program
    {
        static void Main()
        {
            string username = Console.ReadLine();

            char[] userArray = username.ToCharArray();
            Array.Reverse(userArray);
            string usernameReversed = new string(userArray);
            int counter = 0;

            while (true)
            {
                string password = Console.ReadLine();

                if (password == usernameReversed)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                    counter++;
                }
            }
        }
    }
}