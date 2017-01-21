using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7_2_Ball
{
	public partial class Form1 : Form
	{
		Point p, oldp;
		public Form1()
		{
			InitializeComponent();
			p = oldp = new Point(0, this.Height);
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			DrawBall();
		}
		public void DrawBall()
		{
			Graphics g = this.CreateGraphics();
			int rad = 100;
			Brush brush = new SolidBrush(Color.Green);
			if (p.Y > this.Height)
			{
				p.Y = this.Height;
			}
			else if (p.Y - rad - 40 < 0)
			{
				p.Y = rad + 40;
			}
			g.FillEllipse(brush, p.X, p.Y - rad - 40, rad, rad);
			while (Convert.ToBoolean(--oldp.Y) && p.Y - oldp.Y < 0)
			{
				int n = 100000;
				while (Convert.ToBoolean(n--)) ;
				g.Clear(Color.White);
				g.FillEllipse(brush, p.X, oldp.Y - rad - 40 - 1, rad, rad);
				g.FillEllipse(brush, p.X, oldp.Y - rad - 40, rad, rad);
			}
			while (Convert.ToBoolean(oldp.Y++) && p.Y - oldp.Y > 0)
			{
				int n = 100000;
				while (Convert.ToBoolean(n--)) ;
				g.Clear(Color.White);
				g.FillEllipse(brush, p.X, oldp.Y - rad - 40, rad, rad);
				g.FillEllipse(brush, p.X, oldp.Y - rad - 40 + 1, rad, rad);
			}
			while (Convert.ToBoolean(++p.X) && p.X - this.Width < 0 && Convert.ToBoolean(oldp.X))
			{
				int n = 100000;
				while (Convert.ToBoolean(n--)) ;
				g.Clear(Color.White);
				g.FillEllipse(brush, p.X + 1, p.Y - rad - 40, rad, rad);
				g.FillEllipse(brush, p.X, p.Y - rad - 40, rad, rad);
				if (p.X + rad + 40 / 2 > this.Width)
				{
					p.X = this.Width;
				}
			}
			while (Convert.ToBoolean(--p.X))
			{
				int n = 100000;
				while (Convert.ToBoolean(n--)) ;
				g.Clear(Color.White);
				g.FillEllipse(brush, p.X - rad - 40 / 2 - 1, p.Y - rad - 40, rad, rad);
				g.FillEllipse(brush, p.X - rad - 40 / 2, p.Y - rad - 40, rad, rad);
				if (p.X - rad - 40 / 2 < 0)
				{
					p.X = 1;
				}
			}
		}
		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			oldp = p;
			p.Y = e.Y + 50 + 40;
			p.X = 0;
			oldp.X = 1;
			Invalidate();
		}
	}
}
