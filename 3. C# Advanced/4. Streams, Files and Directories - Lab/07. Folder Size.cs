using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";
            GetFolderSize(folderPath, outputPath);
        }
        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long totalSize = CalculateTotalSize(folderPath);
        }

        private static long CalculateTotalSize(string folderPath)
        {
            long totalSize = 0;
            string[] files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                var fileInfo = new FileInfo(file);
                totalSize += fileInfo.Length;

            }

            string[] directories = Directory.GetDirectories(folderPath);

            foreach (string directory in directories)
            {
                totalSize += CalculateTotalSize(directory);
            }

            return totalSize;
        }
    }
}