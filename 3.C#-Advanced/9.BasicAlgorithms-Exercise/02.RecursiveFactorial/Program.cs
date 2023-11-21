namespace _02.RecursiveFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(RecursiveFactorial(n));
        }
        private static long RecursiveFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * RecursiveFactorial(n - 1);
        }
    }
}