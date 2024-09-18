using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("insira uma letra: ");
		string texto = Console.ReadLine();
		char letra = char.Parse(texto);
		switch (letra)
		{
			case 'A':
			case 'E':
			case 'I':
			case 'O':
			case 'U':
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u':
				Console.WriteLine($"a letra {letra} e uma vogal: ");
				break;
			default:
				Console.WriteLine($"a letra {letra} é uma consoante: ");
				break;
		}
	}
}