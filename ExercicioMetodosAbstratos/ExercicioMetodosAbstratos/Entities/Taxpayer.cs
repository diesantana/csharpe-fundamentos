using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMetodosAbstratos.Entities
{
    internal abstract class Taxpayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Taxpayer()
        {
        }
        public Taxpayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double TaxCal();

        public override string ToString()
        {
            return Name + ": $ " + TaxCal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
