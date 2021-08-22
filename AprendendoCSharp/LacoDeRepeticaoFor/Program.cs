using System;

namespace LacoDeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 11 - calcula poupança 2");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12 ; contadorMes++)
            {
                valorInvestido *= 1.0036; //0.36%
                Console.WriteLine("Após" + contadorMes + " mês você terá R$ " + valorInvestido);
            }

            Console.WriteLine("tecle enter...");
            Console.ReadLine();
        }
    }
}
