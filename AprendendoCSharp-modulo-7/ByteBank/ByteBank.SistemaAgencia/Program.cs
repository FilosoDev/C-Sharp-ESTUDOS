using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDeTeste = new ContaCorrente(1111, 11111111);

            lista.Adicionar(contaDeTeste);

            lista.Adicionar(new ContaCorrente(333, 123456));
            lista.Adicionar(new ContaCorrente(333, 654321));
            lista.Adicionar(new ContaCorrente(333, 997744));
            lista.Adicionar(new ContaCorrente(333, 123456));
            lista.Adicionar(new ContaCorrente(333, 654321));
            lista.Adicionar(new ContaCorrente(333, 997744));
            lista.Adicionar(new ContaCorrente(333, 123456));
            lista.Adicionar(new ContaCorrente(333, 654321));
            lista.Adicionar(new ContaCorrente(333, 997744));
            
            lista.EscreverListaNaTela();

            lista.Remover(contaDeTeste);

            Console.WriteLine("nova lista após a remoção...");

            lista.EscreverListaNaTela();

            Console.ReadLine();

        }

        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
               {
                    new ContaCorrente(874, 998877),
                    new ContaCorrente(874, 654321),
                    new ContaCorrente(874, 123456)

               };


            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }

        }

        static void TestaArrayInt()
        {

            // array de inteiros com 5 posições
            int[] idades = null;
            idades = new int[5]; //array de zeros

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;


            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array de idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idade = {media}");

            //int idadeDoIndice4 = idades[4];

            //Console.WriteLine(idadeDoIndice4);

            //int[] outroArray = idades;
            //Console.WriteLine(outroArray[3]);

            //bool[] arrayDeBooleanos = new bool[10];

            //arrayDeBooleanos[0] = true;
            //arrayDeBooleanos[0] = false;
            //arrayDeBooleanos[0] = false;



            Console.ReadLine();
        }


    }
}
