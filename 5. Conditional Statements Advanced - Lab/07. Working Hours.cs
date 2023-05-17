using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if ((10 <= time && time < 18) && (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday"))
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }

        }
    }
}