using System;

namespace _10.Rage_Expenses
{
    class Program
    {
        static void Main()
        {
            var lostGamesCount = int.Parse(Console.ReadLine());
            var headsetPrice = double.Parse(Console.ReadLine());
            var mousePrice = double.Parse(Console.ReadLine());
            var keyboardPrice = double.Parse(Console.ReadLine());
            var displayPrice = double.Parse(Console.ReadLine());

            var trashedHeadset = 0;
            var trashedMouse = 0;
            var trashedKeyboard = 0;
            var trashedDisplay = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHeadset += 1;
                }
                if (i % 3 == 0)
                {
                    trashedMouse += 1;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    trashedKeyboard += 1;
                }
                if (i % 12 == 0)
                {
                    trashedDisplay += 1;
                }
            }

            var total = trashedHeadset * headsetPrice + trashedMouse * mousePrice + trashedKeyboard * keyboardPrice + trashedDisplay * displayPrice;
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}