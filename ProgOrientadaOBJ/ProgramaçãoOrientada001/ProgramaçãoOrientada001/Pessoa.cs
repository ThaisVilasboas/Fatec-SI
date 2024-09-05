using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaçãoOrientada001
{
    internal class Pessoa
    {
        String nome;
        int idade;
        string sexo;

        public Pessoa() 
        {
            nome = " Nome ";
            idade =  0;
            sexo = " M/F ";
        }

        public void setNome(string n)
        {
            nome = n;
        }
        public string getNome() 
        { 
            return nome;
        }
        public void setIdade(int idade) 
        
        {
             this.idade = idade;

        }
        public int getIdade() 
        { 
             return idade;
        }
        public void setSexo(string sexo)
        
        { 
            this.sexo = sexo;
        }
        public string getSexo() 
      
        { 
            return sexo;

        }

        public override string ToString() 
        
        { 

            return " \nNome:  " +nome+ "\nIdade: " +idade+   " \nSexo: " + sexo +" \n ";

        }
        
    }


}
