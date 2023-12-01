namespace _06.FoodShortage.Interfaces
{
    public interface IDentifiable
    {
        string Name { get; }
        string ID { get; }
        bool AccessDenied(string lastDigits);
    }
}