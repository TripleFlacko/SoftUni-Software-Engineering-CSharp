using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 97; i < 97 + num; i++)
        {
            for (int i2 = 97; i2 < 97 + num; i2++)
            {
                for (int i3 = 97; i3 < 97 + num; i3++)
                {
                    Console.WriteLine($"{(char)i}{(char)i2}{(char)i3}");
                }
            }
        }
    }
}