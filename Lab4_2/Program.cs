using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab4_2
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
			public override string ToString()
			{
				return "X= " + x + ", Y= " + y;
			}
		}
		static void Main(string[] args)
		{
			List<point> l1 = new List<point>();
			l1.Add(new point());
			l1.Add(new point(1, 1));
			l1.Add(new point(2, 2));
			Console.WriteLine(point.Count);
			Console.WriteLine("List");
			foreach (point p in l1)
			{
				Console.WriteLine(p.ToString());
			}

			ArrayList l2 = new ArrayList();
			l2.Add(new point());
			l2.Add(new point(1, 1));
			l2.Add(new point(2, 2));
			Console.WriteLine(point.Count);
			Console.WriteLine("Array List");
			foreach (point p in l2)
			{
				Console.WriteLine(p.ToString());
			}
			Console.ReadLine();
		}
	}
}
