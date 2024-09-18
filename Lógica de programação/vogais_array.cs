using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("insira uma letra: ");
		string texto = Console.ReadLine();
		char letra = char.Parse(texto);
		char[] vogais =
		{
			'a',
			'A',
			'e',
			'E',
			'i',
			'I',
			'o',
			'O',
			'u',
			'U'
		};
		char[] consoantes =
		{
			'b',
			'c',
			'd',
			'f',
			'g',
			'h',
			'j',
			'k',
			'l',
			'm',
			'n',
			'p',
			'q',
			'r',
			's',
			't',
			'v',
			'w',
			'x',
			'y',
			'z'
		};
		foreach (char vogal in vogais)
		{
			if (vogal == letra)
			{
				Console.WriteLine("a letra digitada e uma vogal ");
				break;
			}
			else
			{
				Console.WriteLine("a letra e uma consoante ");
				break;
			}
		}
	}
}