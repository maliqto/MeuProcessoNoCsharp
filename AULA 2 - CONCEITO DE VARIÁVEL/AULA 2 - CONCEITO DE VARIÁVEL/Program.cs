using System;


namespace AULA_2___CONCEITO_DE_VARIÁVEL
{
    internal class Program
    {
        static void Main(string[] args)
        {



            dynamic Aula2 = "Essa é uma váriavél definida com dynamic, ela pode ser alterada de tipo quando você chamar ela e quiser mudar, porém, dynamic quebra o tipo tipado da linguagem e isso pode ser ruim para alguns leitores.";

            Console.WriteLine(Aula2);

            Aula2 = 121;

            Console.WriteLine(Aula2);

            Console.ReadKey();




        }
    }
}
