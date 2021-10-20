using System;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            CalcularBonificacao();
            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("123.456.789-10");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("123.456.789-10");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
            sistemaInterno.Logar(parceiro, "123456");
        }

        private static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("123.456.789-10");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("123.456.789-10");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("123.456.789-10");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("123.456.789-10");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("123.456.789-10");
            guilherme.Nome = "Giulherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine("Total de bonificações do mês :" + gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}