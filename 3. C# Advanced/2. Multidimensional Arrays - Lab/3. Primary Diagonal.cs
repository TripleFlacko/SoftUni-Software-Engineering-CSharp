using System;

class Program
{
    static void Main(string[] args)
    {
        var size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        var rows = size.First();
        var cols = size.Last();

        int[,] matrix = new int[rows, cols];
        var sumColumns = 0;

        for (int row = 0; row < rows; row++)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = input[col];
            }
        }
        for (int row = 0; row < rows; row++)
        {
            for (int col = row; col < row + 1; col++)
            {
                sumColumns += matrix[row, col];
            }
        }
        Console.WriteLine(sumColumns);
    }
}