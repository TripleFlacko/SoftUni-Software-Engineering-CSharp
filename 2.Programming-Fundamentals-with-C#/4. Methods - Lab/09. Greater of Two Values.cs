using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string varType = Console.ReadLine();
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        CheckType(varType, input1, input2);
    }

    static void CheckType(string varType, string input1, string input2)
    {
        switch (varType)
        {
            case "int":
                int int1 = Convert.ToInt32(input1);
                int int2 = Convert.ToInt32(input2);
                Console.WriteLine(ReturnGreatestValue(int1, int2));
                break;
            case "char":
                char char1 = Convert.ToChar(input1);
                char char2 = Convert.ToChar(input2);
                Console.WriteLine(ReturnGreatestValue(char1, char2));
                break;
            case "string":
                if (ReturnGreatestValue(input1, input2) == 1)
                {
                    Console.WriteLine(input1);
                }
                else
                {
                    Console.WriteLine(input2);
                }
                break;
        }
    }

    static int ReturnGreatestValue(int input1, int input2)
    {
        return input1 > input2 ? input1 : input2;
    }
    static char ReturnGreatestValue(char input1, char input2)
    {
        return input1 > input2 ? input1 : input2;
    }
    static int ReturnGreatestValue(string input1, string input2)
    {
        return string.Compare(input1, input2);
    }
}