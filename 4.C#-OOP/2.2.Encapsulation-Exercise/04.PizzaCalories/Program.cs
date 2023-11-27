namespace _04.PizzaCalories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizzaName = Console.ReadLine().Split()[1];
            var doughInfo = Console.ReadLine().Split();

            try
            {
                var dough = new Dough(doughInfo[1], doughInfo[2], int.Parse(doughInfo[3]));
                var pizza = new Pizza(pizzaName, dough);

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    var toppingInfo = command.Split().ToArray();

                    var topping = new Topping(toppingInfo[1], int.Parse(toppingInfo[2]));

                    pizza.AddToppings(topping);
                }

                Console.WriteLine(pizza);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}