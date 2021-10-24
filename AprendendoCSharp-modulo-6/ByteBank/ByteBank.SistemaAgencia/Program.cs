using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(456, 7654321);
            object desenvolvedor = new Desenvolvedor("1233456");

            string contaToString = conta.ToString();

            Console.WriteLine(conta);
            Console.WriteLine(contaToString);


            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Manoel";
            carlos_1.CPF = "123.456.789-00";
            carlos_1.Profissao = "Developer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Manoel";
            carlos_2.CPF = "123.456.789-00";
            carlos_2.Profissao = "Developer";

            ContaCorrente conta_99 = new ContaCorrente(111, 33333);

            if(carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais");
            }
            else
            {
                Console.WriteLine("Não são iguais");
            }



            Console.ReadLine();
        }

        // testes regex
        static void TestaString()
        {
            // recuperar suposto número de telefone
            // meu nome é Arthur, me ligue no número 99765-3390
            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4,5}[-][0-9]{4}";
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "meu nome é Arthur, me ligue no número 997653390";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);
            Console.ReadLine();

            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio"));

            Console.WriteLine(urlTeste.Contains("bytebank"));

            Console.WriteLine(indiceByteBank == 0);


            //moedaOrigem=real&moedaDestino=dolar
            string urlParametros = "http://www.bytebnak.com/cambio?moedaOrigem=real&moedaDestino=dolar&Valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valorDaMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorDaMoedaOrigem);

            Console.WriteLine("Valor: " + extratorDeValores.GetValor("VaLOR"));



            // Testando toLower
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagemOrigem.ToLower());

            //Testando Replace
            termoBusca = termoBusca.Replace('r', 'R');



            // testando o método REMOVE
            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));



            // <nome>=<valor>
            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);
            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));


            // testes isNullOrEmpty
            string textoVazio = "";
            string textoNulo = null;
            Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            Console.WriteLine(string.IsNullOrEmpty(textoNulo));

            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            string url = "paginas?moedaOrigem=real&moedaDestino=dolar"; //texto não muda, mas pode ser acrescentado com +=


            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1); // cria-se uma nova string da operação
            Console.WriteLine(argumentos);





            Console.ReadLine();
        }


    }
}
