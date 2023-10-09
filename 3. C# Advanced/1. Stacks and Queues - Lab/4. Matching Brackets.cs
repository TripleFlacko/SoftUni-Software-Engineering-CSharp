internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var stack = new Stack<int>();
        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];
            if (ch == '(')
            {
                stack.Push(i);
            }
            else if (ch == ')')
            {
                int startingIndex = stack.Pop();
                Console.WriteLine(input.Substring(startingIndex, i - startingIndex + 1));
            }
        }
    }
}