using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaArthur= new ContaCorrente();
            contaArthur.titular = "Arthur";
            contaArthur.agencia = 1234;
            contaArthur.numero = 885544;
            contaArthur.saldo = 100;

            Console.WriteLine(contaArthur.titular);
            Console.WriteLine("Agência: " + contaArthur.agencia);
            Console.WriteLine("C/C: " + contaArthur.numero);
            Console.WriteLine("Saldo: " + contaArthur.saldo);

            contaArthur.saldo += 100;
            Console.WriteLine(contaArthur.saldo);

            Console.ReadLine();


        }
    }
}
