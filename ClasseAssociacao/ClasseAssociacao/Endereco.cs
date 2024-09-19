using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAssociacao
{
    internal class Endereco
    {

        public string Logradouro { get; set; }

        public string TipoLogradouro { get; set; }

        public string Localidade { get; set; }

        public string Uf { get; set; }

        public string Bairro { get; set; }

        public int Cep { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }
        
        public Endereco(string logradouro, string tipoLogradouro, string localidade, string uf, string bairro, int cep, int numero, string complemento)
        {
            Logradouro = logradouro;
            TipoLogradouro = tipoLogradouro;
            Localidade = localidade;
            Uf = uf;
            Bairro = bairro;
            Cep = cep;
            Numero = numero;
            Complemento = complemento;
        }

        public override string ToString()
        {
            return 
                $"Dados do endereço:\n {Cep} \n {TipoLogradouro} \n {Logradouro} \n {Localidade} \n {Uf} \n {Bairro}  \n {Numero} \n {Complemento}";
        }
  
    
   }

    


}
