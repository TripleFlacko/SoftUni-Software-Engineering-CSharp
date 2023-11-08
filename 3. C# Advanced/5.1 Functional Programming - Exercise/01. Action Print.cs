using System;
using System.Linq;
using System.Threading.Channels;

public class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().ToArray();
        Action<string[]> print = input => Console.WriteLine(string.Join(Environment.NewLine, input));
        print(input);
    }
}