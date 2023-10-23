using System;

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

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            var commandsArray = command.Split();

            if (commandsArray[0] == "swap" && commandsArray.Length == 5)
            {
                var index1 = int.Parse(commandsArray[1]);
                var index2 = int.Parse(commandsArray[2]);
                var index3 = int.Parse(commandsArray[3]);
                var index4 = int.Parse(commandsArray[4]);

                var rowsArray = new int[] { index1, index3 };
                var colsArray = new int[] { index2, index4 };

                bool indexValidation = rowsArray.All(x => x < matrix.GetLength(0)) && colsArray.All(x => x < matrix.GetLength(1));

                if (indexValidation)
                {
                    var value1 = matrix[index1, index2];
                    var value2 = matrix[index3, index4];

                    matrix[index1, index2] = value2;
                    matrix[index3, index4] = value1;

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                    continue;
                }
            }
            Console.WriteLine("Invalid input!");
        }
    }
}