using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int minNum = int.MaxValue;

            while (num != "Stop")
            {
                if (int.Parse(num) < minNum)
                {
                    minNum = int.Parse(num);
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}