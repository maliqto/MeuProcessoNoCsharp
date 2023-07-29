using System;
using System.Net.Http.Headers;

namespace AULA_8___FUNÇÕES
{
    internal class Program
    {

        // para fazer funções eu preciso por elas em class 

        // todo inicio de funções - por hora - irá começar com static 
        // use o termo void para a função não retornar nada
        // caso você passe parametros a função é necesário dar um valor a ela na chamada


        static void Main(string[] args)
        {

            // para chamar a função basta por igual python 

            Taboada10();
        


            Console.ReadKey();
        }

        // função matemática 10 

        static void Taboada10() //chamando sem passar argumentos para evitar erros na chamada
        {

            Console.Write("Digite o número que deseja somar por 10: ");
            int numero = int.Parse(Console.ReadLine()); //pegando numero para somar com 10

            int numeroSomar = Math.Abs(numero); //evitando pegar números - (negativos) tipo -10

            int somando = numeroSomar + 10; //somandos o número por 10

            Console.WriteLine("O Resultado foi: " + somando); // chamando o resultado

        }

    }
}
