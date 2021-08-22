using System;

namespace CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 2..criando variáveis");

            int idade;
            idade = 40;

            Console.WriteLine(idade);

            idade += 10;
            // escreve e pula linha
            Console.WriteLine(idade);

            // só escreve
            Console.Write(idade);

            Console.WriteLine("Sua idade é: " + idade);

            // utilizar para a janela não fechar automaticamente
            Console.WriteLine("tecle para continuar...");
            Console.ReadLine();
        }
    }
}
