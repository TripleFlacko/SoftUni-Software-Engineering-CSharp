namespace _01.SquareRoot
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            try
            {
               double sqRoot = Math.Sqrt(number);
                if (double.IsNaN(sqRoot))
                {
                    throw new Exception("Invalid number.");
                }
                Console.WriteLine(sqRoot);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("Goodbye."); }
        }
    }
}