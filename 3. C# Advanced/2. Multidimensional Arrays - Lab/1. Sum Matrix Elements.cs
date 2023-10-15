using System;

class Program
{
    static void Main(string[] args)
    {
        var size = Console.ReadLine().Split(", ");
        var rows = int.Parse(size.First());
        var cols = int.Parse(size.Last());

        int[,] matrix = new int[rows, cols];
        var sum = 0;

        for (int row = 0; row < rows; row++)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = input[col];
            }
            sum += input.Sum();
        }
        Console.WriteLine(rows);
        Console.WriteLine(cols);
        Console.WriteLine(sum);
    }
}