namespace _02.TheGambler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var board = new char[n, n];
            var positionRow = 0;
            var positionCol = 0;
            var amount = 100;

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    board[row, col] = input[col];
                    if (board[row, col] == 'G')
                    {
                        board[row, col] = '-';
                        positionRow = row;
                        positionCol = col;
                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (amount <= 0)
                {
                    break;
                }
                if (command == "up")
                {
                    positionRow -= 1;
                    if (positionRow < 0)
                    {
                        amount = 0;
                        Console.WriteLine("Game over! You lost everything!");
                        break;
                    }
                    else if (board[positionRow, positionCol] == 'W')
                    {
                        amount += 100;
                    }
                    else if (board[positionRow, positionCol] == 'P')
                    {
                        amount -= 200;
                    }
                    else if (board[positionRow, positionCol] == 'J')
                    {
                        amount += 100000;
                        Console.WriteLine($"You win the Jackpot!{Environment.NewLine}" +
                            $"End of the game. Total amount: {amount}$");
                        break;
                    }
                    board[positionRow, positionCol] = '-';
                }
                else if (command == "down")
                {
                    positionRow += 1;
                    if (positionRow > n - 1)
                    {
                        amount = 0;
                        Console.WriteLine("Game over! You lost everything!");
                        break;
                    }
                    else if (board[positionRow, positionCol] == 'W')
                    {
                        amount += 100;
                    }
                    else if (board[positionRow, positionCol] == 'P')
                    {
                        amount -= 200;
                    }
                    else if (board[positionRow, positionCol] == 'J')
                    {
                        amount += 100000;
                        Console.WriteLine($"You win the Jackpot!{Environment.NewLine}" +
                            $"End of the game. Total amount: {amount}$");
                        break;
                    }
                    board[positionRow, positionCol] = '-';
                }
                else if (command == "left")
                {
                    positionCol -= 1;
                    if (positionCol < 0)
                    {
                        amount = 0;
                        Console.WriteLine("Game over! You lost everything!");
                        break;
                    }
                    else if (board[positionRow, positionCol] == 'W')
                    {
                        amount += 100;
                    }
                    else if (board[positionRow, positionCol] == 'P')
                    {
                        amount -= 200;
                    }
                    else if (board[positionRow, positionCol] == 'J')
                    {
                        amount += 100000;
                        Console.WriteLine($"You win the Jackpot!{Environment.NewLine}" +
                            $"End of the game. Total amount: {amount}$");
                        break;
                    }
                    board[positionRow, positionCol] = '-';
                }
                else if (command == "right")
                {
                    positionCol += 1;
                    if (positionCol > n - 1)
                    {
                        amount = 0;
                        Console.WriteLine("Game over! You lost everything!");
                        break;
                    }
                    else if (board[positionRow, positionCol] == 'W')
                    {
                        amount += 100;
                    }
                    else if (board[positionRow, positionCol] == 'P')
                    {
                        amount -= 200;
                    }
                    else if (board[positionRow, positionCol] == 'J')
                    {
                        amount += 100000;
                        Console.WriteLine($"You win the Jackpot!{Environment.NewLine}" +
                            $"End of the game. Total amount: {amount}$");
                        break;
                    }
                    board[positionRow, positionCol] = '-';
                }
            }
            board[positionRow, positionCol] = 'G';
            if (amount > 0)
            {
                Console.WriteLine($"End of the game. Total amount: {amount}$");
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write(board[row, col]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Game over! You lost everything!");
            }
        }
    }
}
