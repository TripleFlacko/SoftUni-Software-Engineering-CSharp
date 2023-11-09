using System;

class Program
{
    static void Main(string[] args)
    {
        var size = int.Parse(Console.ReadLine());

        char[,] matrix = new char[size, size];

        for (int row = 0; row < size; row++)
        {
            var input = Console.ReadLine();
            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = input[col];
            }
        }
        var character = Console.ReadLine();
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (matrix[row, col] == character[0])
                {
                    Console.WriteLine($"({row}, {col})");
                    return;
                }
            }
        }
        Console.WriteLine($"{character} does not occur in the matrix");
    }
}