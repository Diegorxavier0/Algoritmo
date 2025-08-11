using System;

namespace _06_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicando = 0, produto;
            bool digitacaoValida = false;

            // ! negação: inverte o valor booleano
            //!false = true 
            //!true = false
            //while (!digitacaoValida == false)
            while (!digitacaoValida)
            {
                Console.WriteLine("Digite um número inteiro: ");
                digitacaoValida = int.TryParse(Console.ReadLine(), out multiplicando);
            }

            Console.WriteLine($"TABUADA DO {multiplicando}");
            for (int multiplicador= 1; multiplicador <= 10; multiplicador++)
            {
                produto = multiplicando * multiplicador;
                // Console.WriteLine($"{0} x {1} = {2}", multiplicando, multiplicador, produto);
                // Interpolação de string $
                Console.WriteLine($"{multiplicando} x {multiplicador} = {produto}");
            }
        }
    }
}
