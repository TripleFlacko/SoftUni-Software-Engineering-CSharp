using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";
            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string
       bytesFilePath, string outputPath)
        {
            using (var stream = new FileStream(binaryFilePath, FileMode.Open))
            {
                using (var readerBytes = new StreamReader(bytesFilePath))
                {
                    using (var writer = new StreamWriter(outputPath))
                    {
                        var bytes = File.ReadAllBytes(bytesFilePath);

                        var data = new byte[stream.Length];
                        stream.Read(data, 0, data.Length);

                        for (int i = 0; i < data.Length; i++)
                        {
                            for (int j = 0; j < bytes.Length; j++)
                            {
                                if (data[i] == bytes[j])
                                {
                                    writer.Write(bytes[j]);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}