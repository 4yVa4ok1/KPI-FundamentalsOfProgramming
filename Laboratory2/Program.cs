using System;

namespace Laboratory2
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Для выхода из программы включите CAPS LOCK и NUM LOCK");
			while (true)
			{
				if (!Console.CapsLock)
				{
					Console.WriteLine("Верхний регистр выключен");
				}
				if (!Console.NumberLock)
				{
					Console.WriteLine("Фиксация цифр выключена");
				}

				Console.ReadKey();
				Console.WriteLine();
				if(Console.CapsLock && Console.NumberLock)
				{
					Environment.Exit(default);
				}
			}
		}
	}
}
