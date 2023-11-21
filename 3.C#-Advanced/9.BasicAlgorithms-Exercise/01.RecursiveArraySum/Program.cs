namespace _01.RecursiveArraySum
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(RecursiveSum(input, 0));
        }
        private static int RecursiveSum(int[] numbers, int index)
        {
            if (index == numbers.Length - 1)
            {
                return numbers[index];
            }
            return numbers[index] + RecursiveSum(numbers, index + 1);
        }
    }
}