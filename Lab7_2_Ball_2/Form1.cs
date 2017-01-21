using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7_2_Ball_2
{
	public partial class Form1 : Form
	{
		int diameter = 100;
		int speed = 10;
		Point p, oldp;
		int counter = 0;
		public Form1()
		{
			InitializeComponent();

			p = oldp = new Point(0, panel1.Height);
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			DrawBall();
		}
		public void DrawBall()
		{
			Graphics g1 = panel1.CreateGraphics();
			Graphics g2 = panel2.CreateGraphics();
			Brush brush = new SolidBrush(Color.Green);
			p.X = validateY(p.X);
			p.Y = validateY(p.Y);
			oldp.X = validateY(oldp.X);
			oldp.Y = validateY(oldp.Y);
			g1.FillEllipse(brush, oldp.X - diameter / 2, oldp.Y - diameter / 2, diameter, diameter);
			g2.FillEllipse(brush, oldp.X - diameter / 2, oldp.Y - diameter / 2, diameter, diameter);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (p.X == diameter / 2 && oldp.X == diameter / 2)
			{
				timer2.Enabled = false;
				if (p.Y - oldp.Y > 0)
				{
					DrawBall();
					panel1.Refresh();
					oldp.Y += speed;
					panel2.Refresh();
					DrawBall();
				}
				else if (p.Y - oldp.Y < 0)
				{
					DrawBall();
					panel2.Refresh();
					oldp.Y -= speed;
					panel1.Refresh();
					DrawBall();
				}
				else
				{
					timer1.Enabled = false;
					p.X = panel1.Width;
					timer2.Enabled = true;
				}
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (p.X - oldp.X > 0)
			{
				DrawBall();
				panel1.Refresh();
				oldp.X += speed;
				panel2.Refresh();
				DrawBall();
			}
			else if (p.X - oldp.X < 0)
			{
				DrawBall();
				panel2.Refresh();
				oldp.X -= speed;
				panel1.Refresh();
				DrawBall();
			}
			else
			{
				++counter;
				if (counter % 2 == 0)
				{
					p.X = 0;
				}
				else if (counter % 2 != 0)
				{
					p.X = panel1.Width;
				}
			}
		}

		private void Click_MouseUp(object sender, MouseEventArgs e)
		{
			oldp.Y = p.Y;
			p.Y = validateClick(e.Y);
			timer1.Enabled = true;
		}
		int validateX(int num)
		{
			if (num - diameter / 2 < 0)
			{
				num = diameter / 2;
			}
			if (num + diameter / 2 > panel1.Width)
			{
				num = panel1.Width - diameter / 2;
			}
			return num;
		}
		int validateY(int num)
		{
			if (num - diameter / 2 < 0)
			{
				num = diameter / 2;
			}
			if (num + diameter / 2 > panel1.Height)
			{
				num = panel1.Height - diameter / 2;
			}
			return num;
		}
		int validateClick(int num)
		{
			if (Math.Abs(p.Y - num) % speed != 0)
			{
				num = validateClick(num + 1);
			}
			return num;
		}
	}
}
