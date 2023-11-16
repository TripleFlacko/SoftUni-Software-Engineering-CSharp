namespace _01.GenericBoxOfString
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
            Console.WriteLine(box.ToString());
        }
    }
}