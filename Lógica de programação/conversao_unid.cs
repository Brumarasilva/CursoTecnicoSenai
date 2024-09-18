using System;
					
public class Program
{
	public static void Main()
	{
		//digite a distancia em metros
		Console.Write("digite a distancia em metros: ");
		string texto = Console.ReadLine();
		decimal metro = decimal.Parse(texto);
		
		Console.Write("em qual unidade voce gostaria de converter:cm, km, mi: ");
		//realize a conversão das variaveis (cm, km, mi:)
		switch(Console.ReadLine())
			
		{
			case "cm":
				decimal resultado = metro*100;
				Console.WriteLine($"resultado: {resultado}cm");
				break;
				
			case "km":
				resultado = metro/1000;
				Console.WriteLine($"resultado: {resultado}km");
				break;
				
			case "mi":
				resultado = metro/1609;
				Console.WriteLine($"resultado: {resultado}mi");
				break;
				//mensagem de erro caso o usuario digite um caractere invalido na conversão de unidades.
			default: 
				Console.WriteLine("conversão invalida ");
				break;
		}
			
	}
}