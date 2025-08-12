using System;


class Program
{
    static void Main()
    {
        double tamanhoMB;
        double velocidadeMbps;

        Console.WriteLine("Informe o tamanho do arquivo (MB): ");
        string valorDigitado = Console.ReadLine();

       
        if (double.TryParse(valorDigitado, out tamanhoMB) && tamanhoMB > 0)
        {
            Console.WriteLine("Informe a velocidade da internet (Mbps): ");
            valorDigitado = Console.ReadLine();


            
            if (double.TryParse(valorDigitado, out velocidadeMbps) && velocidadeMbps > 0)
            {
                // Cálculo
                double tempoSegundos = (tamanhoMB * 8) / velocidadeMbps;
                double tempoMinutos = tempoSegundos / 60;

                Console.WriteLine($"Tempo aproximado de download: {tempoMinutos:F2} minutos");
            }
            else
            {
                Console.WriteLine("Valor inválido! Digite um número maior que zero.");
            }
        }
        else 
        {
            Console.WriteLine("Valor inválido! Digite um número maior que zero.");
        }
    }
}
