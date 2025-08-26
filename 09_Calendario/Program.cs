using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_Calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o mês (1-12): ");
            int mes = int.Parse(Console.ReadLine());

            if (mes < 1 || mes > 12)
            {
                Console.WriteLine("Mês inválido. Digite um valor entre 1 e 12.");
                return;
            }

            Console.Write("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine());

            int diasDoMes = DateTime.DaysInMonth(ano, mes);
            DateTime primeiroDiaMes = new DateTime(ano, mes, 1);
            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;

            int[,] calendario = new int[6, 7];
            int dia = 1;

            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (semana == 0 && diaSemana < diaSemanaInicio)
                        calendario[semana, diaSemana] = 0;
                    else if (dia <= diasDoMes)
                        calendario[semana, diaSemana] = dia++;
                    else
                        calendario[semana, diaSemana] = 0;
                }
            }

            Console.WriteLine($"\nCalendário {primeiroDiaMes.ToString("MMMM")} de {ano}");
            Console.WriteLine("DOM SEG TER QUA QUI SEX SAB");

            int[] diasFeriados = RetornaFeriados(mes, ano);

            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    int diaAtual = calendario[semana, diaSemana];

                    if (diaAtual == 0)
                        Console.Write("    ");
                    else
                    {
                        if (diasFeriados.Contains(diaAtual) || diaSemana == 0)
                            Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write($"{diaAtual:D2}  ");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }

            Console.Write("\nFeriados: ");
            foreach (int f in diasFeriados)
            {
                if (f != 0)
                    Console.Write($"{f} ");
            }

            Console.WriteLine("\n* Dias em vermelho são domingos ou feriados.");
            Console.ReadKey();
        }

        public static int[] RetornaFeriados(int mes, int ano)
        {
            int[] feriados = new int[15];
            int indice = 0;

            if (mes == 1) feriados[indice++] = 1;
            else if (mes == 4)
            {
                feriados[indice++] = 21;
                feriados[indice++] = 4;
            }
            else if (mes == 5) feriados[indice++] = 1;
            else if (mes == 7) feriados[indice++] = 9;
            else if (mes == 9) feriados[indice++] = 7;
            else if (mes == 10) feriados[indice++] = 12;
            else if (mes == 11)
            {
                feriados[indice++] = 2;
                feriados[indice++] = 15;
                feriados[indice++] = 20;
            }
            else if (mes == 12)
            {
                feriados[indice++] = 8;
                feriados[indice++] = 25;
            }

            DateTime pascoa = DomingoDePascoa(ano);
            DateTime carnaval = pascoa.AddDays(-47);
            DateTime sextaSanta = pascoa.AddDays(-2);
            DateTime corpusChristi = pascoa.AddDays(60);

            Console.WriteLine($"\nFeriados móveis do ano {ano}:");
            Console.WriteLine($"Carnaval: {carnaval:dd/MM/yyyy}");
            Console.WriteLine($"Sexta-feira Santa: {sextaSanta:dd/MM/yyyy}");
            Console.WriteLine($"Páscoa: {pascoa:dd/MM/yyyy}");
            Console.WriteLine($"Corpus Christi: {corpusChristi:dd/MM/yyyy}");

            if (carnaval.Month == mes) feriados[indice++] = carnaval.Day;
            if (sextaSanta.Month == mes) feriados[indice++] = sextaSanta.Day;
            if (pascoa.Month == mes) feriados[indice++] = pascoa.Day;
            if (corpusChristi.Month == mes) feriados[indice++] = corpusChristi.Day;

            return feriados;
        }

        public static DateTime DomingoDePascoa(int Ano)
        {
            int X = 0, Y = 0;

            if (Ano <= 1699) { X = 22; Y = 2; }
            else if (Ano <= 1799) { X = 23; Y = 3; }
            else if (Ano <= 1899) { X = 24; Y = 4; }
            else if (Ano <= 2099) { X = 24; Y = 5; }
            else if (Ano <= 2199) { X = 24; Y = 6; }
            else if (Ano <= 2299) { X = 24; Y = 7; }

            int a = Ano % 19;
            int b = Ano % 4;
            int c = Ano % 7;
            int d = (19 * a + X) % 30;
            int g = (2 * b + 4 * c + 6 * d + Y) % 7;

            int dia, mes;
            if ((d + g) > 9)
            {
                dia = d + g - 9;
                mes = 4;
            }
            else
            {
                dia = d + g + 22;
                mes = 3;
            }

            return new DateTime(Ano, mes, dia);
        }
    }
}
