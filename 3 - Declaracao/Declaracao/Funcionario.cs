using System;
using System.Collections.Generic;
using System.Text;

namespace Declaracao {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double Aumento;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void CalculoNovoSalario(double Porcentagem) {
            SalarioBruto += SalarioBruto * (Aumento / 100);
        }

        public override string ToString() {
            return Nome
                + ", $ "
                + SalarioLiquido().ToString("F2");
        }
    }
}
