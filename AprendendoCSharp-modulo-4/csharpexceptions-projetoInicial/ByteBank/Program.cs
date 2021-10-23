using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args) 
        {
            try
            {
                CarregarContas();

            }
            catch (Exception)
            {
                Console.WriteLine("catch no método main");
            }

            Console.ReadLine();
        }


        private static void CarregarContas()
        {

            using(LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }

            // ----------------------------------------------------

            //LeitorDeArquivo leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivo("contas1.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //finally
            //{
            //    Console.WriteLine("Executando o finally");
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }

            //}
            
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(1234, 1234567);
                ContaCorrente conta2 = new ContaCorrente(4321, 7654321);

                //conta1.Trasnferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch(OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        // Teste com a cadeia de chamada
        // método -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com número: " + numero + " e divisor: " + divisor);
                throw; //causa o encerramento do método
            }

        }
    }
}
