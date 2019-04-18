using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.CompanyRoster
{
    public class StartUp
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>();

            int EmployeesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < EmployeesCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                double salary = double.Parse(input[1]);
                string position = input[2];
                string department = input[3];

                if (input.Length == 4)
                {
                    Employee employee = new Employee(name, salary, position, department);
                    employees.Add(employee);
                }
                else if (input.Length == 5)
                {
                    int age = 0;

                    bool employeeIsWithAge = int.TryParse(input[4], out age);

                    if (employeeIsWithAge)
                    {
                        Employee employee = new Employee(name, salary, position, department, age);
                        employees.Add(employee);
                    }
                    else
                    {
                        string email = input[4];
                        Employee employee = new Employee(name, salary, position, department, email);
                        employees.Add(employee);
                    }
                }
                else
                {
                    string email = input[4];
                    int age = int.Parse(input[5]);
                    Employee employee = new Employee(name, salary, position, department, email, age);
                    employees.Add(employee);
                }
            }

            string bestDepartment = employees.GroupBy(x => x.Department).OrderByDescending(x => x.Average(s => s.Salary))
                .FirstOrDefault().Key;

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");

            foreach (var employee in employees.Where(x => x.Department == bestDepartment).OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
