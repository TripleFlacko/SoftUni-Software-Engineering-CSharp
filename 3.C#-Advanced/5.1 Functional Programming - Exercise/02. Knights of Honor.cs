using System;
using System.Linq;
using System.Threading.Channels;

public class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().ToList();
        Action<List<string>> print = input => input.ForEach(name => Console.WriteLine("Sir " + name));
        print(input);
    }
}