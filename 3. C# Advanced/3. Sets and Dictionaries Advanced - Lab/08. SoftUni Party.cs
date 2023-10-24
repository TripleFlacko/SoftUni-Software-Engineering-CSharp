using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var guestList = new HashSet<string>();

        while (true)
        {
            var input = Console.ReadLine();

            if (input == "PARTY")
            {
                while (true)
                {
                    var guestArrived = Console.ReadLine();
                    guestList.Remove(guestArrived);
                    if (guestArrived == "END")
                    {
                        guestList = guestList.OrderByDescending(x => char.IsDigit(x[0])).ToHashSet();
                        break;
                    }
                }
                break;
            }
            else
            {
                guestList.Add(input);
            }
        }
        Console.WriteLine($"{guestList.Count}\n" +
            $"{string.Join("\n", guestList)}");
    }
}