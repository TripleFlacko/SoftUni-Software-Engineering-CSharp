internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Reverse().ToArray();
        var stack = new Stack<string>(input);
        int result = int.Parse(stack.Pop());

        while (stack.Count > 0)
        {
            string operator1 = stack.Pop();
            int num = int.Parse(stack.Pop());
            switch (operator1)
            {
                case "-":
                    result -= num;
                    break;

                case "+":
                    result += num;
                    break;
            }
        }
        Console.WriteLine(result);
    }
}