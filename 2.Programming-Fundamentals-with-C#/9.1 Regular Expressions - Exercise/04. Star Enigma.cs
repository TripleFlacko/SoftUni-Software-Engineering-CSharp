using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        List<Attack> list = new List<Attack>();

        int lines = int.Parse(Console.ReadLine());

        string regexKey = @"[S,T,A,R,s,t,a,r]";
        string regexAttack = @"([^@\-!:>]+)?@([^@\-!:>A-z]+)?(?<planet>[A-z]+)([^@\-!:>]+)?:([^@\-!:>\d]+)?(?<population>\d+)([^@\-!:>]+)?!([^@\-!:>A-z]+)?(?<attackType>\w+)([^@\-!:>]+)?!([^@\-!:>]+)?->([^@\-!:>\d]+)?(?<soldierCount>\d*)([^@\-!:>]+)?";

        for (int i = 0; i < lines; i++)
        {
            string input = Console.ReadLine();
            MatchCollection letters = Regex.Matches(input, regexKey);
            int key = letters.Count;

            string decryptedMessage = string.Empty;
            for (int i2 = 0; i2 < input.Length; i2++)
            {
                decryptedMessage += (char)(input[i2] - key);
            }

            foreach (Match attackInfo in Regex.Matches(decryptedMessage, regexAttack))
            {
                var attack = new Attack(
                    attackInfo.Groups["planet"].Value,
                    int.Parse(attackInfo.Groups["population"].Value),
                    char.Parse(attackInfo.Groups["attackType"].Value),
                    int.Parse(attackInfo.Groups["soldierCount"].Value)
                    );
                list.Add(attack);
            }
        }


        var attackedPlanets = list.Where(x => x.AttackType == 'A').OrderBy(x => x.Planet);
        var destroyedPlanets = list.Where(x => x.AttackType == 'D').OrderBy(x => x.Planet);

        Console.WriteLine($"Attacked planets: {attackedPlanets.Count()}");
        foreach (var planet in attackedPlanets)
        {
            Console.WriteLine($"-> {planet.Planet}");
        }

        Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count()}");
        foreach (var planet in destroyedPlanets)
        {
            Console.WriteLine($"-> {planet.Planet}");
        }
    }
}
class Attack
{
    public Attack(string planet, int population, char attackType, int soldierCount)
    {
        Planet = planet;
        Population = population;
        AttackType = attackType;
        SoldierCount = soldierCount;
    }
    public string Planet { get; set; }
    public int Population { get; set; }
    public char AttackType { get; set; }
    public int SoldierCount { get; set; }
}