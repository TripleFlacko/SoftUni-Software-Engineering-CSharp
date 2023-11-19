namespace _06.EqualityLogic
{
    internal class Program
    {
        static void Main()
        {
            var hashSet = new HashSet<Person>();
            var sortedSet = new SortedSet<Person>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var personInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);

                var person = new Person(name, age);

                hashSet.Add(person);
                sortedSet.Add(person);
            }
            Console.WriteLine($"{hashSet.Count}\n{sortedSet.Count}");
        }
    }
}