using System;

namespace Lab2_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter num: ");
			int num = int.Parse(Console.ReadLine());
			int rev = 0;
			while (num > 0)
			{
				int r = num % 10;
				rev = rev * 10 + r;
				num = num / 10;
			}
			Console.WriteLine("Reversed : " + rev);
			 /*char[] arr = Console.ReadLine().ToCharArray();
			 Array.Reverse(arr);
			 int num = int.Parse(new string(arr));
			 Console.WriteLine("Reversed: " + num);*/
			 Console.ReadLine();
		}
	}
}
