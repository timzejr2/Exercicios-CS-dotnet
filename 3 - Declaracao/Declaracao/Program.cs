using System;

namespace Declaracao {
    class Program {
        static void Main(string[] args) {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(f);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            f.Aumento = double.Parse(Console.ReadLine());
            f.CalculoNovoSalario(f.Aumento);

            Console.WriteLine(f);

        }
    }
}
