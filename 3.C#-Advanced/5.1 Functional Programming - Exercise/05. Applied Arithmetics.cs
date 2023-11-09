using System;
using System.Linq;
using System.Threading.Channels;

public class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        string input;

        Func<List<int>, string, List<int>> manipulation = (numbers, command) =>
        {
            switch (command)
            {
                case "add":
                    numbers = numbers.Select(x => x + 1).ToList();
                    break;
                case "multiply":
                    numbers = numbers.Select(x => x * 2).ToList();
                    break;
                case "subtract":
                    numbers = numbers.Select(x => x - 1).ToList();
                    break;
                case "print":
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
            }
            return numbers;
        };

        while ((input = Console.ReadLine()) != "end")
        {
            numbers = manipulation(numbers, input);
        }
    }
}