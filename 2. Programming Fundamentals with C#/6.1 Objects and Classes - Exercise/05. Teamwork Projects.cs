using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        List<Team> teams = new List<Team>();

        for (int i = 0; i < number; i++)
        {
            CreateTeam(teams);
        }

        string command;
        while ((command = Console.ReadLine()) != "end of assignment")
        {
            var input = command.Split("->").ToList();
            string member = input[0];
            string teamName = input[1];

            var existingMember = teams.Find(t => t.Members.Contains(member));
            var existingCreator = teams.Find(t => t.Creator == member);

            Team foundTeam = teams.Find(t => t.Name == teamName);
            if (foundTeam != null)
            {
                if (existingMember == null && existingCreator == null)
                {
                    foundTeam.Members.Add(member);
                }
                else
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }
            }
            else
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                continue;
            }
        }

        List<Team> sortedTeamsValid = teams
            .FindAll(t => t.Members.Count > 0)
            .OrderByDescending(t => t.Members.Count)
            .ThenBy(t => t.Name)
            .ToList();

        List<Team> sortedTeamsToDisband = teams
            .FindAll(t => t.Members.Count == 0)
            .OrderBy(t => t.Name)
            .ToList();

        foreach (var team in sortedTeamsValid)
        {
            Console.WriteLine($"{team.Name}");
            Console.WriteLine($"- {team.Creator}");
            team.Members.Sort();
            foreach (string member in team.Members)
            {
                Console.WriteLine($"-- {member}");
            }
        }

        Console.WriteLine("Teams to disband:");
        foreach (var team in sortedTeamsToDisband)
        {
            Console.WriteLine(team.Name);
        }
    }

    private static void CreateTeam(List<Team> teams)
    {
        var input = Console.ReadLine().Split('-').ToList();
        string creator = input[0];
        string teamName = input[1];

        var team = new Team(teamName, creator);

        var existingCreator = teams.Find(t => t.Creator == creator);
        var existingTeam = teams.Find(t => t.Name == teamName);

        if (existingTeam != null)
        {
            Console.WriteLine($"Team {teamName} was already created!");
        }
        else if (existingCreator != null)
        {
            Console.WriteLine($"{creator} cannot create another team!");
        }
        else
        {
            teams.Add(team);
            Console.WriteLine($"Team {teamName} has been created by {creator}!");
        }
    }
}
class Team
{
    public Team(string teamName, string creator)
    {
        Name = teamName;
        Creator = creator;
        Members = new List<string>();
    }
    public string Name { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }
}