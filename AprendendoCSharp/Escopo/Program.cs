using System;

namespace Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 7..condicionais");

            int idade = 16;
            int qtdPessoas = 2;

            bool acompanhado = false; // ou true
            //bool acompanhado = qtdPessoas >= 18; // tb permite

            //lembrar de sempre atribuir valor a variável
            string mensagemAdicional = "";
            Console.WriteLine(mensagemAdicional);

            // quando digita if e aperta tab duas vezes, o if se completa
            // tb funciona com else
            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!";
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                mensagemAdicional = "João não está acompanhado!";
                Console.WriteLine(mensagemAdicional);
            }

            if (idade >= 18 || qtdPessoas >= 2) // Lógicos: || ou && e
            {
                Console.WriteLine("João possui mais de 18 anos ou está acompanhado, pode entrar!");
            }
            else
            {
                Console.WriteLine("Menor");
            };

            /* quando se tem apenas uma linha, pode fazer assim:
            else
            {
                Console.WriteLine("Menor");
            */

            Console.WriteLine("tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}

