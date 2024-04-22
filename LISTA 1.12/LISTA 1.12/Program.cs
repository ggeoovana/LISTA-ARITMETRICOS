using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_1._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int a;
            int area;

            Console.Write("digite a base do retangulo: ");
            b= int.Parse(Console.ReadLine());

            Console.Write("digite a altura do retangulo: ");
            a= int.Parse(Console.ReadLine());

            area= b*a;

            Console.Write("a area do retangulo é: ");
            Console.WriteLine(area);

        }
    }
}
