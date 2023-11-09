using Microsoft.Win32.SafeHandles;
using System;


namespace _04._Numbers_Divided_By_3_Without
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 99; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}