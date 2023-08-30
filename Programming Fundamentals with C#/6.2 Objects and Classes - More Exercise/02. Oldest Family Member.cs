using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        var family = new Family();

        for (int i = 0; i < number; i++)
        {
            var input = Console.ReadLine().Split().ToList();
            string name = input[0];
            int age = int.Parse(input[1]);
            var person = new Person(name, age);
            family.AddMember(person);
        }
        Console.WriteLine(family.GetOldestMember().Name + " " + family.GetOldestMember().Age);
    }
}
class Family
{
    public Family()
    {
        People = new List<Person>();
    }
    public List<Person> People { get; set; }
    public void AddMember(Person person)
    {
        People.Add(person);
    }
    public Person GetOldestMember()
    {
        Person oldestMember = People
            .OrderByDescending(x => x.Age)
            .First();

        return oldestMember;
    }
}
class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public int Age { get; set; }
    public string Name { get; set; }
}