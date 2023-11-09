using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorCyclists = int.Parse(Console.ReadLine());
            int seniorOldCyclists = int.Parse(Console.ReadLine());
            string typeOfRoad = Console.ReadLine();

            double moneyGathered = 0;

            switch (typeOfRoad)
            {
                case "trail": moneyGathered = juniorCyclists * 5.50 + seniorOldCyclists * 7; break;
                case "cross-country":
                    moneyGathered = juniorCyclists * 8 + seniorOldCyclists * 9.50;
                    if (juniorCyclists + seniorOldCyclists >= 50)
                    {
                        moneyGathered *= 0.75;
                    }
                    break;
                case "downhill": moneyGathered = juniorCyclists * 12.25 + seniorOldCyclists * 13.75; break;
                case "road": moneyGathered = juniorCyclists * 20 + seniorOldCyclists * 21.50; break;
            }
            moneyGathered *= 0.95;
            Console.WriteLine($"{moneyGathered:f2}");
        }
    }
}