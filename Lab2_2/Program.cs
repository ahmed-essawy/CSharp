using System;

namespace Lab2_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a: ");
			float a = float.Parse(Console.ReadLine());
			Console.Write("Enter b: ");
			float b = float.Parse(Console.ReadLine());
			Console.Write("Enter c: ");
			float c = float.Parse(Console.ReadLine());
			int flag;
			double x1, x2;
			solve_equ(a, b, c, out flag, out x1, out x2);
			switch(flag)
			{
				case 1:
					Console.WriteLine("X1 = " + x1 + ", X2 = " + x2);
					break;
				case 2:
					Console.WriteLine("X1 = X2 = " + x2);
					break;
				case 3:
					Console.WriteLine("X1 " + x1 + "+" + x2 + "i\nX2 " + x1 + "-" + x2 + "i");
					break;
			}
			Console.ReadLine();
		}
		static void solve_equ(float a, float b, float c,out int flag, out double x1, out double x2)
		{
			float sqrt = b * b - 4 * a * c;
			if (sqrt >= 0)
			{
				flag = sqrt > 0 ? 1 : 2;
				x1 = (-b + Math.Sqrt(sqrt)) / (2 * a);
				x2 = (-b - Math.Sqrt(sqrt)) / (2 * a);
			}
			else
			{
				flag = 3;
				x1 = -b / (2 * a);
				x2 = Math.Sqrt(-sqrt) / (2 * a);
			}
		}
	}
}
