using System;

class Program
{
    static void Main(string[] args)
    {
        var size = Console.ReadLine().Split();
        var rows = int.Parse(size[0]);
        var cols = int.Parse(size[1]);
        var matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            var input = Console.ReadLine().Split();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = int.Parse(input[col]);
            }
        }

        var maxSum = int.MinValue;
        var maxRow = 0;
        var maxCol = 0;

        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                var currentSum = 0;
                for (int i = row; i < row + 3; i++)
                {
                    for (int j = col; j < col + 3; j++)
                    {
                        currentSum += matrix[i, j];
                    }
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }

        Console.WriteLine($"Sum = {maxSum}");
        for (int row = maxRow; row < maxRow + 3; row++)
        {
            for (int col = maxCol; col < maxCol + 3; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}