using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetosProblema3
{
    internal class Calculadora
    {
        public double Raio;
        public double PI = 3.14;

        public double Circunferencia()
        {
            return 2.0 * PI * Raio;
        }

        public double Volume()
        {
            return 4.0 / 3.0 * PI * Math.Pow(Raio, 3);
        }

    }
}
