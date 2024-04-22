using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_6._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double valor1;
            Double valor2;
            Double resultado;

            Console.Write("digite o primeiro valor: ");
            valor1= Double.Parse(Console.ReadLine());

            Console.Write("digite o segundo valor: ");
            valor2= Double.Parse(Console.ReadLine());

            resultado= Math.Sqrt(valor1*valor2);

            Console.WriteLine("o valor da media geometrica é: ");
            Console.WriteLine(resultado);

        }
    }
}
