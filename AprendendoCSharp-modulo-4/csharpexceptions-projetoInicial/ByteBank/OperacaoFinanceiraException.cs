using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException(string mensagem) 
            : base(mensagem)
        {

        }

        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna) 
            : base (mensagem, excecaoInterna)
        {

        }

        public OperacaoFinanceiraException()
        {

        }
    }
}
