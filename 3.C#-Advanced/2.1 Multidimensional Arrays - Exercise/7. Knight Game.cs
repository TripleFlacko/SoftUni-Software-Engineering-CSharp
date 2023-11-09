using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var size = int.Parse(Console.ReadLine());
        var chessBoard = new char[size][];

        for (int row = 0; row < size; row++)
        {
            var input = Console.ReadLine().ToCharArray();
            chessBoard[row] = input;
        }

        var removedKnights = 0;

        while (true)
        {
            int maxAttacks = 0;
            int knightRow = -1;
            int knightCol = -1;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (chessBoard[row][col] == 'K')
                    {
                        int currentAttacks = CountAttacks(chessBoard, row, col);

                        if (currentAttacks > maxAttacks)
                        {
                            maxAttacks = currentAttacks;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }
            }

            if (maxAttacks == 0)
            {
                break;
            }

            chessBoard[knightRow][knightCol] = '0';
            removedKnights++;
        }
        Console.WriteLine(removedKnights);
    }

    static int CountAttacks(char[][] chessBoard, int row, int col)
    {
        int[] dRow = { -2, -2, -1, -1, 1, 1, 2, 2 };
        int[] dCol = { -1, 1, -2, 2, -2, 2, -1, 1 };

        int attacks = 0;

        for (int i = 0; i < 8; i++)
        {
            int newRow = row + dRow[i];
            int newCol = col + dCol[i];

            if (IsValidCell(chessBoard, newRow, newCol) && chessBoard[newRow][newCol] == 'K')
            {
                attacks++;
            }
        }

        return attacks;
    }
    static bool IsValidCell(char[][] chessBoard, int row, int col)
    {
        return row >= 0 && row < chessBoard.Length && col >= 0 && col < chessBoard[row].Length;
    }
}