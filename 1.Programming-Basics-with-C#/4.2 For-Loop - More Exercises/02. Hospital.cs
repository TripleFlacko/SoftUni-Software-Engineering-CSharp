using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int treatedPatients = 0;
            int untreatedPatients = 0;
            int doctors = 7;

            for (int i = 2; i <= period + 1; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (patients <= doctors)
                {
                    treatedPatients += patients;
                }
                else
                {
                    untreatedPatients += patients - doctors;
                    treatedPatients += doctors;
                }

                if (i % 3 == 0)
                {
                    if (untreatedPatients > treatedPatients)
                    {
                        doctors++;
                    }
                }
            }

            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}