using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab7_1
{
	public partial class Form1 : Form
	{
		string c_name = "ABC Company";
		string[] yrs = { "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997" };
		string[] rvn = { "150", "170", "180", "175", "200", "250", "210", "240", "280", "140" };
		Color color = Color.Blue;
		public Form1()
		{
			InitializeComponent();
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			int y = 0;
			y += DrawStr(c_name, 20, 0, y);
			y += DrawStr("Annual Revenue", 18, 0, y);
			int x = this.Width - 100;
			for (int i = yrs.Length - 1; i >= 0; i--, x -= 60)
			{
				DrawRect(yrs[i], x, y, 60, 60);
			}
			DrawRect("Year", x - 40, y, 100, 60);
			y += 60;
			x = this.Width - 100;
			for (int i = rvn.Length - 1; i >= 0; i--, x -= 60)
			{
				DrawRect(rvn[i], x, y, 60, 60);
			}
			DrawRect("Revenue", x - 40, y, 100, 60);
			y += 60;
			Pen pen = new Pen(Color.Black, 1);
			pen.EndCap = LineCap.ArrowAnchor;
			Pen penR = new Pen(Color.Red, 1);
			Font font = new Font("Arial", 16);
			SolidBrush brush = new SolidBrush(Color.Black);
			Point orgin = new Point(100, this.Height - 100);
			e.Graphics.DrawLine(pen, orgin.X, orgin.Y, orgin.X + 1100, orgin.Y);
			e.Graphics.DrawLine(pen, orgin.X, orgin.Y, orgin.X, orgin.Y - 940);
			pen.StartCap = LineCap.RoundAnchor;
			pen.EndCap = LineCap.RoundAnchor;
			for (int i = 0, cx = orgin.X; i < yrs.Length; i++, cx += 100)
			{
				e.Graphics.DrawString(yrs[i], font, brush, cx + 70, orgin.Y + 10);
				e.Graphics.DrawLine(penR, cx + 100, orgin.Y + 8, cx + 100, orgin.Y - (int.Parse(rvn[i]) - 140 + 10) * 5);
			}
			for (int i = 140, cy = orgin.Y - 50; i <= 300; i += 10, cy -= 50)
			{
				e.Graphics.DrawString(i.ToString(), font, brush, orgin.X - 55, cy - 12);
				e.Graphics.DrawLine(pen, orgin.X - 8, cy, orgin.X + 1050, cy);
			}
			DrawGraph(orgin);
		}
		public int DrawStr(string str, int size, int x, int y)
		{
			Graphics graphic = this.CreateGraphics();
			Rectangle rect = new Rectangle(x, y, this.Width, size * 2);
			Font font = new Font("Arial", size);
			SolidBrush brush = new SolidBrush(Color.Black);
			StringFormat sf = new StringFormat();
			sf.Alignment = StringAlignment.Center;
			sf.LineAlignment = StringAlignment.Center;
			graphic.DrawString(str, font, brush, rect, sf);
			return size * 2;
		}
		public void DrawRect(string str, int x, int y, int w, int h)
		{
			Pen pen = new Pen(Color.Black, 3);
			Font font = new Font("Arial", 16);
			SolidBrush brush = new SolidBrush(Color.Black);
			Graphics graphic = this.CreateGraphics();
			StringFormat sf = new StringFormat();
			sf.Alignment = StringAlignment.Center;
			sf.LineAlignment = StringAlignment.Center;
			Rectangle rect = new Rectangle(x, y, w, h);
			graphic.DrawRectangle(pen, x, y, w, h);
			graphic.DrawString(str, font, brush, rect, sf);
		}
		public void DrawGraph(Point orgin)
		{
			Graphics graphic = this.CreateGraphics();
			Pen pen = new Pen(color, 3);
			HatchBrush brushR = new HatchBrush(HatchStyle.BackwardDiagonal, Color.White, Color.FromArgb(175, 255, 0, 0));
			int xx = orgin.X + 100;
			int yy = orgin.Y - (int.Parse(rvn[0]) - 140 + 10) * 5;
			for (int i = 0, cx = orgin.X, cy = orgin.Y; i < rvn.Length && i < yrs.Length; i++, cy -= 50, cx += 100)
			{
				graphic.DrawLine(pen, xx, yy, cx + 100, orgin.Y - (int.Parse(rvn[i]) - 140 + 10) * 5);
				xx = cx + 100;
				yy = orgin.Y - (int.Parse(rvn[i]) - 140 + 10) * 5;
				Rectangle rect = new Rectangle(xx - 10, yy, 20, orgin.Y - yy);
				graphic.FillRectangle(brushR, rect);
			}
		}
		public void changeGraph(Point orgin)
		{
			Graphics graphic = this.CreateGraphics();
			Pen pen = new Pen(color, 3);
			int xx = orgin.X + 100;
			int yy = orgin.Y - (int.Parse(rvn[0]) - 140 + 10) * 5;
			for (int i = 0, cx = orgin.X, cy = orgin.Y; i < rvn.Length && i < yrs.Length; i++, cy -= 50, cx += 100)
			{
				graphic.DrawLine(pen, xx, yy, cx + 100, orgin.Y - (int.Parse(rvn[i]) - 140 + 10) * 5);
				xx = cx + 100;
				yy = orgin.Y - (int.Parse(rvn[i]) - 140 + 10) * 5;
			}
		}
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (Control.ModifierKeys == Keys.Control)
			{
				Point p = new Point(100, this.Height - 100);
				switch (e.KeyCode)
				{
					case Keys.R:
						color = Color.Red;
						break;
					case Keys.G:
						color = Color.Green;
						break;
					case Keys.B:
						color = Color.Blue;
						break;
				}
				changeGraph(p);
			}
		}
		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			int height = (((this.Height - 100) - e.Y) / 5) + 130;
			if (height <= 300 && height >= 140 && e.X >= 100 && e.X <= 1200)
			{
				MessageBox.Show(height.ToString());
			}
		}
	}
}