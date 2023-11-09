using System;

class Program
{
    static void Main()
    {
        var size = Console.ReadLine().Split();
        var rows = int.Parse(size[0]);
        var cols = int.Parse(size[1]);

        var text = Console.ReadLine();

        var matrix = new char[rows, cols];
        var wordIndex = 0;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (row % 2 == 0)
                {
                    matrix[row, col] = text[wordIndex];
                }
                else
                {
                    matrix[row, cols - 1 - col] = text[wordIndex];
                }
                wordIndex = (wordIndex + 1) % text.Length;
            }
        }
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}