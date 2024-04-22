using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_7._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double milhas;
            Double km;

            Console.Write("digite o valor em milhas: ");
            milhas= Double.Parse(Console.ReadLine());

            km= milhas * 1852;

            Console.WriteLine("o valor em quilometros é: ");
            Console.WriteLine(km);
        }
    }
}
