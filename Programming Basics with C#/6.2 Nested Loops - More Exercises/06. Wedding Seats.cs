using System;

namespace _06._Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            string sector = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());

            int counter = 0;
            int counterSeatsOdd = 0;
            int counterSeatsEven = 0;

            for (char i = 'A'; i <= char.Parse(sector); i++)
            {
                for (int i2 = 1; i2 <= rows; i2++)
                {
                    if (i2 % 2 != 0)
                    {
                        for (char i3 = 'a'; i3 <= 'z'; i3++)
                        {
                            if (counter == seats)
                            {
                                counter = 0;
                                break;
                            }
                            Console.WriteLine($"{i}{i2}{i3}");
                            counterSeatsOdd++;
                            counter++;
                        }
                    }
                    else
                    {
                        for (char i3 = 'a'; i3 <= 'z'; i3++)
                        {
                            if (counter == seats + 2)
                            {
                                counter = 0;
                                break;
                            }
                            Console.WriteLine($"{i}{i2}{i3}");
                            counterSeatsEven++;
                            counter++;
                        }
                    }
                }

                rows++;
            }

            Console.WriteLine($"{counterSeatsEven + counterSeatsOdd}");
        }
    }
}