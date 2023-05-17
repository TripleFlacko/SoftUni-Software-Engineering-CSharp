using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int hours = numberOfProjects * 3;

            Console.WriteLine($"The architect {architectName} will need {hours} hours to complete {numberOfProjects} project/s.");
        }
    }
}