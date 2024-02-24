namespace _01.OffroadChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            var initialFuel = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var consumptionIndex = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var amountFuelNeeded = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var reachedAltitudes = new List<string>();

            var count = 1;
            while (amountFuelNeeded.Any())
            {
                var intialFuelSingle = initialFuel.Pop();
                var consumptionIndexSingle = consumptionIndex.Dequeue();

                var result = intialFuelSingle - consumptionIndexSingle;

                if (result >= amountFuelNeeded.Peek())
                {
                    amountFuelNeeded.Dequeue();
                    Console.WriteLine($"John has reached: Altitude {count}");
                    reachedAltitudes.Add($"Altitude {count++}");
                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {count}");
                    if (count > 1)
                    {
                        Console.WriteLine($"John failed to reach the top.{Environment.NewLine}" +
                            $"Reached altitudes: {string.Join(", ", reachedAltitudes)}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"John failed to reach the top.{Environment.NewLine}" +
                            $"John didn't reach any altitude.");
                        return;
                    }
                }
            }
            Console.WriteLine($"John has reached all the altitudes and managed to reach the top!");
        }
    }
}
