using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(1234, 7654321);
            Console.WriteLine(conta.Saldo);

            conta.Sacar(10);
      

            Console.ReadLine();
        }
    }
}
