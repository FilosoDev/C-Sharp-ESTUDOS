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


            int indiceInterrogacao = URL.IndexOf('?');
            _argumentos = URL.Substring(indiceInterrogacao + 1);


            URL = url;

        }

        public string GetValor(string nomeParametro)
        {
            //int indiceParametro = _argumentos.IndexOf
            return "ok";
        }



    }
}
