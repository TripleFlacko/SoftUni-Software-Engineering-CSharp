namespace _03.Telephony
{
    internal class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split();
            var urls = Console.ReadLine().Split();

            foreach (string number in numbers)
            {
                if (number.Length == 10)
                {
                    ICallable smartphone = new Smartphone();
                    smartphone.Call(number);
                }
                if (number.Length == 7)
                {
                    ICallable stationaryPhone = new StationaryPhone();
                    stationaryPhone.Call(number);
                }
            }

            foreach (string url in urls)
            {
                IBrowsable browser = new Smartphone();
                browser.Browse(url);
            }

        }
    }
}