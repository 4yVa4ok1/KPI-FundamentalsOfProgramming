using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_6
{
	class Program
	{
		const string firstFileName = "E:\\Visual Studio Projects\\KPI\\Fundamentals of programming\\Laboratory 6\\1.txt";
		const string secondFileName = "E:\\Visual Studio Projects\\KPI\\Fundamentals of programming\\Laboratory 6\\2.txt";

		static void Main(string[] args)
		{
			CountArray();
		}

		static void ReorderArray()
		{
			var line = File.ReadLines(firstFileName).FirstOrDefault();
			var arr = line.Split(' ').Select(r => decimal.Parse(r)).Reverse().Select(s=>s.ToString()).ToArray();
			File.WriteAllText(firstFileName, string.Join(" ", arr));
			Console.WriteLine(File.ReadLines(firstFileName).FirstOrDefault());
			Console.ReadKey();
		}

		static void CountArray()
		{
			var lines = File.ReadLines(secondFileName);

			int columns = lines.Count();
			int rows = lines.Count();
			int[][] arr = lines.Select(l=>l.Split(' ').Select(n=>int.Parse(n)).ToArray()).ToList().ToArray();
			int result = default;
			for (int row = 0; row < rows; row++)
			{
				for (int column = 0; column < columns; column++)
				{
					result += arr[row][column];
				}
				columns--;
			}
			Console.WriteLine(result);
			Console.ReadKey();
		}
	}
}
