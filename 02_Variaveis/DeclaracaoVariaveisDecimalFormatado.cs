using System;

class DeclaracaoVariaveisDecimalFormatado
{
		static void Main(string[] args)
		{
			decimal x = 0.999m;
			decimal y = 9999999999999999999999999999m;
			/*
			Utilizando PlaceHolder para demonstrar o conteúdo de uma variável no texto
			{0:C} 
			0 = posição de marcação
			C = formatação de moeda (Currency) 
			placeholder deve estar envolvido dentro de chaves 
			*/
			
			Console.WriteLine("Minha quantia = {0:C}", x);
			Console.WriteLine("Sua quantia = {0:C}", y);
			Console.WriteLine ("Valor de x = {0:F3} e Valor de y = {1:C}",x,y);
			
			
			/*
			Interpolação de String, só funciona no.NET versão 6.0 acima  
			*/  
			
			Console.WriteLine($"Minha quantia = {x:C}", x);
			Console.WriteLine($"Sua quantia = {y:C}", y);
			Console.WriteLine ($"Valor de x = {x:F3} e Valor de y = {y:C}",x,y);
			
		}
	
}