using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("Sum of numbers:");
            Console.WriteLine(numbers.Sum());
            Console.WriteLine("~~~~~~~~");

            //TODO: Print the Average of numbers
            Console.WriteLine("Avg of numbers:");
            Console.WriteLine(numbers.Average());
            Console.WriteLine("~~~~~~~~");

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Ascending numbers:");
            var sorted = numbers.OrderBy(num => num);
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("~~~~~~~~");

            //TODO: Order numbers in decsending order adn print to the console
            Console.WriteLine("Descending numbers:");
            var descend = numbers.OrderByDescending(num => num);
            foreach (var item in descend)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("~~~~~~~~");

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Only numbers greater than 6:");
            var greaterThan = numbers.Where(x => x > 6);
            foreach (var item in greaterThan)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("~~~~~~~~");

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Ascending numbers, only first four:");

            foreach (var item in sorted.Take(4))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("~~~~~~~~");

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("Index 4 changed to my age and descending order:");
            numbers[4] = 28;
            foreach (var item in numbers.OrderByDescending(num => num))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("~~~~~~~~");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            Console.WriteLine("Only employees with first name starting with C or S:");
            var nameFilter = employees.Where(x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S').OrderBy(x => x.FirstName);
            foreach (var name in nameFilter)
            {
                Console.WriteLine(name.FullName);
            }
            Console.WriteLine("~~~~~~~~");

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Employees over age 26, ordered by age then first name:");
            var nameAndAge = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);

            foreach (var emp in nameAndAge)
            {
                Console.WriteLine($"Name: {emp.FullName} - Age: {emp.Age}");
            }
            Console.WriteLine("~~~~~~~~");

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            Console.WriteLine("Sum and Avg of employees YOE if YOE is < 10 && age > 35:");
            var yoe = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            Console.WriteLine($"Sum: {yoe.Sum(x => x.YearsOfExperience)} - Avg: { yoe.Average(x => x.YearsOfExperience)}");

            Console.WriteLine("~~~~~~~~");

            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("Added Employee:");
            employees = employees.Append(new Employee("George", "Jungle", 22, 4)).ToList();

            foreach(var item in employees)
            {
                Console.WriteLine($"{item.FirstName} {item.Age}");
            }

            Console.WriteLine("~~~~~~~~");

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
