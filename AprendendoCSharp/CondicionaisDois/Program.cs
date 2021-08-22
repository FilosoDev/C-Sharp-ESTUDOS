using System;

namespace CondicionaisDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 7..condicionais");

            int idade = 16;
            int qtdPessoas = 2;

            bool acompanhado = true; // ou false
            //bool acompanhado = qtdPessoas >= 18; // tb permite

            if (idade >= 18 || qtdPessoas >= 2) // Lógicos: || ou && e
            {
                Console.WriteLine("João possui mais de 18 anos ou está acompanhado, pode entrar!");
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

