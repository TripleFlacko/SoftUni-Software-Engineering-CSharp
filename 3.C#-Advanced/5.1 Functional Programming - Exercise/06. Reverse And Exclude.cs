using System;
using System.Linq;
using System.Threading.Channels;

public class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        var divider = int.Parse(Console.ReadLine());

        Predicate<int> isDivisable = number =>
        {
            if (number % divider == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        };

        for (int i = 0; i < numbers.Count;)
        {
            if (isDivisable(numbers[i]))
            {
                numbers.Remove(numbers[i]);
                i = 0;
                continue;
            }
            i++;
        }

        var reversedList = new List<int>();
        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            reversedList.Add(numbers[i]);
        }
        Console.WriteLine(string.Join(' ', reversedList));
    }
}