using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentTickets = 0, standardTickets = 0, kidTickets = 0;
            while (true)
            {
                string movie = Console.ReadLine();
                int counter = 0;

                if (movie == "Finish")
                {
                    double totalTickets = studentTickets + standardTickets + kidTickets;

                    double studentPercentage = studentTickets / totalTickets;
                    double standardPercentage = standardTickets / totalTickets;
                    double kidPercentage = kidTickets / totalTickets;

                    Console.WriteLine($"Total tickets: {totalTickets}\n{studentPercentage:p2} student tickets.\n{standardPercentage:p2} standard tickets.\n{kidPercentage:p2} kids tickets.");

                    break;
                }

                int freeSeats = int.Parse(Console.ReadLine());

                for (int i = 1; i <= freeSeats; i++)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        i -= 1;
                        double fullness = i / (double)freeSeats;
                        Console.WriteLine($"{movie} - {fullness:p2} full.");
                        break;
                    }

                    if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTickets++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTickets++;
                    }

                    if (i == freeSeats)
                    {
                        double fullness = i / (double)freeSeats;
                        Console.WriteLine($"{movie} - {fullness:p2} full.");
                        break;
                    }
                }
            }
        }
    }
}