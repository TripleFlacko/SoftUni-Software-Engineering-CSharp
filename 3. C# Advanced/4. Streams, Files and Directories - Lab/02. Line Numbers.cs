using System;
using System.Numerics;
using System.Collections.Generic;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            RewriteFileWithLineNumbers(inputPath, outputPath);
        }
        public static void RewriteFileWithLineNumbers(string inputFilePath, string
       outputFilePath)
        {
            var reader = new StreamReader(inputFilePath);
            var writer = new StreamWriter(outputFilePath);
            var counter = 1;

            using (writer)
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    writer.WriteLine($"{counter++}. " + line);
                    if (line == null)
                    {
                        break;
                    }
                }
            }
        }
    }
}