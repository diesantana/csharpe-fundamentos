using System;

namespace TipoDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte n1 = 100;
            SByte n2 = 100;
            byte n3 = 255;
            int n4 = 1000;
            int n5 = 2147483647;
            long n6 = 2147483648L;
            bool n7 = true;
            char n8 = 'F';
            char letra = '\u0041';
            float n9 = 4.5f;
            double n10 = 4.5;
            string n11 = "Maria Green";


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine("Genero: " + n8);
            Console.WriteLine(letra);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
            Console.WriteLine(n11);
            Console.WriteLine(int.MaxValue);
        }
    }
}