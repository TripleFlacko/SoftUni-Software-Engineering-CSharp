using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyForTrip = double.Parse(Console.ReadLine());
            double moneySheHas = double.Parse(Console.ReadLine());
            int counterSpend = 0;
            int counterDays = 0;

            while (moneySheHas < moneyForTrip)
            {
                string actionType = Console.ReadLine();
                double moneySheSaveOrSpend = double.Parse(Console.ReadLine());
                counterDays++;

                switch (actionType)
                {
                    case "save": moneySheHas += moneySheSaveOrSpend; counterSpend = 0; break;
                    case "spend":
                        moneySheHas -= moneySheSaveOrSpend; counterSpend++;

                        if (moneySheHas < 0)
                        {
                            moneySheHas = 0;
                        }

                        break;
                }
                if (moneySheHas >= moneyForTrip)
                {
                    Console.WriteLine($"You saved the money for {counterDays} days.");
                    break;
                }

                if (counterSpend >= 5)
                {
                    Console.WriteLine($"You can't save the money.\n{counterDays}");
                    break;
                }
            }
        }
    }
}