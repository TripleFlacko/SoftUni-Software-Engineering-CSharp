using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string
       textFilePath, string outputFilePath)
        {
            using (var readerWords = new StreamReader(wordsFilePath))
            {
                using (var readerText = new StreamReader(textFilePath))
                {
                    using (var writer = new StreamWriter(outputFilePath))
                    {
                        var words = readerWords.ReadToEnd().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        var text = readerText.ReadToEnd();

                        var wordRegex = @"\b\w+\b";

                        var foundWords = Regex.Matches(text, wordRegex);
                        var dictionary = new Dictionary<string, int>();

                        foreach (var word in foundWords)
                        {
                            var stringWord = word.ToString().ToLower();
                            for (int i = 0; i < words.Length; i++)
                            {
                                if (stringWord == words[i])
                                {
                                    if (dictionary.ContainsKey(stringWord))
                                    {
                                        dictionary[stringWord]++;
                                    }
                                    else
                                    {
                                        dictionary[stringWord] = 1;
                                    }
                                }
                            }
                        }
                        var sortedDictionary = dictionary.OrderByDescending(x => x.Value);
                        foreach (var word in sortedDictionary)
                        {
                            writer.WriteLine($"{word.Key} - {word.Value}");
                        }
                    }
                }
            }
        }
    }
}