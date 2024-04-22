using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_11._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double x;
            Double y;
            Double resultado;

            Console.Write("digite o valor de x: ");
            x= Double.Parse(Console.ReadLine());

            Console.Write("digite o valor de y: ");
            y= Double.Parse(Console.ReadLine());

            resultado= Math.Pow(x, y);

            Console.Write("o valor de x elevado ao valor de y é igual a: ");
            Console.WriteLine(resultado);

        }
    }
}
