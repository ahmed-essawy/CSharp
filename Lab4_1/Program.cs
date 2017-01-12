using System;

namespace Lab4_1
{
	class Program
	{
		sealed class point
		{
			int x, y;
			static int count;
			public point() : this(0, 0) { }
			public point(int x, int y) { this.x = x; this.y = y; ++count; }
			public int X
			{
				set { x = value; }
				get { return x; }
			}
			public int Y
			{
				set { y = value; }
				get { return y; }
			}
			public static int Count
			{
				get { return count; }
			}
			static point() { count = 0; }
			~point() { --count; }
		}
		static void Main(string[] args)
		{
			point p1 = new point();
			Console.WriteLine(point.Count);
			point p2 = new point();
			Console.WriteLine(point.Count);
			point p3 = new point();
			Console.WriteLine(point.Count);
			/*p3 = null;
			GC.Collect();
			Console.WriteLine(point.Count);*/
			Console.ReadLine();
		}
	}
}