namespace _03.Stack
{
    internal class Program
    {
        static void Main()
        {
            var stack = new CustomStack<int>();
            string command;
            while ((command = Console.ReadLine())!= "END")
            {
                var tokens = command.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (tokens[0])
                {
                    case "Push":
                        for (int i = 1; i < tokens.Length; i++)
                        {
                            stack.Push(int.Parse(tokens[i]));
                        }
                        break;
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("No elements");
                        }
                        break;
                }
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}