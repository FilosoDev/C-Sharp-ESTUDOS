using System;

namespace CalculaInvestimentoALongoPrazoForDentroDeFor

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 12 - calcula poupança longo prazo");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento; 
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao término do investimento você terá: R$" + valorInvestido);

            Console.WriteLine("tecle enter...");
            Console.ReadLine();
        }
    }
}
