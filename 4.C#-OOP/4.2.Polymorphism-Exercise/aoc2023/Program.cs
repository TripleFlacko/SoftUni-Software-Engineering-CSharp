using System.Text.RegularExpressions;

namespace aoc2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            var inputString = "".Split("\r\n").ToList();
            List<string> wordsToFind = new List<string> { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            foreach (string line in inputString)
            {
                var digits = new List<string>();
                List<string> foundElements = FindElementsInString(line, wordsToFind);
                foreach (var item in foundElements)
                {
                    switch (item)
                    {
                        case "one":
                        case "1":
                            digits.Add("1");
                            break;

                        case "two":
                        case "2":
                            digits.Add("2");
                            break;

                        case "three":
                        case "3":
                            digits.Add("3");
                            break;

                        case "four":
                        case "4":
                            digits.Add("4");
                            break;

                        case "five":
                        case "5":
                            digits.Add("5");
                            break;

                        case "six":
                        case "6":
                            digits.Add("6");
                            break;

                        case "seven":
                        case "7":
                            digits.Add("7");
                            break;

                        case "eight":
                        case "8":
                            digits.Add("8");
                            break;

                        case "nine":
                        case "9":
                            digits.Add("9");
                            break;

                    }
                }
                var tempStr = digits[0] + digits[digits.Count - 1];
                sum += int.Parse(tempStr);
            }
            Console.WriteLine(sum);

        }

        static List<string> FindElementsInString(string line, List<string> wordsToFind)
        {
            List<string> foundElements = new List<string>();

            foreach (Match match in Regex.Matches(line, string.Join("|", wordsToFind)))
            {
                foundElements.Add(match.Value);
            }

            return foundElements;
        }
    }
}
