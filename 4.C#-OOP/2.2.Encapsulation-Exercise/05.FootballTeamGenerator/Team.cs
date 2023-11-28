namespace _05.FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public double Rating
        {
            get => players.Any() ? players.Average(p => p.Stats) : 0;
        }

        public void AddPlayer(Player player) => players.Add(player);
        public void RemovePlayer(string playerName)
        {
            var player = players.FirstOrDefault(p => p.Name == playerName)
                ?? throw new ArgumentException($"Player {playerName} is not in {Name} team.");

            players.Remove(player);
        }
        public override string ToString()
        {
            return $"{Name} - {Rating:F0}";
        }
    }
}
