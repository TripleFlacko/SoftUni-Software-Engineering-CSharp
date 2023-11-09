using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int fieldSize = int.Parse(Console.ReadLine());
        int[] field = new int[fieldSize];
        int[] ladybugsIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string input;

        for (int i = 0; i < ladybugsIndexes.Length; i++)
        {
            if (ladybugsIndexes[i] >= 0 && ladybugsIndexes[i] < fieldSize) field[ladybugsIndexes[i]] = 1;
        }

        while ((input = Console.ReadLine()) != "end")
        {
            string[] command = input.Split().ToArray();

            int startMoveIndex = int.Parse(command[0]);
            int flyLength = int.Parse(command[2]);

            bool isRight = command[1] == "right";
            int newLocation = startMoveIndex;

            if (startMoveIndex < 0 || startMoveIndex > fieldSize - 1 || field[startMoveIndex] != 1 || flyLength == 0) continue;

            if (isRight) newLocation += flyLength;
            else newLocation -= flyLength;

            if (newLocation < 0 || newLocation > fieldSize - 1)
            {
                field[startMoveIndex] = 0;
                continue;
            }

            while (field[newLocation] == 1)
            {
                if (isRight) newLocation += flyLength;
                else newLocation -= flyLength;

                if (newLocation < fieldSize - 1 && newLocation >= 0) continue;
                else break;
            }

            if (newLocation >= 0 && newLocation <= fieldSize - 1)
            {
                field[startMoveIndex] = 0;
                field[newLocation] = 1;
                continue;
            }
            else
            {
                field[startMoveIndex] = 0;
                continue;
            }
        }
        Console.WriteLine(string.Join(" ", field));
    }
}