using System;
using System.Globalization;

namespace Retangulo {
    class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return (Largura * 2) + (Altura * 2);
        }

        public double Diagonal() {
            return Math.Sqrt((Math.Pow(Largura, 2.0)) + (Math.Pow(Altura, 2.0)));
        }

        public override string ToString() {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPERÍMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
