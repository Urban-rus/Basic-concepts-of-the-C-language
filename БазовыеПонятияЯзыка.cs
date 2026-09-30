using System;

namespace BasicConceptsOfTheLanguage
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine("Задание 1: Вычисление a^n");

			Console.Write("Введите натуральное число a: ");
			int a = int.Parse(Console.ReadLine());

			Console.Write("Введите натуральное число n: ");
			int n = int.Parse(Console.ReadLine());

			long result = 1;
			
			for (int i = 0; i < n; i++)
			{
				result *= a;
			}

			Console.WriteLine($"{a}^{n} = {result}");
			Console.WriteLine(new string('-', 30));

			Console.WriteLine("Задание 2: Перестановка второй цифры");

			Console.Write("Введите число x (x >= 100): ");
			string xStr = Console.ReadLine();

			if (long.TryParse(xStr, out long x) && x >= 100)
			{
				char secondDigit = xStr[1];

				string remainingPart = xStr.Remove(1, 1);

				string nStr = remainingPart + secondDigit;

				Console.WriteLine($"Входное число x = {xStr}");
				Console.WriteLine($"Полученное число n = {nStr}");
			}
			else
			{
				Console.WriteLine("Ошибка: введено некорректное число или x < 100.");
			}

			Console.ReadLine();
		}
	}
}