using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double d;
            Double area;

            Console.Write("Digite a diagonal do quadrado: ");
            d= Double.Parse(Console.ReadLine());

            area= Math.Pow(d,2)/2;

            Console.Write("A area do quadrado é: ");
            Console.WriteLine(area);

        }
    }
}
