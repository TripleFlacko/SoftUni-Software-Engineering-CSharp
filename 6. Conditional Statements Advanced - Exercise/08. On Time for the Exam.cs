using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExamStart = int.Parse(Console.ReadLine());
            int minuteExamStart = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minuteArrive = int.Parse(Console.ReadLine());

            int timeExam = hourExamStart * 60 + minuteExamStart;
            int timeArrive = hourArrive * 60 + minuteArrive;
            double differenceMinutes = timeExam - timeArrive;
            int differenceHours = 0;

            switch (Math.Floor(Math.Abs(differenceMinutes) / 60))
            {
                case 1: differenceHours = 1; break;
                case 2: differenceHours = 2; break;
                case 3: differenceHours = 3; break;
                case 4: differenceHours = 4; break;
                case 5: differenceHours = 5; break;
                case 6: differenceHours = 6; break;
                case 7: differenceHours = 7; break;
                case 8: differenceHours = 8; break;
                case 9: differenceHours = 9; break;
                case 10: differenceHours = 10; break;
                case 11: differenceHours = 11; break;
                case 12: differenceHours = 12; break;
                case 13: differenceHours = 13; break;
                case 14: differenceHours = 14; break;
                case 15: differenceHours = 15; break;
                case 16: differenceHours = 16; break;
                case 17: differenceHours = 17; break;
                case 18: differenceHours = 18; break;
                case 19: differenceHours = 19; break;
                case 20: differenceHours = 20; break;
                case 21: differenceHours = 21; break;
                case 22: differenceHours = 22; break;
                case 23: differenceHours = 23; break;
            }

            if (differenceMinutes == 0)
            {
                Console.WriteLine("On time");
            }
            else if (differenceMinutes <= 0 && differenceMinutes > -60)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{Math.Abs(differenceMinutes)} minutes after the start");
            }
            else if (differenceMinutes <= -60 && differenceMinutes > -70)
            {
                differenceMinutes = Math.Abs(differenceMinutes);
                differenceMinutes %= 60;
                Console.WriteLine("Late");
                Console.WriteLine($"{differenceHours}:0{differenceMinutes} hours after the start");
            }
            else if (differenceMinutes <= -70)
            {
                if (Math.Abs(differenceMinutes) % 60 == 0 || Math.Abs(differenceMinutes) % 60 < 10)
                {
                    differenceMinutes = Math.Abs(differenceMinutes);
                    differenceMinutes %= 60;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{differenceHours}:0{differenceMinutes} hours after the start");
                }
                else
                {
                    differenceMinutes = Math.Abs(differenceMinutes);
                    differenceMinutes %= 60;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{differenceHours}:{differenceMinutes} hours after the start");
                }
            }
            else if (0 < differenceMinutes && differenceMinutes <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{differenceMinutes} minutes before the start");
            }
            else if (30 < differenceMinutes && differenceMinutes < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{differenceMinutes} minutes before the start");
            }
            else if (60 <= differenceMinutes && differenceMinutes < 70)
            {
                differenceMinutes %= 60;
                Console.WriteLine("Early");
                Console.WriteLine($"{differenceHours}:0{differenceMinutes} hours before the start");
            }
            else if (70 <= differenceMinutes)
            {
                if (differenceMinutes % 60 == 0 || differenceMinutes % 60 < 10)
                {
                    differenceMinutes %= 60;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{differenceHours}:0{differenceMinutes} hours before the start");
                }
                else
                {
                    differenceMinutes %= 60;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{differenceHours}:{differenceMinutes} hours before the start");
                }
            }
        }
    }
}