using System;


namespace AULA_9___RETORNOS_DAS_FUNÇÕES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* na criação de uma função é preciso parsar um retorno, sendo eles: 

            static void - retorno vazio
            static string - textual - valor retorno
            static int - números inteiros - valor retorno
            static float - numeros decimais - valor retorno
            static bool - true ou false

            */

            // em toda função (menos no void) apartir do momento que eu defino o retorno dela é obrigatório eu por return nela para retornar algo

            // usando o return eu posso criar variáveis que e mexer com os resultados dela
            // tudo que estiver a baixo do retorno não será considerado 

            int Soma1 = somar(1, 2, 3); // armazenando minha função e possivelmente podendo mexer no resultado dela
            int Soma2 = somar(3, 3, 3);
            int Soma3 = somar(4, 4, 4);

            Console.WriteLine(Soma1);
            Console.WriteLine(Soma2);
            Console.WriteLine(Soma3);

            Console.WriteLine("vou brincar um pouco com as funções");

            int valor1 = Soma1 + Soma2;
            int valor2 = Soma2 + Soma3;

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);

            Console.ReadLine();


            /*
             * eu achei muito legal a opção de return, porém um pouco complicada de se mexer já que é obrigatório e tudo que é escrito a baixo não irá ser considerado
             */
        }

        static int somar(int a, int b, int c) { 

            int ValorFinal = a + b + c;
            return ValorFinal; // chamando o retorno dado na função
        }
    }
}
