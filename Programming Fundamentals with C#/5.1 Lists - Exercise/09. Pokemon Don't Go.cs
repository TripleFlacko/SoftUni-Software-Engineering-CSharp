using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        int removedElement;
        int sumRemovedElements = 0;

        while (list.Count != 0)
        {
            int index = int.Parse(Console.ReadLine());

            if (index < 0)
            {
                removedElement = list[0];
                sumRemovedElements += removedElement;
                list.RemoveAt(0);

                if (list.Count == 0)
                {
                    break;
                }

                list.Insert(0, list[^1]);
                IncreaseAndDecrease(list, removedElement);
            }
            else if (index >= list.Count)
            {
                removedElement = list[^1];
                sumRemovedElements += removedElement;
                list.RemoveAt(list.Count - 1);

                if (list.Count == 0)
                {
                    break;
                }

                list.Add(list[0]);

                IncreaseAndDecrease(list, removedElement);
            }
            else
            {
                removedElement = list[index];
                sumRemovedElements += removedElement;
                list.RemoveAt(index);
                IncreaseAndDecrease(list, removedElement);
            }

        }
        Console.WriteLine(sumRemovedElements);
    }

    private static void IncreaseAndDecrease(List<int> list, int removedElement)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (removedElement >= list[i])
            {
                list[i] += removedElement;
            }
            else if (removedElement < list[i])
            {
                list[i] -= removedElement;
            }
        }
    }
}