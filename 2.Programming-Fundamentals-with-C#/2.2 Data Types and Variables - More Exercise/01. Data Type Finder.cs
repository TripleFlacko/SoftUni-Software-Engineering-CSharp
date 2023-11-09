using System;


class Program
{
    static void Main()
    {
        while (true)
        {
            var input = Console.ReadLine();
            if (input == "END") break;

            string checkString; int checkInt; double checkDouble; bool checkBool; char checkChar;

            if (int.TryParse(input, out checkInt)) Console.WriteLine($"{input} is integer type");
            else if (double.TryParse(input, out checkDouble)) Console.WriteLine($"{input} is floating point type");
            else if (bool.TryParse(input, out checkBool)) Console.WriteLine($"{input} is boolean type");
            else if (char.TryParse(input, out checkChar)) Console.WriteLine($"{input} is character type");
            else if (input.GetType() == typeof(string)) Console.WriteLine($"{input} is string type");
        }
    }
}