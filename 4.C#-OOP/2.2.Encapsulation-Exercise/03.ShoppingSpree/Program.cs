namespace _03.ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var peopleList = new List<Person>();
            var productsList = new List<Product>();
            try
            {
                var allPeople = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < allPeople.Length; i++)
                {
                    var personInfo = allPeople[i].Split('=').ToArray();
                    var personName = personInfo[0];
                    var personMoney = decimal.Parse(personInfo[1]);
                    var person = new Person(personName, personMoney);
                    peopleList.Add(person);
                }

                var products = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < products.Length; i++)
                {
                    var productsInfo = products[i].Split('=').ToArray();
                    var productName = productsInfo[0];
                    var productCost = decimal.Parse(productsInfo[1]);
                    var product = new Product(productName, productCost);
                    productsList.Add(product);
                }

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    var tokens = command.Split().ToArray();
                    var currentPersonName = tokens[0];
                    var currentProductName = tokens[1];

                    var currentPerson = peopleList.Find(p => p.Name == currentPersonName);
                    var currentProduct = productsList.Find(p => p.Name == currentProductName);

                    if (currentPerson.Money >= currentProduct.Cost)
                    {
                        currentPerson.BuyProduct(currentProduct);
                        Console.WriteLine($"{currentPersonName} bought {currentProductName}");
                    }
                    else
                    {
                        Console.WriteLine($"{currentPersonName} can't afford {currentProductName}");
                    }
                }

                foreach (var person in peopleList)
                {
                    Console.WriteLine(person);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}