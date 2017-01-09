using System;

namespace Lab3_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[][] students = new int[3][];
			for (int i = 0; i < students.Length; i++)
			{

				Console.Write("Enter student "+i+" subjects # ");
				int num = int.Parse(Console.ReadLine());
				students[i] = new int[num];
				for (int j = 0; j < num; j++)
				{
					Console.Write("Enter student " + i + 1 + " Sub " + j + 1 + " ");
					students[i][j] = int.Parse(Console.ReadLine());
				}
			}
			int sum = 0;
			for (int i = 0; i < students.Length; i++)
			{
				for (int j = 0; j < students[i].Length; j++)
				{
					sum += students[i][j];
				}
				Console.WriteLine("Student " + i + 1 + " sum: " + sum);
				sum = 0;
			}
			/*for (int i = 0; i < students.Length; i++)
			{
				for (int j = 0; j < ; j++)
				{
						sum += students[j][i];
				}
				Console.WriteLine("Subjects " + i + 1 + " avg: " + sum / students[i].Length);
				sum = 0;
			}*/
			Console.ReadLine();
		}
	}
}
