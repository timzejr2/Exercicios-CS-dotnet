using System;
using System.Globalization;

namespace ContaBancaria {
    class Program {
        static void Main(string[] args) {

            Conta conta;

            Console.Write("Entre o Numero da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                conta = new Conta(numero, titular, saldo);
            }
            else {
                conta = new Conta(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Qual a quantia para depósito? ");
            double quantia = double.Parse(Console.ReadLine());

            conta.Deposito(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            quantia = 0;

            Console.Write("Qual a quantidade para saque? ");
            quantia = double.Parse(Console.ReadLine());

            conta.Saque(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

        }
    }
}
