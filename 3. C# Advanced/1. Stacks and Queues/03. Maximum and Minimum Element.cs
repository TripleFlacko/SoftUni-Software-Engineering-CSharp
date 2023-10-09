class Program
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());
        var stack = new Stack<int>();

        for (int i = 0; i < number; i++)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            switch (input[0])
            {
                case 1: stack.Push(input[1]); break;
                case 2: stack.Pop(); break;
                case 3:
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    break;
                case 4:
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                    break;
            }
        }
        Console.WriteLine(string.Join(", ", stack));
    }
}