using System;

class Program
{
    static void Main(string[] args)
    {
        var rows = int.Parse(Console.ReadLine());

        var matrix = new long[rows][];

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = new long[1 + row];

            if (row <= 1)
            {
                for (int i = 0; i < matrix[row].Length; i++)
                {
                    matrix[row][i] = 1;
                }
            }
            else
            {
                matrix[row][0] = 1;
                matrix[row][matrix[row].Length - 1] = 1;
                for (int col = 1; col < matrix[row].Length - 1; col++)
                {
                    matrix[row][col] = matrix[row - 1][col] + matrix[row - 1][col - 1];
                }
            }
        }
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write(matrix[row][col] + " ");
            }
            Console.WriteLine();
        }
    }
}