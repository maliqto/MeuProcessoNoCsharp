using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_7___OPERADORES_LÓGICOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esta aula é sobre operadores lógicos

            // && - é 
            // || ou 

            Console.WriteLine("Olá, vamos verificar se você consiguirá tirar sua carteira de graça");


            Console.Write("Por favor digite sua idade: ");
            string Idade = Console.ReadLine(); // capturando a idade do usuário 

            int Idade2 = int.Parse(Idade); // tranformando a resposta em um int com o int.parse()

            Console.WriteLine("Agora vamos verificar se seu nome pertence na lista dos benificiados");

            string Nome = "Victor";

            Console.Write("Digite seu nome: ");
            string NomeUsu = Console.ReadLine();

            // iniciando a verificação

            if (Idade2 >= 20 && NomeUsu == Nome)
            {

                Console.WriteLine("Parabéns você tem " + Idade2 + " E Consegue passar na festa por conta que seu nome é " + NomeUsu);
            } 
            else if (Idade2 < 18) {

                Console.WriteLine("você nem tem idade para está aqui!");

            }
            else if (Idade2 < 20 && NomeUsu != Nome)
            {

                Console.WriteLine("Poxa você tem " + Idade2 + " e seu nome é  " + NomeUsu + ", Se teu nome fosse " + Nome + " e tua idade 18 Você conseguiria ao menos um bônus");

            }
            else if (Idade2 < 20 && NomeUsu == Nome) {
                Console.WriteLine("Opa, você não tem idade para entrar grátis, mas terá um bonus porque seu nome é " + NomeUsu);
            }
            else {

                Console.WriteLine("Desculpa, mas você não está apto a entrar na festa");
            }


            Console.ReadKey();



        }
    }
}
