using System;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Podaj długość krótszej przekątnej diamentu: ");
		int dlugosc = Convert.ToInt32(Console.ReadLine());

		RysujDiament(dlugosc);
	}

	static void RysujDiament(int dlugosc)
	{
		// Górna część diamentu
		for (int i = 1; i <= dlugosc; i += 2)
		{
			Console.Write(new string(' ', (dlugosc - i) / 2));
			Console.WriteLine(new string('*', i));
		}

		// Dolna część diamentu
		for (int i = dlugosc - 2; i > 0; i -= 2)
		{
			Console.Write(new string(' ', (dlugosc - i) / 2));
			Console.WriteLine(new string('*', i));
		}
	}
}