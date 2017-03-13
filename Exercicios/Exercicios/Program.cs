using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string comprimento,largura,altura;
            Console.WriteLine("==================Calculo de caixa retangular==================");
            Console.WriteLine("Digite o comprimento da caixa:");
            comprimento = Console.ReadLine();
            Console.WriteLine("Digite a largura da caixa:");
            largura = Console.ReadLine();
            Console.WriteLine("Digite a altura da caixa:");
            altura = Console.ReadLine();

            int volume = Int32.Parse(comprimento) * Int32.Parse(largura) * Int32.Parse(altura);
            Console.WriteLine("o volume da caixa é: {0}",volume);
        }
    }
}
