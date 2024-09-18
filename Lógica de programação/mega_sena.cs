using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("insira a quantidade de jogos: ");
		string texto = Console.ReadLine();
		int numero = int.Parse(texto);
		Console.WriteLine("insira a quantidade de dezenas: ");
		texto = Console.ReadLine();
		int quantidade = int.Parse(texto);
		while (quantidade < 6 || quantidade > 15)
		{
			Console.WriteLine("insira novamente a quantidade de dezenas entre 6 e 15: ");
			texto = Console.ReadLine();
			quantidade = int.Parse(texto);
		}

		Random random = new Random();
		int dezenas;
		if (quantidade >= 6)
		{
			for (int contadorJogos = 1; contadorJogos <= numero; contadorJogos++)
			{
				for (int contador = 1; contador <= quantidade; contador++)
				{
					dezenas = random.Next(1, 61);
					if (contador == quantidade)
					{
						Console.Write($"{dezenas:D2}\n");
					}
					else
					{
						Console.Write($"{dezenas:D2}-");
					}
				}
			}

			Console.WriteLine("informe o valor do prêmio: ");
			texto = Console.ReadLine();
			decimal valpremio = decimal.Parse(texto);
			decimal valpremio6dez = valpremio * 0.75m;
			decimal valpremio5dez = valpremio * 0.15m;
			decimal valpremio4dez = valpremio * 0.10m;
			
			Console.WriteLine($"{valpremio6dez}-valor para quem acertar 6 dezenas ");
			Console.WriteLine($"{valpremio5dez}-valor para quem acertar 5 dezenas ");
			Console.WriteLine($"{valpremio4dez}-valor para quem acertar 4 dezenas ");
			
		}
	}
}