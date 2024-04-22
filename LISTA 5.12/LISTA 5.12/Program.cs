using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_5._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double primeiro;
            Double segundo;
            Double terceiro;
            Double quarto;
            Double resultado;

            Console.Write("digite o primeiro valor: ");
            primeiro= Double.Parse(Console.ReadLine());

            Console.Write(" digite o segundo valor: ");
            segundo= Double.Parse(Console.ReadLine());

            Console.Write("digite o terceiro valor: ");
            terceiro= Double.Parse(Console.ReadLine());

            Console.Write("digite o quarto valor: ");
            quarto= Double.Parse(Console.ReadLine());
           
            resultado= (primeiro + segundo + terceiro + quarto) / 4;

            Console.WriteLine("a media aritmetrica dos quatro valores digitados é: ");
            Console.WriteLine(resultado);

        }
    }
}
