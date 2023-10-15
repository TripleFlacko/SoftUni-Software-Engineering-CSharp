using System;

class Program
{
    static void Main(string[] args)
    {
        var size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        var rows = size[0];
        var cols = size[1];

        var matrix = new int[rows, cols];
        var sum = new int[4];

        for (int row = 0; row < rows; row++)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = input[col];
            }
        }

        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                var currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

                if (currentSum > sum.Sum())
                {
                    sum[0] = matrix[row, col];
                    sum[1] = matrix[row, col + 1];
                    sum[2] = matrix[row + 1, col];
                    sum[3] = matrix[row + 1, col + 1];
                }
            }
        }

        for (int i = 0; i < 4; i++)
        {
            Console.Write(sum[i] + " ");
            if (i % 2 != 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine(sum.Sum());

    }
}