using System;

internal class Program
{
    static void Main(string[] args)
    {

        int hour = 0;
        int minute = 0;
        int second = 0;

        for (int i = 0; i < 24; i++)
        {
            for (int a = 0; a <= 59; a++)
            {
                for (int b = 0; b <= 59; b++)
                {
                    Console.WriteLine($"{hour} : {minute} : {second}");
                    second++;
                }
                minute++;
                second -= 60;
            }
            hour++;
            minute -= 60;
        }
    }
}
