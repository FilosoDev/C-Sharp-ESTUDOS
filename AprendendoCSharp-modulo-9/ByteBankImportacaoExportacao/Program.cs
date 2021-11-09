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

            //using(var fs = new FileStream("testaTipos.txt", FileMode.Create))
            //using(var escritor = new StreamWriter(fs))
            //{
            //    escritor.WriteLine(true);
            //    escritor.WriteLine(false);
            //    escritor.WriteLine(345633);
            //}

            //EscritaBinaria();

            LeituraBinaria();

            


            //TestaEscrita();
            Console.WriteLine("Aplicação finalizada. . .");


            Console.ReadLine();
        }
    }
} 
 