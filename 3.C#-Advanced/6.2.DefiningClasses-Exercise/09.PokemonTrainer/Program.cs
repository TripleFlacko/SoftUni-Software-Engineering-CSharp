namespace _09.PokemonTrainer
{
    public class Program
    {
        static void Main()
        {
            var trainers = new Dictionary<string, Trainer>();
            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                var trainerInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var trainerName = trainerInfo[0];
                var pokemonName = trainerInfo[1];
                var pokemonElement = trainerInfo[2];
                var pokemonHealth = int.Parse(trainerInfo[3]);
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = new Trainer(trainerName);
                }

                trainers[trainerName].CollectionOfPokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
            }
            while ((input = Console.ReadLine()) != "End")
            {
                var element = input;
                foreach (var trainer in trainers.Values)
                {
                    if (trainer.CollectionOfPokemons.Any(pokemon => pokemon.Element == element))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.CollectionOfPokemons)
                        {
                            pokemon.Health -= 10;
                        }
                        trainer.CollectionOfPokemons.RemoveAll(pokemon => pokemon.Health <= 0);
                    }
                }
            }
            foreach (var trainer in trainers.OrderByDescending(trainer => trainer.Value.NumberOfBadges))
            {
                Console.WriteLine(trainer.Value);
            }
        }
    }
}