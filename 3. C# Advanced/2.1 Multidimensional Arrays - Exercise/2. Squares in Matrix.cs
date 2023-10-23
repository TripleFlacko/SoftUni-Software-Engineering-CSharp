using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var size = Console.ReadLine().Split();
        var rows = int.Parse(size[0]);
        var cols = int.Parse(size[1]);
        var matrix = new string[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            var input = Console.ReadLine().Split();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = input[col];
            }
        }

        var equalSquares = 0;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1))
                {
                    var character = matrix[row, col];
                    if (new string[] { matrix[row, col], matrix[row, col + 1], matrix[row + 1, col], matrix[row + 1, col + 1] }.All(x => x == character))
                    {
                        equalSquares++;
                    }
                }
            }
        }
        Console.WriteLine(equalSquares);
    }
}