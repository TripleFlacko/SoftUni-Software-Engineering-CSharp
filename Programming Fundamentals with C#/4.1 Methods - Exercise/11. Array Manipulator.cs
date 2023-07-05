using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string commands;

        while ((commands = Console.ReadLine()) != "end")
        {
            string[] commandArray = commands.Split().ToArray();

            switch (commandArray[0])
            {
                case "exchange":
                    if (int.Parse(commandArray[1]) > inputArray.Length - 1 || int.Parse(commandArray[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        break;
                    }
                    if (int.Parse(commandArray[1]) == inputArray.Length - 1 || inputArray.Length == 1)
                    {
                        break;
                    }
                    if (int.Parse(commandArray[1]) == 0)
                    {
                        ExchangeIfIndex0(inputArray, commandArray);
                        break;
                    }

                    Exchange(inputArray, commandArray);
                    break;

                case "max":
                    FindMax(inputArray, commandArray);
                    break;

                case "min":
                    FindMin(inputArray, commandArray);
                    break;

                case "first":
                    if (int.Parse(commandArray[1]) > inputArray.Length || int.Parse(commandArray[1]) <= 0)
                    {
                        Console.WriteLine("Invalid count");
                        break;
                    }
                    FindFirstX(inputArray, commandArray);
                    break;

                case "last":
                    if (int.Parse(commandArray[1]) > inputArray.Length || int.Parse(commandArray[1]) <= 0)
                    {
                        Console.WriteLine("Invalid count");
                        break;
                    }
                    FindLastX(inputArray, commandArray);
                    break;

                default:
                    break;
            }
        }

        Console.WriteLine($"[{string.Join(", ", inputArray)}]");
    }

    private static void ExchangeIfIndex0(int[] inputArray, string[] commandArray)
    {
        int[] manipulationArray = new int[inputArray.Length];
        int indexSaver = int.MinValue;

        for (int i = 0; i < manipulationArray.Length; i++)
        {
            manipulationArray[i] = inputArray[i];
        }

        for (int i = int.Parse(commandArray[1]) + 1; i < inputArray.Length;)
        {
            for (int j = 0; j <= inputArray.Length - 2; j++)
            {
                inputArray[j] = manipulationArray[i];
                i++;
                if (i == inputArray.Length)
                {
                    indexSaver = i - 1;
                    break;
                }
            }
            break;
        }

        for (int i = int.Parse(commandArray[1]); i < int.Parse(commandArray[1]) + 1;)
        {
            for (int j = indexSaver; j <= inputArray.Length; j++)
            {
                inputArray[j] = manipulationArray[i];
                i++;
                if (j >= inputArray.Length - 1)
                {
                    break;
                }
            }
            break;
        }
    }
    private static void Exchange(int[] inputArray, string[] commandArray)
    {
        int[] manipulationArray = new int[inputArray.Length];

        for (int i = 0; i < int.Parse(commandArray[1]); i++)
        {
            for (int j = int.Parse(commandArray[1]) + 1; j < inputArray.Length; j++)
            {
                manipulationArray[i] = inputArray[j];
                i++;
            }
        }

        for (int i = inputArray.Length - 1; i >= int.Parse(commandArray[1]); i--)
        {
            for (int j = int.Parse(commandArray[1]); j >= 0; j--)
            {
                manipulationArray[i] = inputArray[j];
                i--;
            }
            break;
        }

        for (int i = 0; i < inputArray.Length; i++)
        {
            inputArray[i] = manipulationArray[i];
        }
    }
    private static void FindMax(int[] inputArray, string[] commandArray)
    {
        switch (commandArray[1])
        {
            case "even":
                FindMaxEven(inputArray);
                break;

            case "odd":
                FindMaxOdd(inputArray);
                break;
        }
    }
    private static void FindMaxEven(int[] inputArray)
    {
        int maxEven = int.MinValue;
        int indexOfMaxEven = int.MinValue;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i] % 2 == 0 && inputArray[i] >= maxEven)
            {
                maxEven = inputArray[i];
                indexOfMaxEven = i;
            }
        }

        if (maxEven == int.MinValue)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine(indexOfMaxEven);
        }
    }
    private static void FindMaxOdd(int[] inputArray)
    {
        int maxOdd = int.MinValue;
        int indexOfMaxOdd = int.MinValue;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i] % 2 != 0 && inputArray[i] >= maxOdd)
            {
                maxOdd = inputArray[i];
                indexOfMaxOdd = i;
            }
        }
        if (maxOdd == int.MinValue)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine(indexOfMaxOdd);
        }
    }
    private static void FindMin(int[] inputArray, string[] commandArray)
    {
        switch (commandArray[1])
        {
            case "even":
                FindMinEven(inputArray);
                break;

            case "odd":
                FindMinOdd(inputArray);
                break;
        }
    }
    private static void FindMinEven(int[] inputArray)
    {
        int minEven = int.MaxValue;
        int indexOfMinEven = int.MaxValue;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i] % 2 == 0 && inputArray[i] <= minEven)
            {
                minEven = inputArray[i];
                indexOfMinEven = i;
            }
        }
        if (minEven == int.MaxValue)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine(indexOfMinEven);
        }
    }
    private static void FindMinOdd(int[] inputArray)
    {
        int minOdd = int.MaxValue;
        int indexOfMinOdd = int.MaxValue;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i] % 2 != 0 && inputArray[i] <= minOdd)
            {
                minOdd = inputArray[i];
                indexOfMinOdd = i;
            }
        }
        if (minOdd == int.MaxValue)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine(indexOfMinOdd);
        }
    }
    private static void FindFirstX(int[] inputArray, string[] commandArray)
    {
        switch (commandArray[2])
        {
            case "even":
                FindFirstXEven(inputArray, commandArray);
                break;

            case "odd":
                FindFirstXOdd(inputArray, commandArray);
                break;
        }
    }
    private static void FindFirstXEven(int[] inputArray, string[] commandArray)
    {
        int foundEven = 0;
        string evens = string.Empty;
        for (int j = 0; j < inputArray.Length; j++)
        {
            if (inputArray[j] % 2 == 0)
            {
                evens += $"{inputArray[j]} ";
                foundEven++;
                if (foundEven == int.Parse(commandArray[1]))
                {
                    break;
                }
            }
        }

        if (foundEven == 0)
        {
            Console.WriteLine("[]");
        }
        else
        {
            int[] evensArray = evens.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string evensToPrint = string.Join(", ", evensArray);
            Console.WriteLine($"[{evensToPrint}]");
        }
    }
    private static void FindFirstXOdd(int[] inputArray, string[] commandArray)
    {
        int foundOdd = 0;
        string odds = string.Empty;
        for (int j = 0; j < inputArray.Length; j++)
        {
            if (inputArray[j] % 2 != 0)
            {
                odds += $"{inputArray[j]} ";
                foundOdd++;
                if (foundOdd == int.Parse(commandArray[1]))
                {
                    break;
                }
            }
        }

        if (foundOdd == 0)
        {
            Console.WriteLine("[]");
        }
        else
        {
            int[] oddsArray = odds.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string oddsToPrint = string.Join(", ", oddsArray);
            Console.WriteLine($"[{oddsToPrint}]");
        }
    }
    private static void FindLastX(int[] inputArray, string[] commandArray)
    {
        switch (commandArray[2])
        {
            case "even":
                FindLastXEven(inputArray, commandArray);
                break;

            case "odd":
                FindLastXOdd(inputArray, commandArray);
                break;

            default:
                break;
        }
    }
    private static void FindLastXEven(int[] inputArray, string[] commandArray)
    {
        int foundEven = 0;
        string evens = string.Empty;

        for (int j = inputArray.Length - 1; j >= 0; j--)
        {
            if (inputArray[j] % 2 == 0)
            {
                evens += $"{inputArray[j]} ";
                foundEven++;
                if (foundEven == int.Parse(commandArray[1]))
                {
                    break;
                }
            }

        }

        string[] reverseEvenArray = evens.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(reverseEvenArray);
        string evensToPrint = string.Join(", ", reverseEvenArray);
        Console.WriteLine($"[{evensToPrint}]");
    }
    private static void FindLastXOdd(int[] inputArray, string[] commandArray)
    {
        int foundOdd = 0;
        string odds = string.Empty;
        for (int j = inputArray.Length - 1; j >= 0; j--)
        {
            if (inputArray[j] % 2 != 0)
            {
                odds += $"{inputArray[j]} ";
                foundOdd++;
                if (foundOdd == int.Parse(commandArray[1]))
                {
                    break;
                }
            }
        }

        string[] reverseOddArray = odds.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(reverseOddArray);
        string oddsToPrint = string.Join(", ", reverseOddArray);
        Console.WriteLine($"[{oddsToPrint}]");
    }
}
