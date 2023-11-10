using System;
using System.Collections.Generic;

namespace WithoutLINQueries
{
    class Program
    {
        public static void Main(string[] args)
        {
            //list of employees
            var employees = new List<Employee>()
            {
                new Employee() { FullName = "Rossco", Age = 100, Salary = 1m },
                new Employee() { FullName = "Donks", Age = 10, Salary = 100m },
                new Employee() { FullName = "Monks", Age = 1001, Salary = 1000m },
                new Employee() { FullName = "Phoebe", Age = 2, Salary = 30m }
            };

            //store filtered employee here to sort them later
            var filteredEmployees = new List<Employee>();

            //find employees who are 28yrs or younger and earn salary less than £200
            foreach (var employee in employees)
            {
                if (employee.Age <= 28 && employee.Salary <= 200)
                {
                    filteredEmployees.Add(employee);
                }
            }
            //sort filteredEmployees in  alphabetical order. Provide the field based on which you want to sort - Example FullName
            filteredEmployees.Sort((x, y) => x.FullName.CompareTo(y.FullName));

            //now output the results
            foreach (var employee in filteredEmployees)
            {
                Console.WriteLine(employee.FullName);
            }

        }
    }
}