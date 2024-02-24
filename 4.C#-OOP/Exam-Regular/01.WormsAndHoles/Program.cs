namespace _01.WormsAndHoles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var worms = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var holes = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            var totalWorms = worms.Count;
            var matches = 0;

            while (true)
            {
                if (!worms.Any() || !holes.Any())
                {
                    break;
                }

                if (worms.Peek() == holes.Peek())
                {
                    worms.Pop();
                    holes.Dequeue();
                    matches++;
                }
                else
                {
                    var worm = worms.Pop() - 3;
                    holes.Dequeue();

                    var temp = new Stack<int>();

                    while (worms.Count > 0)
                    {
                        temp.Push(worms.Pop());
                    }
                    while (temp.Count > 0)
                    {
                        worms.Push(temp.Pop());
                    }
                    if (worm > 0)
                    {
                        worms.Push(worm);
                    }
                }
            }
            Console.WriteLine(matches > 0 ? $"Matches: {matches}" : "There are no matches.");

            if (worms.Count == 0 && totalWorms == matches)
            {
                Console.WriteLine("Every worm found a suitable hole!");
            }
            else
            {
                Console.WriteLine(worms.Count == 0 ? $"Worms left: none" : $"Worms left: {string.Join(", ", worms)}");
            }
            Console.WriteLine(holes.Count == 0 ? $"Holes left: none" : $"Holes left: {string.Join(", ", holes)}");

        }
    }
}