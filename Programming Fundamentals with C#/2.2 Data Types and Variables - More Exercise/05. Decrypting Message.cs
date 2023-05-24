using System;

class Program
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());
        string decryptedMessage = string.Empty;

        for (int i = 0; i < lines; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            letter += (char)key;
            decryptedMessage += letter;
        }
        Console.WriteLine(decryptedMessage);
    }
}