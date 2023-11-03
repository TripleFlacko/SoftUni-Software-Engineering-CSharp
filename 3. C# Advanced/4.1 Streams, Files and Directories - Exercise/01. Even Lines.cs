namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            var sb = new StringBuilder();

            using (var streamReader = new StreamReader(inputFilePath))
            {
                var lineCounter = 0;
                var lineRead = string.Empty;

                while ((lineRead = streamReader.ReadLine()) != null)
                {
                    if (lineCounter % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSymbols(lineRead);
                        string reversedWords = ReverseWords(replacedSymbols);
                        sb.AppendLine(reversedWords);
                    }
                    lineCounter++;
                }
            }
            return sb.ToString();
        }

        private static string ReverseWords(string replacedSymbols)
        {
            var wordArray = replacedSymbols.Split().Reverse().ToArray();
            return string.Join(" ", wordArray);
        }

        private static string ReplaceSymbols(string lineRead)
        {
            var sb = new StringBuilder(lineRead);

            var charsToReplace = new char[] { '-', ',', '.', '!', '?' };

            foreach (var ch in charsToReplace)
            {
                sb.Replace(ch, '@');
            }
            return sb.ToString();
        }
    }
}
