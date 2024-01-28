using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaParams
{
    internal class Calculator
    {
        public static double Sum(params double[] numbers)
        {
            double sum = 0.0;
            foreach (double number in numbers) sum += number;
            return sum;
        }
        
    }
}
