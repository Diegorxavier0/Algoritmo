using System;

namespace _06_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Digite um número para ver sua tabuada: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada do {n}:");

            for (int i = 1; i <= 10; i++)
            {
              
                int resultado = n * i; 
                Console.WriteLine($"{n} x {i} = {resultado}");
            }
        }
    }
}
