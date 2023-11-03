namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (var inputFS = new FileStream(inputFilePath, FileMode.Open))
            using (var outputFS = new FileStream(outputFilePath, FileMode.Create))
            {
                var buffer = new byte[1024];
                int bytesRead = 0;

                while ((bytesRead = inputFS.Read(buffer, 0, buffer.Length)) > 0)
                {
                    outputFS.Write(buffer, 0, bytesRead);
                }
            }
            return;
        }
    }
}
