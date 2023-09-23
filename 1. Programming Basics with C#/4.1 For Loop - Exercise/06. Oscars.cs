using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorsName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int jury = int.Parse(Console.ReadLine());

            for (int i = 0; i < jury; i++)
            {
                string juryNames = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());
                points += juryNames.Length * juryPoints / 2;
                if (points > 1250.5)
                {
                    break;
                }
            }

            if (points > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorsName} got a nominee for leading role with {points:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorsName} you need {1250.50 - points:f1} more!");
            }
        }
    }
}