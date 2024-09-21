using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Calculadora ");
            Console.WriteLine();

            Calculadora calculo = new Calculadora();
            calculo.Somar(4.5, 5.2);
            calculo.Subtrair(6 , 7);


            Console.ReadKey();
        }
    }
}
