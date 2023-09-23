using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        Stack<char> stack = new Stack<char>(input);
        int number = stack.Count;

        for (int i = 0; i < number; i++)
        {
            Console.Write(stack.Pop());
        }
    }
}