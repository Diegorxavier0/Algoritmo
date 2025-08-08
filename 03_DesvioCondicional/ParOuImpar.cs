using System;

class ParOuImpar
{
    static void Main()
    {
		int numero;
		
        Console.Write("Digite um número: ");
		
        // Lê o número digitado e converte para int
		numero = int.Parse(Console.ReadLine()); 

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é ímpar.");
        }
    }
}
