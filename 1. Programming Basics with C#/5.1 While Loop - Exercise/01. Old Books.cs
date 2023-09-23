using System;

namespace OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int checkCounter = 0;

            while (true)
            {
                string bookCheck = Console.ReadLine();

                if (bookCheck == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {checkCounter} books.");
                    break;
                }
                if (bookCheck == book)
                {
                    Console.WriteLine($"You checked {checkCounter} books and found it.");
                    break;
                }
                checkCounter++;
            }
        }
    }
}