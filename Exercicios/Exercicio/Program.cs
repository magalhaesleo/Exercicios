using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        static void Exercicio4()
        {
            float KI, KF, CC, DP, GC;
            Console.WriteLine("Digite a kilometragem inicial do veiculo: ");
            KI = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a kilometragem Final do veiculo: ");
            KF = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite quanto foi consumido de combustivel: ");
            CC = float.Parse(Console.ReadLine());
            DP = (KF - KI);
            GC = (DP / CC);
            Console.WriteLine("O desempenho do veiculo foi de {0} KM por litro(s).", GC);
        }
        static void Exercicio5()
        {
            Console.WriteLine("Digite o raio da esfera:");
            double raio = double.Parse(Console.ReadLine());
            double volume = ((4 * 3.14) * (Math.Pow(raio, 3) / 3));
            Console.WriteLine("O volume da esfera é: {0}", volume);

        }
        static void Exercicio6()
        {
            Console.WriteLine("Digite a temperatura em graus Celsius: ");
            double C = double.Parse(Console.ReadLine());
            double F = (((9 * C) + 160) / 5);
            Console.WriteLine("A temperatura em Fahreinheit e: {0}", F);

        }
        static void Main(string[] args)
        {
            Exercicio6();
        }
        
    }
}
