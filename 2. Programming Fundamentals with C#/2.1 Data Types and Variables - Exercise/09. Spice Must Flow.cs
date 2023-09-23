using System;

class Program
{
    static void Main()
    {
        var yieldStart = int.Parse(Console.ReadLine());
        var daysCounter = 0;
        var yieldTotal = yieldStart;
        var yieldDaily = yieldStart;

        while (yieldStart > 0)
        {
            yieldTotal -= 26;

            if (yieldStart >= 100) daysCounter++;
            else
            {
                yieldTotal = 0; break;
            }

            yieldDaily -= 10;
            if (yieldDaily < 100)
            {
                yieldTotal -= 26; break;
            }
            else yieldTotal += yieldDaily;
        }
        Console.WriteLine($"{daysCounter}\n{yieldTotal}");
    }
}