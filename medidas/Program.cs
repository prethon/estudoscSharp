﻿using System;
using System.Globalization;

namespace medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double a, b, c, quadrado, triangulo, trapezio;

            Console.Write("Digite a medida A: ");
            a = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a medida B: ");
            b = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a medida C: ");
            c = double.Parse(Console.ReadLine(), CI);

            quadrado = a * a;
            triangulo = (a * b) / 2;
            trapezio = ((a + b) * c) / 2;

            Console.WriteLine("AREA DO QUADRADO = "+quadrado.ToString("f4", CI));
            Console.WriteLine("AREA DO TRIANGULO  = "+triangulo.ToString("f4", CI));
            Console.WriteLine("AREA DO TRAPEZIO = "+trapezio.ToString("f4", CI));
            

        }
    }
}