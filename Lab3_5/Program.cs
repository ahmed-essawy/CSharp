using System;

namespace Lab3_5
{
	class Program
	{
		static void Main(string[] args)
		{
			string str = Console.ReadLine();
			string neo = "";
			for (int i = str.Length-1; i >= 0; i--)
			{
				neo += str[i];
			}
			Console.WriteLine(neo.ToUpper());
			Console.ReadLine();
		}
	}
}
