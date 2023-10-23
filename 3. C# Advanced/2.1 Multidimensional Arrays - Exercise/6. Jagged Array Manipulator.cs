using System;

class Program
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        int[][] matrix = new int[rows][];

        for (int row = 0; row < rows; row++)
        {
            int[] rowInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            matrix[row] = rowInput;
        }

        for (int row = 0; row < rows - 1; row++)
        {
            if (matrix[row].Length == matrix[row + 1].Length)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] *= 2;
                    matrix[row + 1][col] *= 2;
                }
            }
            else
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] /= 2;
                }
                for (int col = 0; col < matrix[row + 1].Length; col++)
                {
                    matrix[row + 1][col] /= 2;
                }
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] commandValues = command.Split();
            string action = commandValues[0];
            int row = int.Parse(commandValues[1]);
            int col = int.Parse(commandValues[2]);
            int value = int.Parse(commandValues[3]);

            if (row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
            {
                if (action == "Add")
                {
                    matrix[row][col] += value;
                }
                else if (action == "Subtract")
                {
                    matrix[row][col] -= value;
                }
            }
        }

        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine(string.Join(" ", matrix[i]));
        }
    }
}