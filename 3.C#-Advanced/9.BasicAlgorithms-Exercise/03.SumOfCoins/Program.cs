namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Formats.Asn1;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var coins = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            var targetSum = int.Parse(Console.ReadLine());

            var coinsUsed = ChooseCoins(coins, targetSum);
            var coinsToTake = coinsUsed.Sum(x => x.Value);

            Console.WriteLine($"Number of coins to take: {coinsToTake}");

            foreach (var kvp in coinsUsed)
            {
                if (kvp.Value != 0)
                {
                    Console.WriteLine($"{kvp.Value} coin(s) with value {kvp.Key}");
                }
            }
        }
        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            var coinsUsed = new Dictionary<int, int>();

            foreach (var coin in coins.OrderByDescending(x => x))
            {
                coinsUsed[coin] = targetSum / coin;
                targetSum %= coin;
            }

            if (targetSum != 0)
            {
                throw new InvalidOperationException();
            }

            return coinsUsed;
        }
    }
}