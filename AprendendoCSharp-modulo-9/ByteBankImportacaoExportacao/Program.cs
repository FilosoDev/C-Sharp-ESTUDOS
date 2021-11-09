using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // IO = Input e Output
using System.Globalization;

namespace ByteBankImportacaoExportacao 
{ 
    partial class Program 
    { 
        static void Main(string[] args) 
        {


            File.WriteAllText("escrevendoComAClasseFile.txt", "testando File.WriteAllText");

            Console.WriteLine("arquivo escrevendoComAClasseFile.txt criado");

            var bytesArquivo = File.ReadAllBytes("teste.txt");
            Console.WriteLine($"arquivo teste.txt possui {bytesArquivo.Length} bytes");

            var linhas = File.ReadAllLines("teste.txt");
            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.ReadLine();

            Console.WriteLine("Digite o seu nome");
            var nome = Console.ReadLine();



            //UsarStreamDeEntrada();


            //using(var fs = new FileStream("testaTipos.txt", FileMode.Create))
            //using(var escritor = new StreamWriter(fs))
            //{
            //    escritor.WriteLine(true);
            //    escritor.WriteLine(false);
            //    escritor.WriteLine(345633);
            //}

            //EscritaBinaria();

            //LeituraBinaria();

            


            //TestaEscrita();
            Console.WriteLine("Aplicação finalizada. . .");


            Console.ReadLine();
        }
    }
} 
 