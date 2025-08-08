using System;
using System.Threading;

namespace _04_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variável
            // Sintaxe: tipo nomeVariavel = valor
            string nome = "Fulano de Tal";

            nome = "Beltrano de Tal"; // Atribuição de novo valor à variável
            Console.WriteLine(nome);

           
            
            // Declaração de vetores
            //Sintaxe: tipo[] nomeVariavel = { valor1, valor2, valor3 };
            string[] nomes = { "Fulano de Tal","Beltrano", "Sicrano","João", "José","Maria"};
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[2]);    

            // Loop FOR 
            // for ( indice; controle; incremento)
            // Length retorna quatidade dos vetores
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine( "{0}° Nome: {1}", i+1, nomes[i]);
            }

            //Impressão dos 100 primeiros números pares
            for (int i = 0; i <= 100; i += 2) 
            {
                Console.WriteLine("Número: {0}", i);
               
            }

            // Loop foreach
            foreach (string varNome in nomes)
            {
                Console.WriteLine("Nome: {0}", varNome);
            }


        }
    }
}
