namespace _05.FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var teams = new List<Team>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var tokens = command.Split(';');
                try
                {
                    switch (tokens[0])
                    {
                        case "Team":
                            teams.Add(new Team(tokens[1]));
                            break;
                        case "Add":
                            AddPlayer(tokens, teams);
                            break;
                        case "Remove":
                            Remove(tokens, teams);
                            break;
                        case "Rating":
                            GetRating(tokens, teams);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void AddPlayer(string[] tokens, List<Team> teams)
        {
            var teamAddFound = teams.FirstOrDefault(t => t.Name == tokens[1])
                ?? throw new ArgumentException($"Team {tokens[1]} does not exist.");

            var addPlayerName = tokens[2];
            var endurance = int.Parse(tokens[3]);
            var sprint = int.Parse(tokens[4]);
            var dribble = int.Parse(tokens[5]);
            var passing = int.Parse(tokens[6]);
            var shooting = int.Parse(tokens[7]);

            var playerAdd = new Player(tokens[2], endurance, sprint, dribble, passing, shooting);
            teamAddFound.AddPlayer(playerAdd);
        }
        static void Remove(string[] tokens, List<Team> teams)
        {
            var teamRemoveFound = teams.FirstOrDefault(t => t.Name == tokens[1])
                ?? throw new ArgumentException($"Team {tokens[1]} does not exist.");

            teamRemoveFound.RemovePlayer(tokens[2]);
        }
        static void GetRating(string[] tokens, List<Team> teams)
        {
            var team = teams.FirstOrDefault(team => team.Name == tokens[1])
                ?? throw new ArgumentException($"Team {tokens[1]} does not exist.");

            Console.WriteLine(team);
        }
    }
}