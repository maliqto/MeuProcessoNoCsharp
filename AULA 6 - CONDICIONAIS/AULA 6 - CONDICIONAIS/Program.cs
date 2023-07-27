using System;


namespace AULA_6___CONDICIONAIS
{
    internal class Program
    {
        static void Main(string[] args)

        {

            // está aula irei aprender sobre condicionais. 
            /* é parecido um pouco com as outras linguagens sendo:
            > = maior que 
            < = menor que 
            >= - maior ou igual 
            <= - menor ou igual
            == - igual a 
            != - diferente 

            */



            string Aviso = "Vamos verificar se você tem idade para tirar sua carteira de trabalho"; // armazenando aviso do que eu farei com string no início 

            Console.WriteLine(Aviso); //exibindo aviso

            Console.Write("Digite sua idade: "); //pedindo a idade do usuário

            string PegandoIdade = Console.ReadLine(); // utilizando o var para pegar a resposta digitada no console, pois se eu colocar o tipo de variável antes da string ele iria ter problemas para exibi-lá no terminal
            
            int Idade = int.Parse(PegandoIdade); // int.Parse() para converter um valor de "string" em um valor do tipo "int". Já que o Console.ReadLine(); registra apenas string


            string AvisoIdade = "A idade digitada foi: ";
            Console.WriteLine(AvisoIdade + PegandoIdade); // exibindo a idade




            // verificando a idade

            // o if é necessário o () assim como no python e de {} para execução 
            // o else não é necessário o() e sim o { } para executar
            // é usado else if () para falar "ou", os () são obrigatórios e os {} também


            if (Idade > 18)
            {

                Console.WriteLine("Opa! Você está apto para tirar a carteira de trabalho!");

            } 
            else if (Idade == 18) {

                Console.WriteLine("Você tem 18 anos! Está na flor de tirar, começou agora.");
            }
            else {

                Console.WriteLine("Não tens idade o suficiente para tirar a carteira...");
            }
            Console.ReadKey();
        }
    }
}
