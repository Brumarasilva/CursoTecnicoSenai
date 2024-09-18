using System;
					
public class Program
{
	public static void Main()
	{
		//imprimir na tela uma instrução ao usuario
		Console.WriteLine("informe o salario bruto");
		//guardar a informação digitada pelo usuario
		string texto = Console.ReadLine();
		//realizar a conversão de texto para decimal
		decimal salario = decimal.Parse(texto);
		//se o salario for<= R$3.000 reais, então, calcular imposto de 10%
		if (salario <= 3000)
			
			
		{
			decimal resultado = salario * 0.1m;
			Console.WriteLine($"{resultado}");
		}
		else if (salario <= 6000)
		
		{
			decimal resultado = salario * 0.15m;
			Console.WriteLine($"{resultado}");
		}
		else 
		{
			decimal resultado = salario * 0.20m;
			Console.WriteLine($"{resultado}");
		}
		
	}  
}