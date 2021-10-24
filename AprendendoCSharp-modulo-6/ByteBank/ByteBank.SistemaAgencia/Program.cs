using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            string url = "pagina?argumentos"; //texto não muda, mas pode ser acrescentado com +=

            Console.WriteLine(url);
            string argumentos = url.Substring(7); // cria-se uma nova string da operação
            Console.WriteLine(argumentos);



            Console.ReadLine();
        }

       
    }
}
