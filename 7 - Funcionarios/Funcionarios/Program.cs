using System;
using System.Collections.Generic;

namespace Funcionarios {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("How many emoployees will be registred? ");
            int quant = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i=0; i<quant; i++) {
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                funcionarios.Add(new Funcionario(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Funcionario alt = funcionarios.Find(x => x.Id == searchId);

            if(alt != null) {
                Console.Write("Enter the porcentage: ");
                double percentage = double.Parse(Console.ReadLine());
                alt.increaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exists!");
            }

            Console.WriteLine();
            Console.WriteLine("Updates list employees: ");
            foreach(Funcionario obj in funcionarios) {
                Console.WriteLine(obj);
            }
        }
    }
}
