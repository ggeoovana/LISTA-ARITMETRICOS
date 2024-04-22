using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_12._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double produto1;
            double produto2;
            double produto3;
            double produto4;
            double produto5;
            double total;
            double pagamento;
            double troco;

            Console.Write("digite o valor do produto: ");
            produto1= double.Parse(Console.ReadLine());

            Console.Write("digite o valor do produto: ");
            produto2= double.Parse(Console.ReadLine());

            Console.Write("digite o valor do produto: ");
            produto3= double.Parse(Console.ReadLine());

            Console.Write("digite o valor do produto: ");
            produto4= double.Parse(Console.ReadLine());

            Console.Write("digite o valor do produto: ");
            produto5= double.Parse(Console.ReadLine());

            total= produto1 + produto2 + produto3 + produto4 + produto5;

            Console.Write("total: ");
            Console.WriteLine(total);

            Console.Write("digite o valor do pagamento: ");
            pagamento= double.Parse(Console.ReadLine());

            troco= pagamento - total;

            Console.Write("o valor do troco é: ");
            Console.WriteLine(troco);

        }
    }
}
