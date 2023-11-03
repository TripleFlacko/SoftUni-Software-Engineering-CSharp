using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";
            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }
        public static void SplitBinaryFile(string sourceFilePath, string
       partOneFilePath, string partTwoFilePath)
        {
            using (var sourceStream = new FileStream(sourceFilePath, FileMode.Open))
            using (var part1Stream = new FileStream(partOneFilePath, FileMode.Create))
            using (var part2Stream = new FileStream(partTwoFilePath, FileMode.Create))
            {
                var fileSize = sourceStream.Length;
                var part1Size = (int)Math.Ceiling((double)fileSize / 2);
                var buffer = new byte[1024];

                int bytesRead;
                int bytesWritten = 0;

                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    if (bytesRead + bytesWritten <= part1Size)
                    {
                        part1Stream.Write(buffer, 0, bytesRead);
                    }
                    else
                    {
                        part2Stream.Write(buffer, 0, bytesRead);
                    }
                    bytesWritten += bytesRead;
                }
            }


        }
        public static void MergeBinaryFiles(string partOneFilePath, string
       partTwoFilePath, string joinedFilePath)
        {
            using (var part1Stream = new FileStream(partOneFilePath, FileMode.Open))
            using (var part2Stream = new FileStream(partTwoFilePath, FileMode.Open))
            using (var joinedFileStream = new FileStream(joinedFilePath, FileMode.Create))
            {
                var buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = part1Stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    joinedFileStream.Write(buffer, 0, bytesRead);
                }

                while ((bytesRead = part2Stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    joinedFileStream.Write(buffer, 0, bytesRead);

                }
            }
        }
    }
}