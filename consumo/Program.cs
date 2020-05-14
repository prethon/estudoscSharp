using System;
using System.Globalization;

namespace consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int dist;
            double consumo, gasto;

            Console.WriteLine("Distancia percorrida: ");  
            dist = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Combustivel gasto: ");
            gasto = double.Parse(Console.ReadLine(), CI);  

            consumo = dist / gasto;

            Console.WriteLine("Consumo medio = "+consumo.ToString("f3", CI));
                 


        }
    }
}
