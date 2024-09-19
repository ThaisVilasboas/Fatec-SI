using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAssociacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Endereco endereco = new Endereco( "Sebatião Bento" , "Avenida" , "São Franisco", "MG" , "Bairro das flores" , 12345678 , 250 , "casa");
            Console.WriteLine(endereco.ToString());
            
            Pessoa pessoa = new Pessoa("Thais", "874688", endereco ,24);
            Console.WriteLine(pessoa.ToString());       
             
            Console.ReadKey();

        }
    }
}
