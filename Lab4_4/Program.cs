using System;

namespace Lab4_4
{
	class Program
	{
		abstract class shape
		{
			protected int d1, d2;
			public int D1
			{
				set { d1 = value; }
				get { return d1; }
			}
			public int D2
			{
				set { d2 = value; }
				get { return d2; }
			}
			public shape() : this(0) { }
			public shape(int d1) : this(d1, d1) { }
			public shape(int d1 = 0, int d2 = 0) { this.d1 = d1; this.d2 = d2; }
			public abstract double Area();
			public override string ToString()
			{
				return base.ToString();
			}
		}
		class circ : shape
		{
			public circ(int r) : base(r) { }
			public override double Area()
			{
				return 3.14 * d1 * d2;
			}
		}
		class rect : shape
		{
			public rect(int d1, int d2) : base(d1, d2) { }
			public override double Area()
			{
				return d1 * d2;
			}
		}
		class squr : rect
		{
			public squr(int d) : base(d, d) { }
		}
		class trin : shape
		{
			public trin(int d1 = 0, int d2 = 0) : base(d1, d2) { }
			public override double Area()
			{
				return 0.5 * d1 * d2;
			}
		}
		class geoShape
		{
			shape[] shapes;
			public geoShape(params shape[] shapes)
			{
				this.shapes = shapes;
			}
			public double Area
			{
				get
				{
					double area = 0;
					foreach (shape s in shapes)
					{
						area += s.Area();
					}
					return area;
				}
			}
		}
		static void Main(string[] args)
		{
			shape c = new circ(2);
			Console.WriteLine("Circle= " + c.Area());
			shape r = new rect(2, 3);
			Console.WriteLine("Rectangle= " + r.Area());
			shape s = new squr(2);
			Console.WriteLine("Square= " + s.Area());
			shape t = new trin(2, 3);
			Console.WriteLine("Triangle= " + t.Area());
			geoShape total = new geoShape(c, r, s, t);
			Console.WriteLine("Total area= " + total.Area);
			Console.WriteLine("Total area= " + (c.Area() + r.Area() + s.Area() + t.Area()));
			Console.ReadLine();
		}
	}
}