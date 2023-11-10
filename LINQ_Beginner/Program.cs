using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqQueries
{
    class Program
    {
        public static void Main(string[] args)
        {
            var employees = new List<Employee>()
            {
                new Employee() {FullName = "Mou", Age = 10, Salary = 1000},
                new Employee() {FullName = "Monks", Age = 1, Salary = 10},
                new Employee() {FullName = "Moana", Age = 2, Salary = 20},
                new Employee() {FullName = "Moa", Age = 10, Salary = 10}
            };
            //LINQ query
            /* var filteredEmployees = from employee in employees
                                    where employee.Age <= 28 && employee.Salary <= 200
                                    orderby employee.FullName
                                    select employee; */

            //using Extension method syntax
            var filteredEmployees = employees
                .Where(x => x.Age <= 28 && x.Salary <= 200)
                .OrderBy(x => x.FullName);

            foreach (var employee in filteredEmployees)
            {
                Console.WriteLine(employee.FullName);
            }

            var salariesandage = from employee in employees
                                 select new //encapsulated in anonymous type
                                 {
                                     employee.Salary,
                                     employee.Age
                                 };
            foreach (var employee in salariesandage)
            {
                Console.WriteLine(employee);
            }

            var numbers = new List<int>()
                                 {
                1,2,3,4,5,60,22,45,11,12,02,06
                                 };
            var evenNumbers = from number in numbers
                              where number % 2 == 0 //select even numbers
                              orderby number descending
                              select number;
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            var employeeNewSalary = from employee in employees
                                    let increasedSalary = employee.Salary * 2m
                                    //projecttion using named type
                                    select new Employee()
                                    {
                                        FullName = employee.FullName,
                                        Age = employee.Age,
                                        Salary = increasedSalary //use the above variable
                                    };
            foreach (var employee in employeeNewSalary)
            {
                Console.WriteLine($"{employee.FullName}: {employee.Salary}. ");
            }

        }
    }
}