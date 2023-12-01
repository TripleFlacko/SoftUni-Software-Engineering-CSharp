namespace _05.BirthdayCelebrations
{
    public interface IDentifiable
    {
        string Name { get; }
        string ID { get; }
        bool AccessDenied(string lastDigits);
    }
}