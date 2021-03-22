using System;

namespace Aula_de_PC1_Juros
{
    class Program
    {
        static void Main(string[] args)
        {
            double investimento , taxaJ , tempo, juros, capital;
            string resposta;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nHora de simular um investimento em seu futuro!");
            Console.WriteLine("----------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("\nDigite o valor de seu investimento em reais:");
            investimento = double.Parse(Console.ReadLine());
            taxaJ = (investimento * 2 / 100);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Lembre-se a taxa de juros mensais aplicada é igual a 15% do investimento total.");
            Console.WriteLine("---------------------------------------------------------------------=---------");
            Console.ResetColor();

            Console.WriteLine("Quantos messes pretende manter seu investimento?");
            tempo = double.Parse(Console.ReadLine());
            juros = (taxaJ * tempo);
            capital = (juros + investimento);
            Console.WriteLine("Tecle enter para realizar sua simulação.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Com um investimento ùnico de R${investimento} sobre a taxa de 15%.m do valor investido.\nEm {tempo} messes seu capital total seria equivalente a R${capital} ");
            Console.WriteLine("\nCaso deseje saber o valor da taxa de juros aplicada, escreva (SIM):");
            resposta = Console.ReadLine();
            if (resposta = SIM)
            {
                Console.WriteLine($"O valor da taxa de juros é igual a {taxaJ}.m");
                Console.WriteLine("\nTecle enter para fechar o programa:");
                Console.ReadLine();
                Console.Clear();

            }
           Console.ReadKey();
           Console.Clear();
        }
    }
}
