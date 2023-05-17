using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double timeHeSwimmed = meters * time + (Math.Floor(meters / 15) * 12.5);

            if (record > timeHeSwimmed)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeHeSwimmed:f2} seconds.");
            }

            else if (record <= timeHeSwimmed)
            {
                double timeNeeded = Math.Abs(record - timeHeSwimmed);
                Console.WriteLine($"No, he failed! He was {timeNeeded:f2} seconds slower.");
            }
        }
    }
}