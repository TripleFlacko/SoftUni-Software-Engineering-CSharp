using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Person> list = new List<Person>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var personList = input.Split().ToList();
            string name = personList[0];
            int iD = int.Parse(personList[1]);
            int age = int.Parse(personList[2]);

            Person person = new Person(name, iD, age);
            if (list.Contains(person))
            {
                int index = list.IndexOf(person);
                if (index != -1)
                {
                    list[index] = person;
                }
            }
            else
            {
                list.Add(person);
            }
        }
        list = list.OrderBy(x => x.Age).ToList();
        foreach (Person person in list)
        {
            Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
        }
    }
}
class Person
{
    public Person(string name, int id, int age)
    {
        Name = name;
        ID = id;
        Age = age;
    }
    public string Name { get; set; }
    public int ID { get; set; }
    public int Age { get; set; }
}