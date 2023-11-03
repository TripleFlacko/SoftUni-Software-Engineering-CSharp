using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath,
           outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string
       secondInputFilePath, string outputFilePath)
        {
            using (var reader1 = new StreamReader(firstInputFilePath))
            {
                using (var reader2 = new StreamReader(secondInputFilePath))
                {
                    using (var writer = new StreamWriter(outputFilePath))
                    {
                        var counter = 0;
                        var text1 = reader1.ReadToEnd().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        var text2 = reader2.ReadToEnd().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                        var length = text1.Length > text2.Length ? text1.Length : text2.Length;

                        for (int i = 0; i < length; i++)
                        {
                            if (i < text1.Length)
                            {
                                writer.WriteLine(text1[i]);
                            }
                            if (i < text2.Length)
                            {
                                writer.WriteLine(text2[i]);
                            }
                        }
                    }
                }
            }
        }
    }
}