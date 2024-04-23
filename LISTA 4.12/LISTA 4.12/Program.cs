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

            Console.Write("Digite a base do triângulo: ");
            b= Double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do triângulo: ");
            a= Double.Parse(Console.ReadLine());

            area= (b*a)/2;

            Console.Write("O valor da area do triângulo é: ");
            Console.WriteLine(area);

        }
    }
}
