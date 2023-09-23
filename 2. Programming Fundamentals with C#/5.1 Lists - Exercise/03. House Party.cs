using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int numberPeople = int.Parse(Console.ReadLine());

        List<string> guestList = new List<string>();

        for (int i = 0; i < numberPeople; i++)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string guestName = input[0];
            if (input[2] == "not")
            {
                if (guestList.Contains(input[0]))
                {
                    guestList.Remove(input[0]);
                }
                else
                {
                    Console.WriteLine($"{input[0]} is not in the list!");
                }
            }
            else
            {
                if (guestList.Contains(input[0]))
                {
                    Console.WriteLine($"{input[0]} is already in the list!");
                }
                else
                {
                    guestList.Add(input[0]);
                }
            }
        }
        foreach (string guest in guestList)
        {
            Console.WriteLine(guest);
        }
    }
}