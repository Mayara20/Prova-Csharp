using System;
using System.Globalization;

namespace Exercicio2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, pedido;
            double tot;

            string[] L = Console.ReadLine().Split(' ');
            codigo = int.Parse(L[0]);
            pedido = int.Parse(L[1]);
            
            if (codigo == 1) {
                tot = pedido * 4.00;
            }
            else if (codigo == 2) {
                tot = pedido * 4.50;
            }
            else if (codigo == 3) {
                tot = pedido * 5.00;
            }
            else if (codigo == 4) {
                tot = pedido * 2.00;
            }
            else {
                tot = pedido * 1.50;
            }
            Console.WriteLine("Total: R$ " + tot.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
