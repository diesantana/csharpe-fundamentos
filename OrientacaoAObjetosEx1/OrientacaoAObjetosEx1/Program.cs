using System;
using System.Globalization;

namespace OrientacaoAObjetosEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X");
            double xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
            double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y");
            double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = calcArea(xA, xB, xC);
            double areaY = calcArea(yA, yB, yC);
        
            Console.WriteLine($"Àrea de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Àrea de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }

        static double calcArea(double ladoA, double ladoB, double ladoC)
        {
           double p = (ladoA + ladoB + ladoC) / 2;
           double area = Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
            return area;
        }
    }
}