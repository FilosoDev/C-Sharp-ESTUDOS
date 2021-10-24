using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
   public class ExtratorValorDeArgumentosURL
    {

        private readonly string _argumentos;
        public string URL { get; }

        // digitar ctor, tab tab para criar o construtor rapidamente
        public ExtratorValorDeArgumentosURL(string url)
        {

            if (string.IsNullOrEmpty(url)){
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }


            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);


            URL = url;

        }

        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper(); //VALOR
            string argumentoEmCaixaAlta = _argumentos.ToUpper(); //MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR

            string termo = nomeParametro + "="; // resultado moedaDestino=
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length); //resultado dolar
            int indiceEComercial = resultado.IndexOf('&');

            if(indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);
        }



    }
}
