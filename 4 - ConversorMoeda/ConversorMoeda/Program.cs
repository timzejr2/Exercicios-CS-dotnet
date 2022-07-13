using System;
using System.Globalization;

namespace ConversorMoeda {
    class Program {
        static void Main(string[] args) {

            double cotacao;
            double quantidade;

            Console.Write("Qual é a cotação do dólar? ");
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversirDeMoeda.VPagar(cotacao, quantidade).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
