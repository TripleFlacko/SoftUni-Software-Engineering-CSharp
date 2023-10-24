using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var parking = new HashSet<string>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var data = input.Split(", ");
            var direction = data[0];
            var licensePlate = data[1];

            switch (direction)
            {
                case "IN":
                    parking.Add(licensePlate);
                    break;
                case "OUT":
                    parking.Remove(licensePlate);
                    break;
            }
        }
        Console.WriteLine(parking.Count > 0 ? string.Join("\n", parking) : "Parking Lot is Empty");
    }
}