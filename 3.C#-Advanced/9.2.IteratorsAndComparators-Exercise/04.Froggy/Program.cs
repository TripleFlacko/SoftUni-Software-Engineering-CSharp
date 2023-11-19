namespace _04.Froggy
{
    internal class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var lake = new Lake(numbers);
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}