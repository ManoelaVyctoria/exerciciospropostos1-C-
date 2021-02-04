using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int n1 = 10;
             int n2 = 30;

             Console.WriteLine("SOMA = " + (n1 + n2));

             int n3 = -30;
             int n4 = 10;

             Console.WriteLine("SOMA = "+ (n3+n4));

             int n5 = 0;
             int n6 = 0;

             Console.WriteLine("SOMA = " + (n5+n6));
            */

            int a, b, soma;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}
