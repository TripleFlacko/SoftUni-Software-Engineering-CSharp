using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var size = int.Parse(Console.ReadLine());
        var matrix = new int[size, size];
        var sumPrimary = 0;
        var sumSecondary = 0;

        for (int row = 0; row < size; row++)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = input[col];
            }
        }

        for (int i = 0; i < size; i++)
        {
            sumPrimary += matrix[i, i];
            sumSecondary += matrix[i, size - 1 - i];
        }
        Console.WriteLine(Math.Abs(sumPrimary - sumSecondary));
    }
}