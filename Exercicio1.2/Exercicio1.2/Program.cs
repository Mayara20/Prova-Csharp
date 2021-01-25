using System;
using System.Globalization;

namespace Exercicio1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double P = 3.14159;

            area = P * raio * raio;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
