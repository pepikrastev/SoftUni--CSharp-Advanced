using System;
using System.Collections.Generic;
using System.Text;

namespace P06.CompanyRoster
{
    public class Employee
    {
        private string name;
        private double salary;
        string position;
        string department;
        string email;
        int age;

       

        public Employee(string name, double salary, string position, string department, string email, int age)
            :this(name, salary, position, department)
        {
            this.Email = email;
            this.Age = age;
        }

        public Employee(string name, double salary, string position, string department, string email)
            : this(name, salary, position, department)
        {
            this.Email = email;
        }

        public Employee(string name, double salary, string position, string department, int age) 
            :this(name, salary, position, department)
        {
            this.Age = age;
        }

        public Employee(string name, double salary, string position, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = "n/a";
            this.Age = -1;
        }

        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        public string Position { get => position; set => position = value; }
        public string Department { get => department; set => department = value; }
        public string Email { get => email; set => email = value; }
        public int Age { get => age; set => age = value; }
    }
}
