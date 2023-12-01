namespace _04.BorderControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var info = command.Split();
                switch (info.Length)
                {
                    case 2:
                        var robot = new Person(info[0], info[1]);
                        list.Add(robot);
                        break;
                    case 3:
                        var citizen = new Person(info[0], int.Parse(info[1]), info[2]);
                        list.Add(citizen);
                        break;
                }
            }
            var digitsToCheck = Console.ReadLine();

            foreach (var person in list)
            {
                if (person.AccessDenied(digitsToCheck))
                {
                    Console.WriteLine(person.ID);
                }
            }
        }
    }
}