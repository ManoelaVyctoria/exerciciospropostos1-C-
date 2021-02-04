using System;
using System.Globalization;
namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1 = int.Parse(Console.ReadLine());
            int qtd1 = int.Parse(Console.ReadLine());
            double valor1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            int codigo2 = int.Parse(Console.ReadLine());
            int qtd2 = int.Parse(Console.ReadLine());
            double valor2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double total;

            total = valor1 * qtd1 + valor2 * qtd2;

            Console.WriteLine("VALOR A PAGAR: R$"+ total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
