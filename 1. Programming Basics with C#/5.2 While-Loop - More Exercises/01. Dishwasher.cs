using System;


namespace _01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());

            int mililitersWeHave = bottles * 750;

            int dishes = 0, pots = 0;

            int counter = 0;

            while (true)
            {
                if (mililitersWeHave < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(mililitersWeHave)} ml. more necessary!");
                    break;
                }

                int liquidToUse;
                string command = Console.ReadLine();


                if (command == "End")
                {
                    Console.WriteLine($"Detergent was enough!\n{dishes} dishes and {pots} pots were washed.\nLeftover detergent {mililitersWeHave} ml.");
                    break;
                }

                int number = int.Parse(command);

                counter++;

                if (counter % 3 == 0)
                {
                    pots += number;
                    mililitersWeHave -= number * 15;

                }
                else
                {
                    dishes += number;
                    mililitersWeHave -= number * 5;
                }

            }
        }
    }
}