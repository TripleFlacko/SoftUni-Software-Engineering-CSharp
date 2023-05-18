using System;

namespace _06.Strong_number
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            string numString = num.ToString();

            char[] digit = numString.ToCharArray();

            int sum = 0;

            for (int i = 0; i < digit.Length; i++)
            {
                switch (digit[i])
                {
                    case '1': sum += 1; break;
                    case '2': sum += 2; break;
                    case '3': sum += 6; break;
                    case '4': sum += 24; break;
                    case '5': sum += 120; break;
                    case '6': sum += 720; break;
                    case '7': sum += 5040; break;
                    case '8': sum += 40320; break;
                    case '9': sum += 362880; break;
                }
            }
            if (num == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}