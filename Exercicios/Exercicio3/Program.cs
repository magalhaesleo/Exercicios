using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio do cilindro: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura do cilindro: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double v = ((3.14 * (r * r)) * a);
            Console.WriteLine("O volume do cilindro e: {0}",v);

        }
    }
}
