using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7_3_Bonus
{
	public partial class Form1 : Form
	{
		Point pt1, pt2;
		Pen pen = new Pen(Color.Black, 1);
		Keys key1 = Keys.None, key2 = Keys.None;
		List<items> rects = new List<items>();
		List<items> circs = new List<items>();
		List<items> lines = new List<items>();
		List<items> trian = new List<items>();
		public Form1()
		{
			InitializeComponent();
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = panel1.CreateGraphics();
			foreach (items item in rects)
			{
				graphics.DrawRectangle(item.pen, item.X, item.Y, item.W, item.H);
			}
			foreach (items item in circs)
			{
				graphics.DrawEllipse(item.pen, item.X, item.Y, item.W, item.H);
			}
			foreach (items item in lines)
			{
				graphics.DrawLine(item.pen, item.X, item.Y, item.W, item.H);
			}
			foreach (items item in trian)
			{
				graphics.DrawLines(item.pen, item.pts);
			}
		}
		private void panel1_MouseClick(object sender, MouseEventArgs e)
		{
			pt1.X = e.X;
			pt1.Y = e.Y;
			toolStripStatusLabel1.Text = e.X.ToString() + ", " + e.Y.ToString();
		}
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			key1 = Keys.Control;
			key2 = e.KeyCode;
			if (key1 == Keys.Control && key2 != Keys.None)
			{
				switch (key2)
				{
					case Keys.R:
						toolStripStatusLabel3.Text = "Rectangle";
						break;
					case Keys.C:
						toolStripStatusLabel3.Text = "Ellipse";
						break;
					case Keys.L:
						toolStripStatusLabel3.Text = "Line";
						break;
					case Keys.T:
						toolStripStatusLabel3.Text = "Triangle";
						break;
				}
			}
		}
		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			key1 = key2 = Keys.None;
			toolStripStatusLabel3.Text = "Shape";
		}
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			if (key1 == Keys.Control && key2 != Keys.None)
			{
				int p1 = pt2.X > pt1.X ? pt1.X : pt2.X;
				int p2 = pt2.Y > pt1.Y ? pt1.Y : pt2.Y;
				int p3 = pt2.X > pt1.X ? pt2.X - pt1.X : pt1.X - pt2.X;
				int p4 = pt2.Y > pt1.Y ? pt2.Y - pt1.Y : pt1.Y - pt2.Y;
				switch (key2)
				{
					case Keys.R:
						rects.Add(new items(pen, p1, p2, p3, p4));
						break;
					case Keys.C:
						circs.Add(new items(pen, p1, p2, p3, p4));
						break;
					case Keys.L:
						lines.Add(new items(pen, pt1.X, pt1.Y, pt2.X, pt2.Y));
						break;
					case Keys.T:
						Point[] pts = {
							new Point((pt1.X + pt2.X) / 2, pt1.Y),
							new Point(pt1.X, pt2.Y),
							new Point((pt1.X + pt2.X) / 2, pt1.Y),
							new Point(pt2.X, pt2.Y),
							new Point(pt1.X, pt2.Y),
							new Point(pt2.X, pt2.Y)
						};
						trian.Add(new items(pen, pts));
						break;
				}
			}
			toolStripStatusLabel1.Text = "0, 0";
		}
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			pt2.X = e.X;
			pt2.Y = e.Y;
			toolStripStatusLabel2.Text = e.X.ToString() + ", " + e.Y.ToString();
			if (e.Button == MouseButtons.Left && key1 == Keys.Control && key2 != Keys.None)
			{
				Graphics g = panel1.CreateGraphics();
				g.Clear(Color.White);
				int p1 = pt2.X > pt1.X ? pt1.X : pt2.X;
				int p2 = pt2.Y > pt1.Y ? pt1.Y : pt2.Y;
				int p3 = pt2.X > pt1.X ? pt2.X - pt1.X : pt1.X - pt2.X;
				int p4 = pt2.Y > pt1.Y ? pt2.Y - pt1.Y : pt1.Y - pt2.Y;
				switch (key2)
				{
					case Keys.R:
						g.DrawRectangle(pen, p1, p2, p3, p4);
						break;
					case Keys.C:
						g.DrawEllipse(pen, p1, p2, p3, p4);
						break;
					case Keys.L:
						g.DrawLine(pen, pt1.X, pt1.Y, pt2.X, pt2.Y);
						break;
					case Keys.T:
						Point[] pts = {
							new Point((pt1.X + pt2.X) / 2, pt1.Y),
							new Point(pt1.X, pt2.Y),
							new Point((pt1.X + pt2.X) / 2, pt1.Y),
							new Point(pt2.X, pt2.Y),
							new Point(pt1.X, pt2.Y),
							new Point(pt2.X, pt2.Y)
						};
						g.DrawLines(pen, pts);
						break;
				}
				Invalidate();
			}
		}
		sealed class items
		{
			int _X, _Y, _W, _H;
			Pen _pen;
			Point[] _pts;
			public items(Pen pen_, int X_, int Y_, int W_, int H_)
			{
				_pen = pen_;
				_X = X_;
				_Y = Y_;
				_W = W_;
				_H = H_;
			}
			public items(Pen pen_, Point[] pts_)
			{
				_pen = pen_;
				_pts = pts_;
			}
			public int X { get => _X; set => _X = value; }
			public int Y { get => _Y; set => _Y = value; }
			public int W { get => _W; set => _W = value; }
			public int H { get => _H; set => _H = value; }
			public Pen pen { get => _pen; set => _pen = value; }
			public Point[] pts { get => _pts; set => _pts = value; }
		}
		private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripStatusLabel3.Text = "Rectangle";
			key1 = Keys.Control;
			key2 = Keys.R;
		}
		private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripStatusLabel3.Text = "Ellipse";
			key1 = Keys.Control;
			key2 = Keys.C;
		}
		private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripStatusLabel3.Text = "Triangle";
			key1 = Keys.Control;
			key2 = Keys.T;
		}
		private void lineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripStatusLabel3.Text = "Line";
			key1 = Keys.Control;
			key2 = Keys.L;
		}
		private void blackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pen = new Pen(Color.Black, pen.Width);
		}
		private void redToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pen = new Pen(Color.Red, pen.Width);
		}
		private void greenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pen = new Pen(Color.Green, pen.Width);
		}
		private void blueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pen = new Pen(Color.Blue, pen.Width);
		}
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			pen = new Pen(pen.Color, 1);
		}
		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			pen = new Pen(pen.Color, 2);
		}
		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			pen = new Pen(pen.Color, 3);
		}
		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
			pen = new Pen(pen.Color, 4);
		}
		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			pen = new Pen(pen.Color, 5);
		}
		private void toolStripMenuItem7_Click(object sender, EventArgs e)
		{
			pen = new Pen(pen.Color, 6);
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			pen = new Pen(pen.Color, 7);
		}
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}