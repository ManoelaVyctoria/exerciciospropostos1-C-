using System;
using System.Globalization;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, area, pi=3.14159;

            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0],CultureInfo.InvariantCulture);
            b = double.Parse(vet[1],CultureInfo.InvariantCulture);
            c = double.Parse(vet[2],CultureInfo.InvariantCulture);

            // A) A ÁREA DO TRIÂNGULO QUE TEM A POR BASE E C POR ALTURA.

            Console.WriteLine("TRIANGULO: "+ (area = (a*c)/2).ToString("F3",CultureInfo.InvariantCulture));

            // B) A ÁREA DO CÍRCULO DE RAIO C. (PI=3.14159)

            Console.WriteLine("CIRCULO: " + (area = pi * c * c).ToString("F3", CultureInfo.InvariantCulture));

            // C) A ÁREA DO TRAPÉZIO QUE TEM A E B POR BASES E C POR ALTURA. 

            Console.WriteLine("TRAPÉZIO: " + (area = (a+b)/2 *c).ToString("F3", CultureInfo.InvariantCulture));

            // D) A ÁREA DO QUADRADO QUE TEM LADO B. 

            Console.WriteLine("QUADRADO: " + (area = b*b).ToString("F3", CultureInfo.InvariantCulture));

            //E) A ÁREA DO RETÂNGULO QUE TEM LADOS A E B. 

            Console.WriteLine("RETÂNGULO: " + (area = a * b).ToString("F3", CultureInfo.InvariantCulture));
            
        }
    }
}
