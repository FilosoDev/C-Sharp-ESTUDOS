// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {

        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }


        public int Agencia { get; }

        // usa-se isso por o número da conta não muda e somente é lido uma vez
        // private readonly int _numero;
        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0 )
            {
                throw new ArgumentException("A agência deve ser maior que 0!", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O número deve ser maior que 0!", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;

            // diminuiu conforme novas contas são criadas
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }


        public void Sacar(double valor)
        {

            if(valor < 0)
            {
                throw new ArgumentException("Valor inválido para saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
            
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {

            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }
            contaDestino.Depositar(valor);
 
        }
    }
}
