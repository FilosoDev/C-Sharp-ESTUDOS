using System;

namespace AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 6");

            int idade = 32;
            int idadeArthur = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeArthur);


            Console.WriteLine("tecle enter...");
            Console.ReadLine();
        }
    }
}
