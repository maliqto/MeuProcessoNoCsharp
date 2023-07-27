using System;



namespace AULA_4___Capturando__entrada_de_usuário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // há duas formas de criar uma coisa que o usuário possa interagir 


            // essa é a primeira forma de criar uma interação com o usuário; 
            string nome = ""; 
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("O primeiro nome foi: ");
            Console.Write(nome, '\n');
            Console.WriteLine();



            // essa é a segunda forma de criar interação com o usuário
            Console.Write("digite outro nome: ");
            string nome2 = Console.ReadLine();

            Console.Write("O nome segundo foi: ");
            Console.Write(nome2);
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
