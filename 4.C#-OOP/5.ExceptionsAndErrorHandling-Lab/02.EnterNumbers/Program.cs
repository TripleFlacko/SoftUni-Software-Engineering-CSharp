namespace _02.EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number <= 1 || number > 100)
                    {
                        throw new ArgumentOutOfRangeException($"Your number is not in range 1 - 100!");
                    }
                    list.Add(number);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number!");
                    i--;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.ParamName);
                    i--;
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}