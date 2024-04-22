using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_9._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double d;
            Double raio;
            Double area;

            Console.Write("digite o valor do diametro: ");
            d= Double.Parse (Console.ReadLine());

            raio= d/2;

            area= 3.14 * Math.Pow(raio, 2);

            Console.WriteLine("a area do circulo é: ");
            Console.WriteLine(area);

        }
    }
}
