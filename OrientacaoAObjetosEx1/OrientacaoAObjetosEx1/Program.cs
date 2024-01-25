﻿using System;
using System.Globalization;

namespace OrientacaoAObjetosEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Triangulo x = new Triangulo();
            x.LadoA = a;
            x.LadoB = b;
            x.LadoC = c;

            Console.WriteLine("Entre com as medidas do triângulo Y");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Triangulo y = new Triangulo();
            y.LadoA = a;
            y.LadoB = b;
            y.LadoC = c;

            double areaX = CalcArea(x);
            double areaY = CalcArea(y);
        
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

        static double CalcArea(Triangulo triangulo)
        {
           double p = (triangulo.LadoA + triangulo.LadoB + triangulo.LadoC) / 2;
           double area = Math.Sqrt(p * (p - triangulo.LadoA) * (p - triangulo.LadoB) * (p - triangulo.LadoC));
            return area;
        }
    }
}