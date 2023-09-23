using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> conditions = Console.ReadLine().Split().Select(int.Parse).ToList();
        int specialNum = conditions[0];
        int power = conditions[1];

        while (true)
        {
            if (numbers.Contains(specialNum))
            {
                int index = numbers.IndexOf(specialNum);

                if (index - power < 0)
                {
                    int correctedIndex = 0;
                    int difference = index - power;

                    if (correctedIndex + power * 2 > numbers.Count - 1)
                    {
                        numbers.RemoveRange(correctedIndex, numbers.Count);
                        continue;
                    }
                    else
                    {
                        numbers.RemoveRange(correctedIndex, difference + power * 2 + 1);
                        continue;
                    }
                }
                else if (index + power > numbers.Count - 1)
                {
                    int correctedPower = numbers.Count - 1 - index;

                    numbers.RemoveRange(index - power, power + correctedPower + 1);
                    continue;
                }
                numbers.RemoveRange(index - power, power * 2 + 1);
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(numbers.Sum());
    }
}