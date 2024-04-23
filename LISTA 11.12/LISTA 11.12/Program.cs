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

            Console.Write("Digite o valor de x para calcular sua potência: ");
            x= Double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de y para ser o expoente de x: ");
            y= Double.Parse(Console.ReadLine());

            resultado= Math.Pow(x, y);

            Console.Write("O valor de x elevado ao valor de y é igual a: ");
            Console.WriteLine(resultado);

        }
    }
}
