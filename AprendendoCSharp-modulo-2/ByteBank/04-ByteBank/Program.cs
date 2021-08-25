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

            Console.WriteLine("Saldo Arthur: " + contaArthur.saldo);
            Console.WriteLine(resultadoSaque);

            contaArthur.Depositar(300);

            ContaCorrente contaElaine = new ContaCorrente();
            contaElaine.titular = "Elaine";

            contaArthur.Transferir(300, contaElaine);

            Console.WriteLine("Saldo Elaine: " + contaElaine.saldo);

            Console.WriteLine("Saldo Arthur: " + contaArthur.saldo);

            Console.ReadLine();
        }
    }
}
