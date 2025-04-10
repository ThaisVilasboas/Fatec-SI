namespace TempoDeVida
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int anoNascimento = 0;

            int mesNascimento = 0;

            int diaNascimento = 0;

            int idade = 0;

            int diasVida = 0;
            
            int mesesVida = 0;

            int anosVida = 0;

            Console.WriteLine(" QUANTOS TEMPO EU TENHO DE VIDA!? \n ");

            Console.WriteLine(" De acordo com a sua data de nascimento vamos calcular quantos dias, meses e anos você tem desde o seu nascimento.\n");

            Console.Write(" DIGITE O DIA DO SEU ANIVERSÁRIO:");

            diaNascimento = int.Parse(Console.ReadLine());

            Console.Write(" DIGITE O MÊS DO SEU ANIVERSÁRIO:");

            mesNascimento = int.Parse(Console.ReadLine());

            Console.Write(" DIGITE O ANO DO SEU ANIVERSÁRIO:");

            anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine(" \n DATA DE NASCIMENTO:\n");

            Console.WriteLine( diaNascimento + "/" + mesNascimento + "/" + anoNascimento + "\n");

            
            DateTime hoje = DateTime.Now;

            Console.WriteLine(" \n DATA DE HOJE:\n");

            Console.WriteLine(hoje.ToString(" dd/MM/yyyy" ));

           

            int dias = int.Parse(hoje.ToString("dd"));

            int mes = int.Parse(hoje.ToString("MM"));

            int ano = int.Parse(hoje.ToString("yyyy"));


            diasVida = 
            mesesVida = 
            anosVida = 

            

            Console.WriteLine(" VOCÊ TEM " + diasVida + " DIAS");
            Console.WriteLine(mesesVida + "MESES");
            Console.WriteLine("E" + anosVida + "ANOS DE VIDA.");

            Console.ReadKey();
        }
    }
}