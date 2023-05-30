using System;

internal class Program
{
    static void Main(string[] args)
    {

        int hour = 0;
        int minute = 0;

        for (int i = 0; i < 24; i++)
        {
            for (int a = 0; a <= 59; a++)
            {
                Console.WriteLine($"{hour} : {minute}");
                minute++;
            }
            hour++;
            minute -= 60;
        }
    }
}
