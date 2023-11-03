using System;
using System.Numerics;
using System.Collections.Generic;

namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";
            ExtractOddLines(inputFilePath, outputFilePath);
        }
        public static void ExtractOddLines(string inputFilePath, string
       outputFilePath)
        {
            var reader = new StreamReader(inputFilePath);
            var writer = new StreamWriter(outputFilePath);
            var counter = 0;

            using (writer)
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (counter % 2 != 0)
                    {
                        writer.WriteLine(line);
                    }
                    counter++;
                    if (line == null)
                    {
                        break;
                    }
                }
            }

        }
    }
}
