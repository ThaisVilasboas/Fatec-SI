using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAssociacao
{
    internal class Pessoa
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public Endereco Endereco { get; set; }

        public int idade { get; set; }

        public Pessoa(string nome, string telefone, Endereco endereco, int idade)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            this.idade = idade;
        }

        public override string ToString()
        {

            return $"Dados da pessoa:  \n Nome: {Nome} , \n {Endereco} , \n {idade}"; 
                   
         
        }
    }
}
