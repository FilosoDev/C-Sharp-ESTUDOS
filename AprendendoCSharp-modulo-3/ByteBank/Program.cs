using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario arthur = new Funcionario(2000, "123.456.789");


            arthur.AumentarSalario();
            Console.WriteLine("Novo salário Arthur: " + arthur.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            // bonificação
            gerenciador.Registrar(arthur);

            Funcionario maria = new Diretor("123.456.789");

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Diretor elaine = new Diretor("123.456.789");
            elaine.Nome = "Elaine";

            // bonificação
            gerenciador.Registrar(elaine);


            Console.WriteLine(arthur.Nome);
            Console.WriteLine(arthur.GetBonificacao());

            Console.WriteLine(elaine.Nome);
            Console.WriteLine(elaine.GetBonificacao());

            Console.WriteLine("Total bonificações: " + gerenciador.GetTotalBonificacao());

            Console.WriteLine(Funcionario.TotalDeFuncionarios);
        }
    }
}