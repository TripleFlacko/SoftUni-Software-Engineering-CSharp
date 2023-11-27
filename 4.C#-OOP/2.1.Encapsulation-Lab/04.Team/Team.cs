using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Team
    {
		private string name;
		private List<Person> firstTeam;
		private List<Person> reserveTeam;

        public Team(string name)
        {
            Name = name;
			firstTeam = new List<Person>();
			reserveTeam = new List<Person>();
        }

        public IReadOnlyList<Person> ReserveTeam
		{
			get { return reserveTeam; }
		}

		public IReadOnlyList<Person> FirstTeam
		{
			get { return firstTeam; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public void AddPlayer(Person player)
		{
			if (player.Age < 40)
			{
				firstTeam.Add(player);
			}
			else
			{
				reserveTeam.Add(player);
			}
		}
		public override string ToString()
		{
			return $"First team has {FirstTeam.Count} players.{Environment.NewLine}Reserve team has {ReserveTeam.Count} players.";
		}
	}
}
