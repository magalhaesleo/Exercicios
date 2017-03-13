using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            double tempFahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Temperatura em Fahrenheit e: {0}", tempFahrenheit);
            double tempCelsius = (tempFahrenheit - 32) * (5.0/9.0);
            Console.WriteLine("Temperatura em Celsius e: {0}", tempCelsius);
        }
    }
}
