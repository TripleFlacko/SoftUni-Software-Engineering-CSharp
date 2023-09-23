using System;

namespace _09.Padawan_Equipment
{
    class Program
    {
        static void Main()
        {
            var money = double.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var priceLightsabers = double.Parse(Console.ReadLine());
            var priceRobes = double.Parse(Console.ReadLine());
            var priceBelts = double.Parse(Console.ReadLine());

            var total = Math.Ceiling(students * 1.10) * priceLightsabers + students * priceRobes + students * priceBelts;

            if (students >= 6)
            {
                total -= Math.Floor(students / 6d) * priceBelts;
            }

            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total - money:f2}lv more.");
            }
        }
    }
}