namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection.PortableExecutable;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            var fileExtensions = new Dictionary<string, List<FileInfo>>();

            var files = Directory.GetFiles(inputFolderPath);

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                if (!fileExtensions.ContainsKey(fileInfo.Extension))
                {
                    fileExtensions[fileInfo.Extension] = new List<FileInfo>();
                }
                fileExtensions[fileInfo.Extension].Add(fileInfo);
            }

            var sb = new StringBuilder();

            fileExtensions = fileExtensions.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var fileExtension in fileExtensions)
            {
                sb.AppendLine(fileExtension.Key);

                foreach (var file in fileExtension.Value.OrderBy(x => x.Length))
                {
                    sb.AppendLine($"--{file.Name} - {(double)file.Length / 1024:f3}kb");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            File.WriteAllText(path, textContent);
            return;
        }
    }
}
