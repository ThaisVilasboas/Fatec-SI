



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaçãoOrientada001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine(pessoa.ToString());

            Console.Write(" Informe o nome da pessoa: ");
            pessoa.setNome(Console.ReadLine());

            Console.Write(" Informe o sexo da pessoa (M/F): ");
            string aux = Console.ReadLine();
            pessoa.setSexo(aux);

            Console.Write(" Informe a idade da pessoa: ");
            pessoa.setIdade(int.Parse(Console.ReadLine()));

            //Console.WriteLine($" \n O nome da pessoa é : {pessoa.getNome()}");
            //Console.WriteLine($" A idade da pessoa é : {pessoa.getIdade()}"); 
            //Console.WriteLine($" O sexo da pessoa é : {pessoa.getSexo()}");

            Console.Write(pessoa.ToString());

            Pessoa pessoa1;
            pessoa1 = new Pessoa();


            Console.ReadKey();
        }            
            
    }
}
