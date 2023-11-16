namespace _03.GenericSwapMethodString
{
    public class Program
    {
        static void Main()
        {
            var box = new Box<string>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                box.AddValue(Console.ReadLine());
            }
            var swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(swapIndexes[0], swapIndexes[1]);
            Console.WriteLine(box.ToString());
        }
    }
}