using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int sumLeft = 0;
        int sumRight = 0;
        int numberFound = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array.Length == 1)
            {
                Console.WriteLine(i);
                break;
            }

            for (int j = i + 1; j < array.Length; j++)
            {
                sumRight += array[j];
            }

            if (i != 0)
            {
                for (int j2 = i - 1; j2 >= 0; j2--)
                {
                    sumLeft += array[j2];
                }
            }

            if (sumLeft == sumRight)
            {
                Console.WriteLine(i);
                numberFound++;
                break;
            }

            if (sumLeft != sumRight && i == array.Length - 1)
            {
                Console.WriteLine("no");
            }

            sumRight = 0;
            sumLeft = 0;
        }
    }
}