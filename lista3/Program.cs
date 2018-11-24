using System;

namespace lista3
{
    class Program
    {
        static void Main(string[] args)
        {
                 /* Escreva um programa que armazena o valor 999 na variavel A
      e o valor 555 na variavel B. A seguir troque seus conteudos
      fazendo com que o valor que esta em A passe para B e 
      vice-versa ultilizando uma varialvel C para realizar a troca. */

      int A = 999;
      int B = 555;
      int C = 0;
      Console.WriteLine("A ==> " + A );
      Console.WriteLine("B ==> " + B );
      Console.WriteLine("C ==> " + C );
      Console.WriteLine("== TROCA ==");
      C = A;
      A = B;
      B = C;
      Console.WriteLine("A ==> " + A );
      Console.WriteLine("B ==> " + B );
      Console.WriteLine("C ==> " + C );
        }
    }
}
