using System;
using System.Linq;

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

            // Impressão do calendário
            Console.WriteLine($"\nCalendário {primeiroDiaMes.ToString("MMMM")} de {ano}");
            Console.WriteLine("DOM SEG TER QUA QUI SEX SAB");

            int[] diasFeriados = RetornaFeriados(mes, ano); // exemplo: 11 e 21 serão feriados

            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    int diaAtual = calendario[semana, diaSemana];

                    if (diaAtual == 0) // dia vazio
                    {
                        Console.Write("    ");
                    }
                    else
                    {
                        // Se for feriado OU domingo
                        if (diasFeriados.Contains(diaAtual) || diaSemana == 0)
                            Console.ForegroundColor = ConsoleColor.Red;

                        // imprime o número antes de resetar a cor
                        Console.Write($"{diaAtual:D2}  ");

                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }   
            Console.Write("\nFeriados: ");
            for (int i = 0; i <diasFeriados.Length; i++)
            {
                if (diasFeriados[i] != 0)
                    Console.Write($"{diasFeriados[i]} ");
            }


            Console.ReadKey();
        }
        public static int[] RetornaFeriados(int mes, int ano)
        {
            int[] feriados = new int[15];

            int indice = 0;
            //feriados[indice++] = 11;
            //feriados[indice++] = 21;

            // Feriados fixos no Estado de SP
            if (mes == 1) feriados[indice++] = 1; //1º de janeiro(quarta - feira): Confraternização Universal

            else if (mes == 4) 
            { 
                feriados[indice++] = 21;//21 de abril(segunda-feira): Tiradentes
                feriados[indice++] = 4;//Aniversário de marília
            
            }

            else if (mes == 5) feriados[indice++] = 1;//1º de maio (quinta-feira): Dia do Trabalho

            else if (mes == 7) feriados[indice++] = 9;//

            else if (mes == 9) feriados[indice++] = 7;//7 de setembro (domingo): Independência do Brasil

            else if (mes == 10) feriados[indice++] = 12;//12 de outubro (domingo): Nossa Senhora Aparecida

            else if (mes == 11)
            {
                feriados[indice++] = 2;//2 de novembro (domingo): Finados
                feriados[indice++] = 15;//15 de novembro (sábado): Proclamação da República
                feriados[indice++] = 20;//20 de novembro (quinta-feira): Dia Nacional de Zumbi e da Consciência Negra
            }
            else if (mes == 12)
            {
                feriados[indice++] = 8;
                feriados[indice++] = 25;//Natal
            }


            return feriados;
        }
    }
}
