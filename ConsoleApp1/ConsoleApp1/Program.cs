using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float Nota1 = 0, Nota2 = 0, Nota3 = 0 ,Media = 0;



            Console.Write($"Digite o valor da sua primeira nota: ");
            Nota1 = float.Parse(Console.ReadLine());

            Console.Write($"Digite o valor da sua segunda nota: ");
            Nota2 = float.Parse(Console.ReadLine());

            Console.Write($"Digite o valor da sua terceira nota: ");
            Nota3 = float.Parse(Console.ReadLine());

            Media = (Nota1 + Nota2 + Nota3) / 3;
            Console.Write($"Sua média final é:{Media} ");

            if (Media >= 0 && Media < 3) 

                Console.Write($" Infelizmente você foi reprovado, estude mais na próxima.");
            
            else
                if (Media < 6)  

                Console.WriteLine ($" Você ficou de exame, estude mais para passar.");

            else 
                if ( Media >= 6 && Media <= 10) 

                Console.Write ($" Parabéns, você conseguiu, foi aprovado. ");

            Console.ReadKey();
        }
    }
}
