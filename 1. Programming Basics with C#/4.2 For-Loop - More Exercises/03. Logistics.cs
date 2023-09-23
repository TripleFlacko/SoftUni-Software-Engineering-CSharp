using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLoads = int.Parse(Console.ReadLine());

            double totalTons = 0;
            double totalMoney = 0;

            double microbus = 0;
            double truck = 0;
            double train = 0;

            for (int i = 0; i < numberLoads; i++)
            {
                int tons = int.Parse(Console.ReadLine());
                totalTons += tons;

                if (tons <= 3)
                {
                    microbus += tons;
                }
                else if (tons <= 11)
                {
                    truck += tons;
                }
                else if (tons >= 12)
                {
                    train += tons;
                }
            }

            double averagePrice = (microbus * 200 + truck * 175 + train * 120) / totalTons;
            double microbusPercentage = microbus / totalTons;
            double truckPercentage = truck / totalTons;
            double trainPercentage = train / totalTons;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{microbusPercentage:p2}");
            Console.WriteLine($"{truckPercentage:p2}");
            Console.WriteLine($"{trainPercentage:p2}");
        }
    }
}