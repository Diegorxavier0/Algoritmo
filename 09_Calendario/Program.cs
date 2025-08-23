using System;

namespace _09_Calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o mês (1-12): ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine());

            // Descobre a quantidade de dias do mês
            int diasDoMes = DateTime.DaysInMonth(ano, mes);

            // Descobre o primeiro dia da semana do mês (0 = domingo, 6 = sábado)
            DateTime primeiroDiaMes = new DateTime(ano, mes, 1);
            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;

            // Matriz de 6 semanas e 7 dias
            int[,] calendario = new int[6, 7];
            int dia = 1;

            // Preenche a matriz
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (semana == 0 && diaSemana < diaSemanaInicio)
                    {
                        calendario[semana, diaSemana] = 0; // antes do início
                    }
                    else if (dia <= diasDoMes)
                    {
                        calendario[semana, diaSemana] = dia;
                        dia++;
                    }
                    else
                    {
                        calendario[semana, diaSemana] = 0; // depois do fim
                    }
                }
            }

            //Impressão do calendário
            Console.WriteLine($"\nCalendário " + primeiroDiaMes.ToString("MMMM") + " de " + ano);
            Console.WriteLine("DOM SEG TER QUA QUI SEX SAB");

            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (calendario[semana, diaSemana] == 0)
                    {
                        Console.Write("    "); 
                    }
                    else
                    {
                        Console.Write($"{calendario[semana, diaSemana]:D2}  "); 
                    }
                }
                Console.WriteLine();
            }

           
            Console.ReadKey();
        }
    }
}
