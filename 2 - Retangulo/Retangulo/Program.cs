using System;
using System.Globalization;

namespace Retangulo {
    class Program {
        static void Main(string[] args) {
            
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");

            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine(r.Area());
            //Console.WriteLine(r.Perimetro());
            //Console.WriteLine(r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(r);
        }
    }
}
