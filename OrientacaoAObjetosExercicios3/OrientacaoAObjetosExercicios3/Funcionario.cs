using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetosExercicios3
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruo;
        public double Imposto;

        public double SalarioLiquido() 
        { 
            return SalarioBruo - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double porcentagemAumento = porcentagem / 100.00;
            SalarioBruo += SalarioBruo * porcentagemAumento;
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
