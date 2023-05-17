using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double salesVolume = double.Parse(Console.ReadLine());
            double commission = 0;

            switch (town)
            {
                case "Sofia":
                    if (0 <= salesVolume && salesVolume <= 500)
                    {
                        commission = salesVolume * 0.05;
                    }
                    else if (500 < salesVolume && salesVolume <= 1000)
                    {
                        commission = salesVolume * 0.07;
                    }
                    else if (1000 < salesVolume && salesVolume <= 10000)
                    {
                        commission = salesVolume * 0.08;
                    }
                    else if (salesVolume > 10000)
                    {
                        commission = salesVolume * 0.12;
                    }
                    break;

                case "Varna":
                    if (0 <= salesVolume && salesVolume <= 500)
                    {
                        commission = salesVolume * 0.045;
                    }
                    else if (500 < salesVolume && salesVolume <= 1000)
                    {
                        commission = salesVolume * 0.075;
                    }
                    else if (1000 < salesVolume && salesVolume <= 10000)
                    {
                        commission = salesVolume * 0.10;
                    }
                    else if (salesVolume > 10000)
                    {
                        commission = salesVolume * 0.13;
                    }
                    break;

                case "Plovdiv":
                    if (0 <= salesVolume && salesVolume <= 500)
                    {
                        commission = salesVolume * 0.055;
                    }
                    else if (500 < salesVolume && salesVolume <= 1000)
                    {
                        commission = salesVolume * 0.08;
                    }
                    else if (1000 < salesVolume && salesVolume <= 10000)
                    {
                        commission = salesVolume * 0.12;
                    }
                    else if (salesVolume > 10000)
                    {
                        commission = salesVolume * 0.145;
                    }
                    break;

                default:
                    break;
            }

            if (salesVolume < 0 || (town != "Sofia" && town != "Varna" && town != "Plovdiv"))
            {
                Console.WriteLine("error");
            }

            else
            {
                Console.WriteLine($"{commission:f2}");
            }
        }
    }
}