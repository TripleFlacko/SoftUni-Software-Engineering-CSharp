using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
		private string name;
		private int numberOfBadges;
		private List<Pokemon> collectionOfPokemons;
        public Trainer(string name)
        {
            Name = name;
			NumberOfBadges = 0;
			CollectionOfPokemons = new List<Pokemon>();
        }

        public List<Pokemon> CollectionOfPokemons
		{
			get { return collectionOfPokemons; }
			set { collectionOfPokemons = value; }
		}
		public int NumberOfBadges
		{
			get { return numberOfBadges; }
			set { numberOfBadges = value; }
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public override string ToString()
		{
			return $"{Name} {NumberOfBadges} {CollectionOfPokemons.Count}";
		}
	}
}
