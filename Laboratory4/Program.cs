using System;
using System.Linq;

namespace Laboratory4
{
	class Program
	{
		static void Main()
		{
			CountMatrix();
		}

		static private void CountMatrix()
		{
			Console.WriteLine("Введите порядок матрицы");
			while (true)
			{
				var arrSizeString = Console.ReadLine();
				if (int.TryParse(arrSizeString, out int arrSize))
				{
					Random random = new Random();
					int[,] arr = new int[arrSize, arrSize];
					for (int row = 0; row < arrSize; row++)
					{
						for (int column = 0; column < arrSize; column++)
						{
							arr[row, column] = random.Next(0, 10);
						}
					}

					Console.WriteLine();

					for (int row = 0; row < arrSize; row++)
					{
						for (int column = 0; column < arrSize; column++)
						{
							Console.Write($"{arr[row, column]} ");
						}
						Console.WriteLine();
					}

					/*
					Элементы на побочной диагонали и выше - это все элементы, сумма индексов которых меньше размерности массива.
					Или же все элементы первой строки + все элементы последующих строк, где в каждой последующей строке нужно брать на один элемент меньше
					*/
					int columns = arrSize;
					int sum = default;
					for (int row = 0; row < arrSize; row++)
					{
						for (int col = 0; col < columns; col++)
						{
							sum += arr[row, col];
						}
						columns--;
					}

					Console.WriteLine();
					Console.WriteLine(sum);
					Console.WriteLine();
					Console.WriteLine("Введите рапорядок матрицы");
				}
				else
				{
					Console.WriteLine("Вы ввели неправильные данные. Попробуйте ещё раз");
					Console.WriteLine();
				}
			}
		}

		static private void OrderNumbers()
		{
			Console.WriteLine("Введите числа через пробел");
			while (true)
			{
				try
				{
					var arr = Console.ReadLine().Split(' ').Select(r => decimal.Parse(r)).OrderBy(r => r).ToArray();
					Console.WriteLine(string.Join(" ", arr));
					Console.ReadKey();
				}
				catch
				{
					Console.WriteLine("Вы ввели неправильные данные. Попробуйте ещё раз");
					Console.WriteLine();
				}
			}
		}
	}
}
