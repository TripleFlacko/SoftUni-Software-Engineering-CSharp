using _06.FoodShortage.Interfaces;
using _06.FoodShortage.Models;

namespace _06.FoodShortage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<IBuyer>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var info = Console.ReadLine().Split();
                switch (info.Length)
                {
                    case 3:
                        var rebel = new Rebel(info[0], int.Parse(info[1]), info[2]);
                        list.Add(rebel);
                        break;
                    case 4:
                        var citizen = new Citizen(info[0], int.Parse(info[1]), info[2], info[3]);
                        list.Add(citizen);
                        break;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var buyer = list.FirstOrDefault(b => b.Name == command);
                if (buyer != null)
                {
                    buyer.BuyFood();
                }
            }
            Console.WriteLine(list.Sum(buyer => buyer.Food));
        }
    }
}