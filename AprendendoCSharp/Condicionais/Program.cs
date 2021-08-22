using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 7..condicionais");

            int idade = 16;
            int qtdPessoas = 2;

            if (idade >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos, pode entrar!");
            }
            else
            {
                Console.WriteLine("Menor");
            };


            Console.WriteLine("tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
