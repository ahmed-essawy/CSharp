using System;

namespace Lab4_3
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

		static void Main(string[] args)
		{
			shape circ = new circ(2);
			Console.WriteLine("Circle= " + circ.Area());
			shape rect = new rect(2, 3);
			Console.WriteLine("Rectangle= " + rect.Area());
			shape squr = new squr(2);
			Console.WriteLine("Square= " + squr.Area());
			shape trin = new trin(2, 3);
			Console.WriteLine("Triangle= " + trin.Area());
			Console.ReadLine();
		}
	}
}