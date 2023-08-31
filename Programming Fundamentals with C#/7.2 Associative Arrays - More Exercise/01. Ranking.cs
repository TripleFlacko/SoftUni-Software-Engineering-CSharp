using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Xml.Schema;

class Program
{
    static void Main()
    {
        var contests = new Dictionary<string, string>();
        var users = new List<User>();

        string command;
        while ((command = Console.ReadLine()) != "end of contests")
        {
            var contestsInput = command.Split(':').ToList();
            var contestName = contestsInput[0];
            var contestPassword = contestsInput[1];
            contests.Add(contestName, contestPassword);
        }

        while ((command = Console.ReadLine()) != "end of submissions")
        {
            var entriesInput = command.Split("=>");
            var contestName = entriesInput[0];
            var contestPassword = entriesInput[1];
            var username = entriesInput[2];
            var points = int.Parse(entriesInput[3]);

            if (contests.TryGetValue(contestName, out var correctPassword) && correctPassword == contestPassword)
            {
                var user = users.FirstOrDefault(u => u.Username == username);

                if (user == null)
                {
                    user = new User(username);
                    users.Add(user);
                }

                user.UpdateContest(contestName, points);
            }
        }

        User topUser = users.OrderByDescending(x => x.Contests.Values.Sum()).First();
        users = users.OrderBy(x => x.Username).ToList();

        foreach (var user in users)
        {
            user.SortByPoints();
        }

        Console.WriteLine($"Best candidate is {topUser.Username} with total {topUser.Contests.Values.Sum()} points.");
        Console.WriteLine($"Ranking: ");
        foreach (var user in users)
        {
            Console.WriteLine($"{user.Username}");
            foreach (var contest in user.Contests)
            {
                Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
            }
        }

    }
}
class User
{
    public User(string username)
    {
        Username = username;
        Contests = new Dictionary<string, int>();
    }
    public string Username { get; set; }
    public Dictionary<string, int> Contests { get; set; }

    public void SortByPoints()
    {
        Contests = Contests.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
    }
    public void UpdateContest(string contest, int points)
    {
        if (!Contests.ContainsKey(contest) || Contests[contest] < points)
        {
            Contests[contest] = points;
        }
    }
}