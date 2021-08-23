using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaArthur = new ContaCorrente();
            contaArthur.titular = "Arthur";

            Console.WriteLine(contaArthur.saldo);

            bool resultadoSaque = contaArthur.Sacar(90);

            Console.WriteLine(contaArthur.saldo);
            Console.WriteLine(resultadoSaque);

            contaArthur.Depositar(300);

            Console.WriteLine(contaArthur.saldo);

            Console.ReadLine();
        }
    }
}
