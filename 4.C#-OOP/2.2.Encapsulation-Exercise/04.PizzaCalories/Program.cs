namespace _04.PizzaCalories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizzaName = Console.ReadLine().Split(' ')[1];
            var doughInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            var flourType = doughInfo[1];
            var bakingTechnique = doughInfo[2];
            var doughGrams = int.Parse(doughInfo[3]);

            try
            {
                var dough = new Dough(flourType, bakingTechnique, doughGrams);

                var toppings = new List<Topping>();
                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    var toppingInfo = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var toppingType = toppingInfo[1];
                    var toppingGrams = int.Parse(toppingInfo[2]);
                    var topping = new Topping(toppingType, toppingGrams);
                    toppings.Add(topping);
                }

                var pizza = new Pizza(pizzaName, dough, toppings);
                Console.WriteLine(pizza);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}