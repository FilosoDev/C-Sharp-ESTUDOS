// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {

        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }


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

            // diminuiu conforme novas contas são criadas
            // TaxaOperacao = 30 / TotalDeContasCriadas;

            TotalDeContasCriadas++;
        }


        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
