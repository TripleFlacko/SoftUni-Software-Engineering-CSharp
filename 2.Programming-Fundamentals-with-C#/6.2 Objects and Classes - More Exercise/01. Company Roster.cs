using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int numberLines = int.Parse(Console.ReadLine());
        var employees = new List<Employee>();

        for (int i = 0; i < numberLines; i++)
        {
            var input = Console.ReadLine().Split().ToList();
            string name = input[0];
            decimal salary = decimal.Parse(input[1]);
            string department = input[2];

            Employee employee = new Employee(name, salary, department);
            employees.Add(employee);
        }

        var highestSalary = employees
            .GroupBy(x => x.Department)
            .OrderByDescending(x => x.Average(x => x.Salary))
            .First();

        Console.WriteLine($"Highest Average Salary: {highestSalary.Key}");

        foreach (var employee in highestSalary.OrderByDescending(e => e.Salary))
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
        }
    }
}
class Employee
{
    public Employee(string name, decimal salary, string department)
    {
        Name = name;
        Salary = salary;
        Department = department;
    }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }
}
