namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var team = new Team("SoftUni");
            for (int i = 0; i < lines; i++)
            {
                var playerInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var player = new Person(playerInfo[0], playerInfo[1], int.Parse(playerInfo[2]), decimal.Parse(playerInfo[3]));
                team.AddPlayer(player);
            }
            Console.WriteLine(team);
        }
    }
}