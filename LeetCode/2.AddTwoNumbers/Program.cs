using System.Text;

namespace _2.AddTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome(int.Parse(Console.ReadLine()));
            bool IsPalindrome(int x)
            {
                var temp = x.ToString();
                var center = temp.Length / 2;
                if (temp.Length <= 2)
                {
                    if (temp[0] == temp[^1])
                    {
                        return true;
                    }
                    return false;
                }

                if (temp.Substring(0, center - 1) == temp.Substring(center + 1, temp.Length - center))
                {
                    return true;
                }
                
                return false;
            }
        }
    }
}