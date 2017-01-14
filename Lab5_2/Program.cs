using System;

namespace Lab5_2_Exception
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] li = new int[2];
			try
			{
				li[2] = 0;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				Console.WriteLine("Max length: " + li.Length);
			}
			Console.ReadKey();
		}
	}
}