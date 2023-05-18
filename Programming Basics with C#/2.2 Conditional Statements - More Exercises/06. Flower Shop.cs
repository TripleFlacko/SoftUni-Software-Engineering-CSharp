using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double magnolias = 3.25 * double.Parse(Console.ReadLine());
            double hyacinths = 4 * double.Parse(Console.ReadLine());
            double roses = 3.50 * double.Parse(Console.ReadLine());
            double cacti = 8 * double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double total = 0.95 * (magnolias + hyacinths + roses + cacti);
            if (total < giftPrice)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - total)} leva.");
            }
            else
            {
                Console.WriteLine($"She is left with {Math.Floor(total - giftPrice)} leva.");
            }
        }
    }
}