using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_8._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double celsius;
            Double fahrenheit;

            Console.Write("digite o valor de graus em celsius: ");
            celsius= Double.Parse(Console.ReadLine());

            fahrenheit= celsius * 1.8 + 32;

            Console.WriteLine("a temperatura em fahrenheit é: ");
            Console.WriteLine(fahrenheit);

        }
    }
}
