using System;

namespace Lab5_3_Delegates
{
	class Program
	{
		public delegate void dg(string n);
		static void Main(string[] args)
		{
			dg test = new dg(func1);
			test("Printable String 1");
			test("Printable String 2");
			Console.WriteLine("\nAdding func2:\n");
			test += func2;
			test("Printable String 1");
			test("Printable String 2");
			Console.WriteLine("\nRemove func1:\n");
			test -= func1;
			test("Printable String 1");
			test("Printable String 2");
			Console.ReadKey();
		}
		public static void func1(string str)
		{
			Console.WriteLine(str + " From func1");
		}
		public static void func2(string str)
		{
			Console.WriteLine(str + " From func2");
		}
	}
}