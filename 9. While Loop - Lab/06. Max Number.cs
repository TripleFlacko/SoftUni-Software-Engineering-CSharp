using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int maxNum = int.MinValue;

            while (num != "Stop")
            {
                if (int.Parse(num) > maxNum)
                {
                    maxNum = int.Parse(num);
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}