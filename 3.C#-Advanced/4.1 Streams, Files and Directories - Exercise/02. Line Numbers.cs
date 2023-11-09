namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            var lineCounter = 1;
            var lineReader = string.Empty;
            using (var streamReader = new StreamReader(inputFilePath))
            using (var streamWriter = new StreamWriter(outputFilePath))
            {
                while ((lineReader = streamReader.ReadLine()) != null)
                {
                    var letters = 0;
                    var punctuationMarks = 0;
                    foreach (var ch in lineReader)
                    {
                        if (char.IsLetter(ch))
                        {
                            letters++;
                        }
                        else if (char.IsPunctuation(ch))
                        {
                            punctuationMarks++;
                        }
                    }
                    streamWriter.WriteLine($"Line {lineCounter}: {lineReader} ({letters}) ({punctuationMarks})");
                    lineCounter++;
                }
            }
        }
    }
}
