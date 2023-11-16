namespace _07.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split();
            var firstTuple = new CustomTuple<string, string>();
            firstTuple.Create(string.Join(' ', firstLine[..2]), firstLine[2]);

            var secondLine = Console.ReadLine().Split();
            var secondTuple = new CustomTuple<string, int>();
            secondTuple.Create(secondLine[0], int.Parse(secondLine[1]));

            var thirdLine = Console.ReadLine().Split();
            var thirdTuple = new CustomTuple<int, double>();
            thirdTuple.Create(int.Parse(thirdLine[0]), double.Parse(thirdLine[1]));

            Console.WriteLine($"{firstTuple.Item1} -> {firstTuple.Item2}\n{secondTuple.Item1} -> {secondTuple.Item2}\n{thirdTuple.Item1} -> {thirdTuple.Item2}");

        }
    }
}