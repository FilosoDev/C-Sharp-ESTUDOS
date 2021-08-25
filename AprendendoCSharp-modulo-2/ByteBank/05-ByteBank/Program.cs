using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cliente arthur = new Cliente();

            // arthur.nome = "Arthur";
            // arthur.profissao = "Professor";
            // arthur.cpf = "123.456.789-10";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = arthur;
            conta.titular = new Cliente();
            conta.titular.nome = "Arthur";
            conta.titular.cpf = "123.456.789-10";
            conta.titular.profissao = "Professor";

            conta.saldo = 500;
            conta.agencia = 3456;
            conta.numero = 3456123;

            //Console.WriteLine(arthur.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
