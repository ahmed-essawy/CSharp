using System;

namespace Lab5_4_Events
{
	class Program
	{
		delegate void handler(string str);
		class sender
		{
			int error;
			public event handler err1;
			public event handler err2;
			public event handler noerr;
			public void readerr()
			{
				Console.Write("Enter error #: ");
				error = int.Parse(Console.ReadLine());
				if (error == 1)
				{
					if (err1 != null)
					{
						err1("Error #: " + error);
					}
				}
				else if (error == 2)
				{
					if (err2 != null)
					{
						err2("Error #: " + error);
					}
				}
				else
				{
					noerr("Error #: " + error+" not listed!");
				}
			}
		}
		static void Main(string[] args)
		{
			sender s = new sender();
			s.err1 += new handler(func1);
			s.err2 += new handler(func2);
			s.noerr += new handler(func3);
			s.readerr();
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
		public static void func3(string str)
		{
			Console.WriteLine(str + " From func3");
		}
	}
}
