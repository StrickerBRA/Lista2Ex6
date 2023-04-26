using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Calculo de IMC:");
            Console.Write("Digite o valor do peso:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura:");
            b = double.Parse(Console.ReadLine());

            c = a / Math.Pow(b, 2);

            Console.WriteLine($"Com o valor de {c}.");

            if (c<20) { Console.WriteLine("Abaixo do peso."); }
            if (20<=c && c<25) { Console.WriteLine("Peso ideal."); }
            if(c>=25) { Console.WriteLine("Acima do Peso"); }
        }
    }
}
