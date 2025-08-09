using System;



namespace _05_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criação de um vetor para armazenamento de 100 elementos
            string[] nomes = new string [100];
            string continuar = "S";

            //Será meu indice para atribuição dos nomes no vetor
            int contador = 0;



            //Loop while
            //Sintaxe: while(expressão booleana, tem que retornar um unico valor verdadeiro ou falso)

            //Método ToUpper() converte a string para maiúscula
            while (continuar.ToUpper() == "S")
            {
                Console.WriteLine("Digite o {0}ª nome: ", contador + 1);
                //Append adiciona um item no vetor
                nomes[contador] = (Console.ReadLine());


                //Incrementa o contador
                contador++;
                Console.WriteLine("Deseja continuar ? (S/N)");
                continuar = (Console.ReadLine());

                Console.WriteLine("Nomes informados ");
                foreach (string str in nomes)
                {
                    // != Significa diferente 
                    if (str != null) //Verifica se o nome não é nulo
                    {
                        Console.WriteLine(str);
                    }

                }
            }
        }
    }
}
