using System;

namespace Lab3_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] students = new int[3, 4];
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					Console.Write("Enter student " + i + 1 + " Sub " + j + 1 + " ");
					students[i, j] = int.Parse(Console.ReadLine());
				}
			}
			int sum = 0;
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					sum += students[i, j];
				}
				Console.WriteLine("Student " + i + 1 + " sum: " + sum);
				sum = 0;
			}
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					sum += students[j, i];
				}
				Console.WriteLine("Subjects " + i + 1 + " avg: " + sum / 4);
				sum = 0;
			}
			Console.ReadLine();
		}
	}
}
