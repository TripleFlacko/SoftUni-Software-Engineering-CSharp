using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1111; i <= 9999; i++)
            {
                counter = 0;
                string number = i.ToString();

                for (int i2 = 0; i2 < number.Length; i2++)
                {
                    int digit = int.Parse(number[i2].ToString());

                    if (digit == 0)
                    {
                        continue;
                    }

                    else if (n % digit == 0)
                    {
                        counter++;

                        if (counter == 4)
                        {
                            Console.Write(number + " ");
                            break;
                        }
                    }
                }
            }
        }
    }
}