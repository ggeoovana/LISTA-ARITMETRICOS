using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_10._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dolar;
            double x;
            double reais;

            Console.Write("digite o valor da cotação do dolar: ");
            dolar= double.Parse(Console.ReadLine());

            Console.Write("digite a quantidade de dolares: ");
            x= double.Parse(Console.ReadLine());

            reais= dolar * x;

            Console.Write("o valor em reais é: ");
            Console.WriteLine(reais);
            
        }
    }
}
