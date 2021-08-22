using System;

namespace ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4...");

            double salario;
            salario = 1200.50;

            int salarioEmInteiro; //32 bits
            salarioEmInteiro = (int)salario; //cast...converte
            Console.WriteLine(salarioEmInteiro);

            long idade; //long é inteiro muito maior, 64bits
            idade = 13000000000000;

            Console.WriteLine(idade);

            short quantidadeProdutos; //inteiro menor, 16 bits
            quantidadeProdutos = 150;

            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f; // usa o sufixo f pq o uso não é tão usual, float tem menor precisão
            Console.WriteLine(altura);


            Console.WriteLine("tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
