using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_2._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double aresta;
            Double area;
           
            Console.Write("Digite a aresta do quadrado: ");
            aresta= Double.Parse(Console.ReadLine());

            area= Math.Pow(aresta,2);

            Console.Write("A area do quadrado é: ");
            Console.WriteLine(area);

        }
    }
}
