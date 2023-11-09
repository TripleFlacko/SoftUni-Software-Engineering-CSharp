using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        Func<string, bool> isUppercase = x => char.IsUpper(x[0]);
        var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(isUppercase).ToArray();
        Console.WriteLine(string.Join("\n", input));
    }
}