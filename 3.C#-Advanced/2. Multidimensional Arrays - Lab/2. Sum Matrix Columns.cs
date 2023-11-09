using System;

class Program
{
    static void Main(string[] args)
    {
        var size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        var rows = size.First();
        var cols = size.Last();

        int[,] matrix = new int[rows, cols];
        var sumColumns = new int[cols];

        for (int row = 0; row < rows; row++)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = input[col];
            }
        }
        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows; row++)
            {
                sumColumns[col] += matrix[row, col];
            }
        }
        foreach (var column in sumColumns)
        {
            Console.WriteLine(column);
        }
    }
}