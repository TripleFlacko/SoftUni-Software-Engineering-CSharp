namespace _02.FishingCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var area = new char[n, n];

            var fisherRow = 0;
            var fisherCol = 0;

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    area[row, col] = input[col];
                    if (input[col] == 'S')
                    {
                        area[row, col] = '-';
                        fisherRow = row;
                        fisherCol = col;
                    }
                }
            }

            var collectedValue = 0;
            var quota = 20;

            string command;
            while ((command = Console.ReadLine()) != "collect the nets")
            {
                if (command == "up")
                {
                    if (fisherRow - 1 < 0)
                    {
                        fisherRow = area.GetLength(0) - 1;
                        if (char.IsDigit(area[fisherRow, fisherCol]))
                        {
                            collectedValue += int.Parse(area[fisherRow, fisherCol].ToString());
                            area[fisherRow, fisherCol] = '-';
                            continue;
                        }
                        else if (area[fisherRow, fisherCol] == 'W')
                        {
                            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{fisherRow},{fisherCol}]");
                            return;
                        }
                    }
                    else if (char.IsDigit(area[fisherRow - 1, fisherCol]))
                    {
                        fisherRow--;
                        collectedValue += int.Parse(area[fisherRow, fisherCol].ToString());
                        area[fisherRow, fisherCol] = '-';
                        continue;
                    }
                    else if (area[fisherRow - 1, fisherCol] == 'W')
                    {
                        fisherRow--;
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{fisherRow},{fisherCol}]");
                        return;
                    }
                    else
                    {
                        fisherRow--;
                    }
                }
                else if (command == "down")
                {
                    if (fisherRow + 1 > n - 1)
                    {
                        fisherRow = 0;
                        if (char.IsDigit(area[fisherRow, fisherCol]))
                        {
                            collectedValue += int.Parse(area[fisherRow, fisherCol].ToString());
                            area[fisherRow, fisherCol] = '-';
                            continue;
                        }
                        else if (area[fisherRow, fisherCol] == 'W')
                        {
                            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{fisherRow},{fisherCol}]");
                            return;
                        }
                    }
                    else if (char.IsDigit(area[fisherRow + 1, fisherCol]))
                    {
                        fisherRow++;
                        collectedValue += int.Parse(area[fisherRow, fisherCol].ToString());
                        area[fisherRow, fisherCol] = '-';
                        continue;
                    }
                    else if (area[fisherRow + 1, fisherCol] == 'W')
                    {
                        fisherRow++;
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{fisherRow},{fisherCol}]");
                        return;
                    }
                    else
                    {
                        fisherRow++;
                    }
                }
                else if (command == "left")
                {
                    if (fisherCol - 1 < 0)
                    {
                        fisherCol = area.GetLength(1) - 1;
                        if (char.IsDigit(area[fisherRow, fisherCol]))
                        {
                            collectedValue += int.Parse(area[fisherRow, fisherCol].ToString());
                            area[fisherRow, fisherCol] = '-';
                            continue;
                        }
                        else if (area[fisherRow, fisherCol] == 'W')
                        {
                            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{fisherRow},{fisherCol}]");
                            return;
                        }
                    }
                    else if (char.IsDigit(area[fisherRow, fisherCol - 1]))
                    {
                        fisherCol--;
                        collectedValue += int.Parse(area[fisherRow, fisherCol].ToString());
                        area[fisherRow, fisherCol] = '-';
                        continue;
                    }
                    else if (area[fisherRow, fisherCol - 1] == 'W')
                    {
                        fisherCol--;
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{fisherRow},{fisherCol}]");
                        return;
                    }
                    else
                    {
                        fisherCol--;
                    }
                }
                else if (command == "right")
                {
                    if (fisherCol + 1 > n - 1)
                    {
                        fisherCol = 0;
                        if (char.IsDigit(area[fisherRow, fisherCol]))
                        {
                            collectedValue += int.Parse(area[fisherRow, fisherCol].ToString());
                            area[fisherRow, fisherCol] = '-';
                            continue;
                        }
                        else if (area[fisherRow, fisherCol] == 'W')
                        {
                            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{fisherRow},{fisherCol}]");
                            return;
                        }
                    }
                    else if (char.IsDigit(area[fisherRow, fisherCol + 1]))
                    {
                        fisherCol++;
                        collectedValue += int.Parse(area[fisherRow, fisherCol].ToString());
                        area[fisherRow, fisherCol] = '-';
                        continue;
                    }
                    else if (area[fisherRow, fisherCol + 1] == 'W')
                    {
                        fisherCol++;
                        Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{fisherRow},{fisherCol}]");
                        return;
                    }
                    else
                    {
                        fisherCol++;
                    }
                }
            }
            area[fisherRow, fisherCol] = 'S';
            if (collectedValue >= quota)
            {
                Console.WriteLine($"Success! You managed to reach the quota!");
                Console.WriteLine($"Amount of fish caught: {collectedValue} tons.");
                PrintArea(area);
            }
            else
            {
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {quota - collectedValue} tons of fish more.");
                if (collectedValue > 0)
                {
                    Console.WriteLine($"Amount of fish caught: {collectedValue} tons.");
                }
                PrintArea(area);
            }
        }
        public static void PrintArea(char[,] area)
        {
            for (int row = 0; row < area.GetLength(0); row++)
            {
                for (int col = 0; col < area.GetLength(1); col++)
                {
                    Console.Write(area[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
