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

            Console.WriteLine(" \n Calculadora: ");


            Console.WriteLine($"  _____________");
            Console.WriteLine($" |           / |" );
            Console.WriteLine($" |_____________|");
            Console.WriteLine($" |  7  8  9  * |");
            Console.WriteLine($" |_____________|");
            Console.WriteLine($" |  4  5  6  - |" );
            Console.WriteLine($" |_____________|");
            Console.WriteLine($" |  1  2  3  + | ");
            Console.WriteLine($" |_____________|");




            Console.WriteLine("\n  OPERAÇÕES");
            
            Console.WriteLine($"\n  [ 1 ] ADIÇÃO ");
            Console.WriteLine($"  [ 2 ] SUBTRAÇÃO ");
            Console.WriteLine($"  [ 3 ] MULTIPLICAÇÃO ");
            Console.WriteLine($"  [ 4 ] DIVISÃO ");
           
            Console.Write(" \n  Digite o número dá operação que deseja realizar: ");
            
            int operacao = int.Parse(Console.ReadLine());



            Console.Write(" \n  Digite o  primeiro número da operação: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.Write(" \n  Digite o  segundo número da  operação: ");
            double numero2 = double.Parse(Console.ReadLine());

            Calculadora calculo = new Calculadora();

            switch (operacao)

            {
                    case 1:

                     calculo.Somar(numero1,numero2);

                    break;

                    case 2:

                     calculo.Subtrair(numero1 ,numero2);

                    break;

                    case 3:

                     calculo.Multiplicar(numero1,numero2);

                    break;

                    case 4:

                     calculo.Dividir(numero1,numero2);

                    break; 

            }



            Console.ReadKey();
        }
    }
}
