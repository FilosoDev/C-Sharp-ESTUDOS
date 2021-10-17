using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario

    {

        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; } //protegido para a classe e para os filhos

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONÁRIO");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;


        }



        public virtual void AumentarSalario()
        {
            Salario = Salario * 1.1;
        }



        // permite q seja sobreescrito
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

    }
}
