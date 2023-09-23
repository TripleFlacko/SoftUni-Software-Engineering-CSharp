using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int biggerOrNot = 0;

        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (i == array.Length - 1)
            {
                Console.Write(array[i]);
                break;
            }
            for (int j = i + 1; j <= array.Length - 1; j++)
            {
                if (array[i] > array[j]) biggerOrNot++;
                else biggerOrNot--;
            }
            if (biggerOrNot > 0)
            {
                Console.Write(array[i] + " ");
                biggerOrNot = 0;
            }
            else
            {
                biggerOrNot = 0;
            }
        }

    }
}