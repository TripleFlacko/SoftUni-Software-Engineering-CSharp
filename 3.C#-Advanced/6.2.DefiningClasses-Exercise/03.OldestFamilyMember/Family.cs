using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefiningClasses;

namespace DefiningClasses
{
    public class Family
    {
		private List<Person> people;
        public Family()
        {
            people = new List<Person>();
        }
        public List<Person> People
		{
			get { return people; }
			set { people = value; }
		}
		public void AddMember(Person person)
		{
			People.Add(person);
		}
		public Person GetOldestMember()
		{
			Person oldestMember = people.OrderByDescending(member => member.Age).First();
			return oldestMember;
		}

	}
}
