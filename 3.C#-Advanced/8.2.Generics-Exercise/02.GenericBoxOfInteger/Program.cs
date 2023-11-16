namespace _02.GenericBoxOfInteger
{
    public class Program
    {
        static void Main()
        {
            var box = new Box<int>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                box.AddValue(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(box.ToString());
        }
    }
}