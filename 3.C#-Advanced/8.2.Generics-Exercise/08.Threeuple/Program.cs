using _07.Tuple;

namespace _08.Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split();
            var firstTuple = new CustomTuple<string, string, string>();
            firstTuple.Create(string.Join(' ', firstLine[..2]), firstLine[2], string.Join(' ', firstLine[3..]));

            var secondLine = Console.ReadLine().Split();
            var secondTuple = new CustomTuple<string, int, bool>();
            secondTuple.Create(secondLine[0], int.Parse(secondLine[1]), secondLine[2] == "drunk" ? true : false);

            var thirdLine = Console.ReadLine().Split();
            var thirdTuple = new CustomTuple<string, double, string>();
            thirdTuple.Create(thirdLine[0], double.Parse(thirdLine[1]), thirdLine[2]);

            Console.WriteLine($"{firstTuple.Item1} -> {firstTuple.Item2} -> {firstTuple.Item3}\n{secondTuple.Item1} -> {secondTuple.Item2} -> {secondTuple.Item3}\n{thirdTuple.Item1} -> {thirdTuple.Item2} -> {thirdTuple.Item3}");
        }
    }
}