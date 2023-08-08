using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
        var demons = new List<Demon>();

        string regexHealth = @"[^0-9+\-*/.]";
        string regexDamage = @"(\-?\+?\d+\.\d+)|(\-?\d+)";
        string regexMultiplier = @"(?<multiplier>\*+)";
        string regexDivider = @"(?<divider>\/+)";

        for (int i = 0; i < input.Count; i++)
        {
            int health = 0;
            double damage = 0;

            foreach (Match match in Regex.Matches(input[i], regexHealth))
            {
                health += Convert.ToChar(match.Value);
            }
            foreach (Match match in Regex.Matches(input[i], regexDamage))
            {
                damage += double.Parse(match.Value);
            }


            if (Regex.Match(input[i], regexMultiplier).Success)
            {

                foreach (Match match in Regex.Matches(input[i], regexMultiplier))
                {
                    char mathOperator = char.Parse(match.Value.Substring(0, 1));
                    int multiplier = Regex.Match(input[i], regexMultiplier).Value.Length;

                    for (int i2 = 0; i2 < multiplier; i2++)
                    {
                        damage *= 2;
                    }
                }
            }
            if (Regex.Match(input[i], regexDivider).Success)
            {
                foreach (Match match in Regex.Matches(input[i], regexDivider))
                {
                    char mathOperator = char.Parse(match.Value.Substring(0, 1));
                    int divider = Regex.Match(input[i], regexDivider).Value.Length;

                    for (int i2 = 0; i2 < divider; i2++)
                    {
                        damage /= 2;
                    }
                }
            }

            var demon = new Demon(input[i], health, damage);
            demons.Add(demon);
        }

        var sortedList = demons.OrderBy(x => x.Name);

        foreach (var demon in sortedList)
        {
            Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
        }
    }
}
class Demon
{
    public Demon(string name, int health, double damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }
    public string Name { get; set; }
    public int Health { get; set; }
    public double Damage { get; set; }
}