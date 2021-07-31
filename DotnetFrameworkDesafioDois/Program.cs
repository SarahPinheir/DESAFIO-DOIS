using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFrameworkDesafioDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo(a) à Barraca da lentilha!"+"\n"+ "Digite em Kg a quantidade de lentilhas a serem compradas: ");
            double preçoLentilha = 1.5;
            double qtdLentilha = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("O valor a ser pago é "+ (preçoLentilha * qtdLentilha)+" real(is)");
            Console.ReadKey();

        }
    }
}
