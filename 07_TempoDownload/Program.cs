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

        /*
         double tamanhoMB= 0;
        double velocidadeMbps = 0;  
        double tempoSegundos, tempoMinutos;

        loop infinito 
        while (true)
        Console.ReadLine(Informe o tamanho do arquivo em MB: );
        if (double.TryParse(Console.ReadLine(), out tamanhoMB) && tamanhoMB > 0)

        sai do loop 
        break;
        else
        Console.WriteLine("Valor inválido! Digite um número maior que zero.");

        while (true)
        Console.ReadLine(Informe a velocidade da internet em Mbps: );
        if (double.TryParse(Console.ReadLine(), out velocidadeMbps) && velocidadeMbps > 0)
        sai do loop
        break;
        else
        Console.WriteLine("Valor inválido! Digite um número maior que zero.");
        
        // Cálculo do tempo de download
        tempoSegundos = (tamanhoMB * 8) / velocidadeMbps;
        tempoMinutos = tempoSegundos / 60;
        
        // Exibe o resultado
        Console.WriteLine($"Tempo aproximado de download: {tempoMinutos:F2} minutos");
         */
    }
}
