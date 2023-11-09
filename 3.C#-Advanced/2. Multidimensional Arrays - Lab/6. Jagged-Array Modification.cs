using System;

class Program
{
    static void Main(string[] args)
    {
        var size = int.Parse(Console.ReadLine());

        var matrix = new int[size][];

        for (int row = 0; row < matrix.Length; row++)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            matrix[row] = new int[input.Length];

            for (int col = 0; col < input.Length; col++)
            {
                matrix[row][col] = input[col];
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            var commandArray = command.Split();
            var row = int.Parse(commandArray[1]);
            var col = int.Parse(commandArray[2]);
            var value = int.Parse(commandArray[3]);

            if (row >= 0 && col >= 0 && row < matrix.Length && col < matrix[row].Length)
            {
                switch (commandArray[0])
                {
                    case "Add":
                        matrix[row][col] += value;
                        break;
                    case "Subtract":
                        matrix[row][col] -= value;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid coordinates");
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