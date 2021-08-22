using System;

namespace CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + (valorInvestido * 0.0036); //0.36%
                Console.WriteLine("Após" + contadorMes + " mês você terá R$ " + valorInvestido);
                contadorMes++;
            }

            
            

            Console.WriteLine("tecle enter...");
            Console.ReadLine();
        }
    }
}
