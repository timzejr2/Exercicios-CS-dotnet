using System;
using System.Collections.Generic;
using System.Text;

namespace Contribuintes.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpeditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpeditures)
            : base(name, anualIncome)
        {
            HealthExpeditures = healthExpeditures;
        }

        public override double Tax()
        {
            double total;
            if (HealthExpeditures < 20000)
            {
                total = HealthExpeditures + (HealthExpeditures * 0.15);
            }
            else
            {
                total = HealthExpeditures + (HealthExpeditures * 0.25);
            }
            return total;
        }
    }
}
