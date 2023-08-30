using System;
using System.Collections.Generic;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        List<Person> peopleList = ParsePeople(Console.ReadLine());
        List<Product> productsList = ParseProducts(Console.ReadLine());

        ProcessPurchases(peopleList, productsList);

        PrintResults(peopleList);
    }

    private static List<Product> ParseProducts(string input)
    {
        var productsList = new List<Product>();
        var productsInput = input.Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        for (int i = 0; i < productsInput.Count; i += 2)
        {
            string name = productsInput[i];
            decimal price = decimal.Parse(productsInput[i + 1]);
            var product = new Product(name, price);
            productsList.Add(product);
        }

        return productsList;
    }

    private static List<Person> ParsePeople(string input)
    {
        var peopleList = new List<Person>();
        var peopleInput = input.Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        for (int i = 0; i < peopleInput.Count; i += 2)
        {
            string name = peopleInput[i];
            decimal money = decimal.Parse(peopleInput[i + 1]);
            var person = new Person(name, money);
            peopleList.Add(person);
        }

        return peopleList;
    }

    private static void PrintResults(List<Person> peopleList)
    {
        foreach (var person in peopleList)
        {
            if (person.Products.Count == 0)
            {
                Console.WriteLine($"{person.Name} - Nothing bought");
            }
            else
            {
                Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(x => x.Name))}");
            }
        }
    }

    private static void ProcessPurchases(List<Person> peopleList, List<Product> productsList)
    {
        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            var purchase = command.Split().ToList();
            var person = purchase[0];
            var product = purchase[1];

            peopleList
                .First(x => x.Name == person)
                .AddProduct(productsList.First(x => x.Name == product));
        }
    }
}
class Person
{
    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        Products = new List<Product>();
    }
    public string Name { get; set; }
    public decimal Money { get; set; }
    public List<Product> Products { get; set; }

    public void AddProduct(Product product)
    {
        if (Money >= product.Price)
        {
            Money -= product.Price;
            Products.Add(product);
            Console.WriteLine($"{Name} bought {product.Name}");
        }
        else
        {
            Console.WriteLine($"{Name} can't afford {product.Name}");
        }
    }
}
class Product
{
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public string Name { get; set; }
    public decimal Price { get; set; }
}