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

            Lista<int> idades = new Lista<int>();

            idades.Adicionar(5);
            idades.AdicionarVarios(5, 99, 12);

            for(int i = 0; i < idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];
            }

            //testando SomarVarios com params
            Console.WriteLine(SomarVarios(1, 2, 10, 45, 100));
            Console.WriteLine(SomarVarios(1, 2, 100));


            Console.ReadLine();

        }

        static void TestaListaDeObject()
        {

            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(9);
            listaDeIdades.AdicionarVarios(2, 99, 15);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }

        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDeTeste = new ContaCorrente(1111, 11111111);

            lista.Adicionar(contaDeTeste);

            lista.Adicionar(new ContaCorrente(333, 123456));
            lista.Adicionar(new ContaCorrente(333, 654321));
            lista.Adicionar(new ContaCorrente(333, 997744));

            lista.Remover(contaDeTeste);

            Console.WriteLine("nova lista após a remoção...");

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDeTeste,
                new ContaCorrente(333, 123456),
                new ContaCorrente(333, 997744)
            };
            // add lista de contas
            lista.AdicionarVarios(contas);

            // usando sobrecarga nesse método..params
            lista.AdicionarVarios(
                contaDeTeste,
                new ContaCorrente(333, 123456),
                new ContaCorrente(333, 997744)
            );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
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
