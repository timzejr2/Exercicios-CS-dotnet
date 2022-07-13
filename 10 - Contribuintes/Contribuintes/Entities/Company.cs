using System;
using System.Collections.Generic;
using System.Text;

namespace Contribuintes.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double total;
            if (NumberOfEmployees <= 10)
            {
                total = AnualIncome + (AnualIncome * 0.16);
            }
            else
            {
                total = AnualIncome + (AnualIncome * 0.14);
            }
            return total;
        }
    }
}
