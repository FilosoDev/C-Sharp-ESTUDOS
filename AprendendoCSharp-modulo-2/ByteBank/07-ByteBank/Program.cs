using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 1234567);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta2 = new ContaCorrente(869, 2234567);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
        }
    }
}
