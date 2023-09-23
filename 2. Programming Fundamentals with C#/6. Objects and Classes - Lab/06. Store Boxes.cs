using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        List<Box> boxes = new List<Box>();

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            List<string> input = command.Split().ToList();

            int serialNumber = int.Parse(input[0]);
            string itemName = input[1];
            int quantity = int.Parse(input[2]);
            decimal price = decimal.Parse(input[3]);

            Item item = new Item(itemName, price);
            Box box = new Box(serialNumber, item, quantity);
            boxes.Add(box);
        }

        List<Box> sortedBoxes = boxes.OrderByDescending(b => b.PriceBox).ToList();
        foreach (Box box in sortedBoxes)
        {
            Console.WriteLine($"{box.SerialNumber}\n-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}\r\n-- ${box.PriceBox:f2}");
        }

    }
}
class Item
{
    public Item(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
class Box
{
    public Box(int serialNumber, Item item, int quantity)
    {
        SerialNumber = serialNumber;
        Item = item;
        Quantity = quantity;
        PriceBox = Quantity * Item.Price;
    }
    public int SerialNumber { get; set; }
    public Item Item { get; set; }
    public int Quantity { get; set; }
    public decimal PriceBox { get; set; }
}