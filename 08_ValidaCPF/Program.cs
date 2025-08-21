using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Digite o CPF: ");
        string cpf = Regex.Replace(Console.ReadLine(), "[^0-9]", "");

        if (cpf.Length != 11 || new string(cpf[0], 11) == cpf)
        {
            Console.WriteLine("CPF inválido!");
            return;
        }

        int[] mult1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] mult2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        int soma = 0;
        for (int i = 0; i < 9; i++) soma += (cpf[i] - '0') * mult1[i];
        int d1 = (soma % 11 < 2) ? 0 : 11 - (soma % 11);

        soma = 0;
        for (int i = 0; i < 10; i++) soma += (cpf[i] - '0') * mult2[i];
        int d2 = (soma % 11 < 2) ? 0 : 11 - (soma % 11);

        Console.WriteLine((cpf[9] - '0' == d1 && cpf[10] - '0' == d2) ? "CPF válido!" : "CPF inválido!");
    }
}
