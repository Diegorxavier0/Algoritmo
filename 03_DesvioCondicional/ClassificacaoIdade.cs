using System;

class ClassificacaoIdade
{
    static void Main()
    {
        int idade;
        Console.WriteLine("Digite sua idade");
        idade = int.Parse(Console.ReadLine());

        if (idade <= 12)
        {
            Console.WriteLine("Você é Criança");
        }
        else if (idade <= 17)
        {
            Console.WriteLine("Você é Adolescente");
        }
        else if (idade <= 59)
        {
            Console.WriteLine("Você é Adulto");
        }
        else 
        {
            Console.WriteLine("Você é Idoso");
        }
    }
}
