using DateModifier;
namespace DateModifier
{
    internal class StartUp
    {
        static void Main()
        {
            var startDate = DateTime.Parse(Console.ReadLine());
            var endDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(DateModifier.GetDifference(startDate, endDate));
        }
    }
}