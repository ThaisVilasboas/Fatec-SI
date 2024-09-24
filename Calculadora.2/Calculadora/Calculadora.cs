using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora


    {

        public void Somar(double x, double y)

        {

            Console.WriteLine($" \n  {x} + {y} = {x + y} ");

        }

        public void Subtrair(double x, double y)

        {

            Console.WriteLine($" \n  {x} - {y} = {x - y} ");

        }

        public void Dividir(double x, double y)

        {

            Console.WriteLine($" \n  {x} / {y} = {x / y} ");

        }
        public void Multiplicar(double x, double y)

        {

            Console.WriteLine($" \n  {x} * {y} = {x * y} ");

        }



    }
}
