using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMetodosAbstratos.Entities
{
    internal class Individual : Taxpayer
    {

        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxCal()
        {
            double tax = 0.0;
            if(AnnualIncome < 20000.00)
            {
                tax = AnnualIncome * 0.15;
            }
            else
            {
                tax = AnnualIncome * 0.25;
            }
            if(HealthExpenditures > 0)
            {
                tax -=  HealthExpenditures /  2.0;
            }
            return tax;
        }
    }
}
