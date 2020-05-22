using System;
using System.Globalization;

namespace troco_verificado
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double precoProd, dinheiroRecebido, troco, resto;
            int quant;

            Console.Write("Preço unitário do produto: ");
            precoProd = double.Parse(Console.ReadLine(), CI);

            Console.Write("Quantidade comprada: ");
            quant = int.Parse(Console.ReadLine());

            Console.Write("Dinheiro recebido: ");
            dinheiroRecebido = double.Parse(Console.ReadLine(), CI);

            if (dinheiroRecebido >= (precoProd * quant))
            {
                troco = dinheiroRecebido - (precoProd * quant);
                Console.WriteLine("TROCO = "+troco.ToString("f2", CI));
            }
            else
            {
                resto = (precoProd * quant) - dinheiroRecebido;
                Console.WriteLine("DINHEIRO INSUFICIENTE. FALTAM "+resto.ToString("f2", CI)+" REAIS");
            }

        }
    }
}
