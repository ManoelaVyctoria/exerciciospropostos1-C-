using System;
using System.Globalization;
namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario;

            salario = valorhora * horas;

            Console.WriteLine("NUMBER = " + numero );
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture ));
        }
    }
}
