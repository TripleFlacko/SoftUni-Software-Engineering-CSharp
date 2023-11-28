namespace _05.FootballTeamGenerator
{
    public class Player
    {
        private const string StatException = "{0} should be between 0 and 100.";
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }
        private int Endurance
        {
            get { return endurance; }
            set
            {
                if (ValidateStats(value))
                {
                    throw new ArgumentException(string.Format(StatException, nameof(Endurance)));
                }
                endurance = value;
            }
        }
        private int Sprint
        {
            get { return sprint; }
            set
            {
                if (ValidateStats(value))
                {
                    throw new ArgumentException(string.Format(StatException, nameof(sprint)));
                }
                sprint = value;
            }
        }

        private int Dribble
        {
            get { return dribble; }
            set
            {
                if (ValidateStats(value))
                {
                    throw new ArgumentException(string.Format(StatException, nameof(Endurance)));
                }
                dribble = value;
            }
        }

        private int Passing
        {
            get { return passing; }
            set
            {
                if (ValidateStats(value))
                {
                    throw new ArgumentException(string.Format(StatException, nameof(Endurance)));
                }
                passing = value;
            }
        }

        private int Shooting
        {
            get { return shooting; }
            set
            {
                if (ValidateStats(value))
                {
                    throw new ArgumentException(string.Format(StatException, nameof(Endurance)));
                }
                shooting = value;
            }
        }
        public double Stats => (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;
        private bool ValidateStats(int value) => value < 0 || value > 100;
    }
}
