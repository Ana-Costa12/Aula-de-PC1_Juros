using System;

namespace Aula_de_PC1_Juros
{
    class Program
    {
        static void Main(string[] args)
        {
            double investimento, taxaJ, tempo, juros, capital;
            int resposta;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nHora de simular um investimento em seu futuro!");
            Console.WriteLine("----------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("\nDigite o valor de seu investimento em reais:");
            investimento = Convert.ToDouble(Console.ReadLine());
            //taxaJ = (investimento * 2 / 100);
            taxaJ = 15D / 100;
            Console.WriteLine(taxaJ);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Lembre-se a taxa de juros mensais aplicada é igual a 15% do investimento total.");
            Console.WriteLine("---------------------------------------------------------------------=---------");
            Console.ResetColor();

            Console.WriteLine("Quantos messes pretende manter seu investimento?");
            tempo = double.Parse(Console.ReadLine());
            juros = (investimento * taxaJ * tempo);
            capital = (juros + investimento);
            Console.WriteLine("Tecle enter para realizar sua simulação.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Com um investimento ùnico de R${investimento:N2} sobre a taxa de 15%.m do valor investido.\nEm {tempo} messes seu capital total seria equivalente a R${capital:N2} ");
            Console.WriteLine("\nCaso deseje saber o valor da taxa de juros aplicada, tecle 5:");
            //resposta = Convert.ToInt32(Console.ReadLine()); 
            //O comando abaixo ajuda caso o usuário não digite nada, para não dar erros.
            Int32.TryParse(Console.ReadLine(), out resposta);
            if (resposta == 5)
            {
                Console.WriteLine($"O valor da taxa de juros é igual a R${taxaJ}.m");

            }
            Console.WriteLine("Obrigada! Pressione qualquer botão para sair:");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
