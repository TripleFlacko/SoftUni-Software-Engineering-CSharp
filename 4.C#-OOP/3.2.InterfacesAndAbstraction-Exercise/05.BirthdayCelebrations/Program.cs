namespace _05.BirthdayCelebrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<IBirthable>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var info = command.Split();
                switch (info[0])
                {
                    case "Citizen":
                        var citizen = new Citizen(info[1], int.Parse(info[2]), info[3], info[4]);
                        list.Add(citizen);
                        break;
                    case "Pet":
                        var pet = new Pet(info[1], info[2]);
                        list.Add(pet);
                        break;
                }
            }
            var yearToCheck = Console.ReadLine();

            foreach (var person in list)
            {
                if (person.SameYear(yearToCheck))
                {
                    Console.WriteLine(person.Birthdate);
                }
            }
        }
    }
}