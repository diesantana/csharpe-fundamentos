using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetosEx1
{
    internal class Triangulo
    {
        public double LadoA;
        public double LadoB;
        public double LadoC;

        public double Area()
        {
            double p = (LadoA + LadoB + LadoC) / 2.0;
            double area = Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));
            return area;
        }
    }
}
