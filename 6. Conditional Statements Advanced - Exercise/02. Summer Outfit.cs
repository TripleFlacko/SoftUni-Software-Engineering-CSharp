using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();
            string shirt = "";
            string shoes = "";

            if (10 <= degrees && degrees <= 18)
            {
                switch (timeOfTheDay)
                {
                    case "Morning": shirt = "Sweatshirt"; shoes = "Sneakers"; break;
                    case "Afternoon": shirt = "Shirt"; shoes = "Moccasins"; break;
                    case "Evening": shirt = "Shirt"; shoes = "Moccasins"; break;
                }
            }
            else if (degrees <= 24)
            {
                switch (timeOfTheDay)
                {
                    case "Morning": shirt = "Shirt"; shoes = "Moccasins"; break;
                    case "Afternoon": shirt = "T-Shirt"; shoes = "Sandals"; break;
                    case "Evening": shirt = "Shirt"; shoes = "Moccasins"; break;
                }
            }
            else if (degrees >= 25)
            {
                switch (timeOfTheDay)
                {
                    case "Morning": shirt = "T-Shirt"; shoes = "Sandals"; break;
                    case "Afternoon": shirt = "Swim Suit"; shoes = "Barefoot"; break;
                    case "Evening": shirt = "Shirt"; shoes = "Moccasins"; break;
                }
            }

            Console.WriteLine($"It's {degrees} degrees, get your {shirt} and {shoes}.");
        }
    }
}