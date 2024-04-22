using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_4._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double b;
            Double a;
            Double area;

            Console.Write("digite a base do triangulo: ");
            b= Double.Parse(Console.ReadLine());

            Console.Write("digite a altura do triagulo: ");
            a= Double.Parse(Console.ReadLine());

            area= b*a /2;

            Console.Write("valor da area do triangulo é: ");
            Console.WriteLine(area);

        }
    }
}
