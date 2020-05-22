using System;
using System.Globalization;

namespace operadora
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int minutos;
            double valorPagar;

            Console.Write("Digite a quantidade de minutos: ");
            minutos = int.Parse(Console.ReadLine());

            if (minutos <= 100)
            {
                valorPagar = 50.00;
                Console.WriteLine("Valor a pagar: R$ "+valorPagar.ToString("f2", CI));
            }
            else
            {
                valorPagar = (minutos - 100) * 2.00 + 50.00;
                Console.WriteLine("Valor a pagar: R$ "+valorPagar.ToString("f2", CI));
            }
        }
    }
}
