using System;

namespace CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 5");

            // caracter, não pode estar vazia
            char primeiraLetra = 'a'; // só pode ser aspas simples
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65; //A maiúsculo
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1); //B maiúsculo
            Console.WriteLine(primeiraLetra);

            // string pode ser vazia
            string titulo = "Projeto 5 - Textos: " + 2021;
            Console.WriteLine(titulo);

            //quando coloca o @, interpreta a formatação exata do código
            string cursos = 
 @"- .NET
- Java
- PHP
- JavaScript";
            Console.WriteLine(cursos);


            Console.WriteLine("tecle enter...");
            Console.ReadLine();
        }
    }
}
