using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Autenticavel
    {

        // construtor que usa o construtor da classe base (Funcionario)
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Construindo DIRETOR...");
        }

        public override void AumentarSalario()
        {
            Salario = Salario * 1.15;
        }

        // método que sobreescreve outro
        public override double GetBonificacao()
        {
            // o base faz referencia ao método GetBnificacao da classe funcionario(base)
            return Salario * 0.5;
        }
    }
}
