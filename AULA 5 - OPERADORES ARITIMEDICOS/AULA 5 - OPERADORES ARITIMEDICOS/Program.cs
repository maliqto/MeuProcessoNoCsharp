using System;


namespace AULA_4___OPERADORES_ARITIMEDICOS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int NumeroInt = 10 + 2; // aqui irá somar igual fazemos 
            int NumeroDiv = 10 - 2; // aqui ira subtrair os números
            int NumeroSom = 10 * 2; // aqui irá multiplicar os numeros
            int NumeroCort = 5 / 2; // aqui irá dividir e rotornar com corte por causa que retorna em float 
            float NumeroSemCort = 5f / 2; // aqui irá mostrar o verdadeiro resultado | OBS: é essencial espeficiar que é um floar com "f" no final.
            int NumeroCert = 6 / 2; // aqui irá dividir de forma correta.

            // como na matematica tem subtrair  primeiro e depois vem o restante 
            int soma = 7 + 2 * 3; //aqui ele irá fazer primeiro o 3 * 2 = 4 + 7

            int somacer = (7 + 2) * 4; // aqui ele irá exibir o correto de 7 + 2 = 8 * 4 

            Console.WriteLine(NumeroInt);
            Console.WriteLine(NumeroDiv);
            Console.WriteLine(NumeroSom);
            Console.WriteLine(NumeroCort);
            Console.WriteLine(NumeroCert);
            Console.WriteLine(NumeroSemCort);
            Console.WriteLine(soma);
            Console.WriteLine(somacer);

            Console.ReadKey();

        }
    }
}
