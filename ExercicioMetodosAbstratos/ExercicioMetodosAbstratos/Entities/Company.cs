using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMetodosAbstratos.Entities
{
    internal class Company : Taxpayer
    {

        public int NumberEmployees { get; set; }


        public Company(string name, double annualIncome, int numberEmployees  ) : base(name, annualIncome)
        {
            NumberEmployees = numberEmployees;
        }
        public override double TaxCal()
        {
            double tax = 0.0;
            if(NumberEmployees > 10 )
            {
                tax = AnnualIncome * 0.14;
            }
            else
            {
                tax = AnnualIncome * 0.16;
            }

            return tax;
        }
    }
}
