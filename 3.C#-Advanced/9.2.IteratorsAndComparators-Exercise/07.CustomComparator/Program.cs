using System.Collections.Immutable;

namespace _07.CustomComparator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Array.Sort(numbers, new CustomComparator());
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
    public class CustomComparator : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x % 2 == 0 && y % 2 != 0)
            {
                return -1;
            }
            if (y % 2 == 0 && x % 2 != 0)
            {
                return 1;
            }
            return x.CompareTo(y);
        }
    }
}