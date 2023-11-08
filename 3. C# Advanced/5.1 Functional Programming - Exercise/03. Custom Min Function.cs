using System;
using System.Linq;
using System.Threading.Channels;

public class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToHashSet();
        Func<HashSet<int>, int> findMinNum = numbers =>
        {
            int minNum = int.MaxValue;
            foreach (var number in numbers)
            {
                if (number < minNum)
                {
                    minNum = number;
                }
            }
            return minNum;
        };
        Console.WriteLine(findMinNum(input));
    }
}