using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaArthur = new ContaCorrente();
            contaArthur.titular = "Arthur";
            contaArthur.agencia = 1234;
            contaArthur.numero = 997733;

            ContaCorrente contaArthurDois = new ContaCorrente();
            contaArthurDois.titular = "Arthur";
            contaArthurDois.agencia = 1234;
            contaArthurDois.numero = 997733;

            Console.WriteLine(contaArthur == contaArthurDois);

            Console.ReadLine();
        }
    }
}
