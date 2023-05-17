using System;

namespace Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = 15 + int.Parse(Console.ReadLine());

            if (minutes >= 60)
            {
                int minutesFinal = minutes - 60;
                int hoursFinal = hours + 1;

                if (hoursFinal >= 24)
                {
                    int hoursFinal2 = hoursFinal - 24;

                    if (minutesFinal >= 10)
                    {
                        Console.WriteLine($"{hoursFinal2}:{minutesFinal}");
                    }

                    else
                    {
                        Console.WriteLine($"{hoursFinal2}:0{minutesFinal}");
                    }
                }

                else if (minutesFinal >= 10)
                {
                    Console.WriteLine($"{hoursFinal}:{minutesFinal}");
                }

                else
                {
                    Console.WriteLine($"{hoursFinal}:0{minutesFinal}");
                }
            }

            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}