﻿using System;

namespace Exercicio3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;

            senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
               if (senha == 2002) {
                Console.WriteLine("Acesso Permitido");
            }
            
          }

        }
    }
}
