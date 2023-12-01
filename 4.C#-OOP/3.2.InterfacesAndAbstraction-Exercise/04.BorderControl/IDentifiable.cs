namespace _04.BorderControl
{
    public interface IDentifiable
    {
        public string Name { get; }
        public string ID { get; }
        public bool AccessDenied(string lastDigits);
    }
}