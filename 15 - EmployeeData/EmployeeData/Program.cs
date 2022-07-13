using System;
using Entities;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EmployeeData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double compSalary;
            string path;
            List<Employee> list = new List<Employee>();

            Console.Write("Enter full file path: ");
            path = Console.ReadLine();
            Console.Write("Enter salary: ");
            compSalary = double.Parse(Console.ReadLine());

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.WriteLine("Email of people whose salary is more than " + compSalary + ": ");
            var emails = list.Where(p => p.Salary > compSalary).OrderBy(p => p.Email).Select(p => p.Email);
            foreach(string email in emails)
            {
                Console.WriteLine(email);
            }

            var salaryM = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + salaryM.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
