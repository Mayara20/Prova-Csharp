using System;
using System.Globalization;

namespace Exercicio1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2;
            double quant1, quant2, valor1, valor2, preco;

            string[] S = Console.ReadLine().Split(' ');
            cod1 = int.Parse(S[0]);
            quant1 = int.Parse(S[1]);
            valor1 = double.Parse(S[2], CultureInfo.InvariantCulture);

            S = Console.ReadLine().Split(' ');
            cod2 = int.Parse(S[0]);
            quant2 = int.Parse(S[1]);
            valor2 = double.Parse(S[2], CultureInfo.InvariantCulture);

            preco = valor1 * quant1 + valor2 * quant2;

            Console.WriteLine("VALOR A PAGAR: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
