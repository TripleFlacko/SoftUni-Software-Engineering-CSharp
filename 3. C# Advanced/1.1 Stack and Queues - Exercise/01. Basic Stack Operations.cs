class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int toPush = input[0];
        int toPop = input[1];
        int toCheck = input[2];

        var stack = new Stack<int>();

        var num = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < toPush; i++)
        {
            stack.Push(num[i]);
        }

        for (int i = 0; i < toPop; i++)
        {
            stack.Pop();
        }

        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Contains(toCheck) ? "true" : stack.Min());
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}