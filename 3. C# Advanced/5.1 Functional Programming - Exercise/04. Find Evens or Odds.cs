using System;
using System.Linq;
using System.Threading.Channels;

public class Program
{
    static void Main()
    {
        var range = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var numbers = Enumerable.Range(range[0], range[1] - range[0] + 1).ToArray();
        var evenOrOdd = Console.ReadLine();
        Predicate<int[]> filter = numbers =>
        {
            switch (evenOrOdd)
            {
                case "odd":
                    return true;
                default:
                    return false;
            }
        };
        if (filter(numbers))
        {
            numbers = numbers.Where(x => x % 2 != 0).ToArray();
        }
        else
        {
            numbers = numbers.Where(x => x % 2 == 0).ToArray();
        }
        Console.WriteLine(string.Join(' ', numbers));
    }
}