using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        var lastBackSlash = input.LastIndexOf('\\');
        var lastDot = input.LastIndexOf('.');
        var fileName = input.Substring(lastBackSlash + 1, lastDot - lastBackSlash - 1);
        var fileExtension = input.Substring(lastDot + 1);
        Console.WriteLine($"File name: {fileName}\nFile extension: {fileExtension}");
    }
}