using System;
using System.Globalization;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome;
            double valorHora, pagto;
            int horasTrab;


                Console.WriteLine("Nome:");
                nome = Console.ReadLine();

                Console.WriteLine("Valor por hora: ");
                valorHora = double.Parse(Console.ReadLine(), CI);

                Console.WriteLine("Horas trabalhadas: ");
                horasTrab = int.Parse(Console.ReadLine(), CI);

                pagto = valorHora * horasTrab;


                Console.WriteLine("O pagamento para " + nome + " deve ser " + pagto.ToString("F2", CI));



            Console.ReadKey();
        }
    }
}
