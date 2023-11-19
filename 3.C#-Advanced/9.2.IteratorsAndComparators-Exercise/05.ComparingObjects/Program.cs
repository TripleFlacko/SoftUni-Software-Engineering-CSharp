namespace _05.ComparingObjects
{
    internal class Program
    {
        static void Main()
        {
            var persons = new List<Person>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var personInfo = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);
                var town = personInfo[2];

                var person = new Person(name, age, town);
                persons.Add(person);
            }

            var compareToPersonIndex = int.Parse(Console.ReadLine()) - 1;
            var matching = 0;
            var notMatching = 0;

            foreach (var person in persons)
            {
                var result = person.CompareTo(persons[compareToPersonIndex]);
                if (result == 0)
                {
                    matching++;
                }
                else
                {
                    notMatching++;
                }
            }

            Console.WriteLine(matching == 1 ? "No matches" : $"{matching} {notMatching} {persons.Count}");
        }
    }
}