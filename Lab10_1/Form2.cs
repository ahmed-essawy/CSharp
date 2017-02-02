using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_1
{
	public partial class Form2 : Form
	{
		Form1 opener;
		string str, font;
		int size;
		Color color;
		public Form2( Form1 parentForm, string c_name, string c_font, int c_size, Color c_color )
		{
			InitializeComponent();
			opener = parentForm;
			this.radioButton1.Checked = false;
			this.radioButton2.Checked = false;
			this.radioButton3.Checked = false;
			this.radioButton4.Checked = false;
			this.radioButton5.Checked = false;
			this.radioButton6.Checked = false;
			switch(c_font)
			{
				case "Time New Roman":
				this.radioButton1.Checked = true;
				break;
				case "Arial":
				this.radioButton2.Checked = true;
				break;
				case "Courier":
				this.radioButton3.Checked = true;
				break;
			}
			switch(c_size)
			{
				case 16:
				this.radioButton4.Checked = true;
				break;
				case 20:
				this.radioButton5.Checked = true;
				break;
				case 24:
				this.radioButton6.Checked = true;
				break;
			}
			str = textBox1.Text = c_name;
			font = c_font;
			size = c_size;
			color = c_color;
		}
		public string Str { get => str; }
		public string Fon { get => font; }
		public int Siz { get => size; }
		public Color Colo { get => color; }
		private void Update( object sender, EventArgs e )
		{
			opener.Apply(str, font, size, color);
		}
		private void Save( object sender, EventArgs e )
		{
			DialogResult = DialogResult.OK;
		}
		private void Exit( object sender, EventArgs e )
		{
			Close();
		}
		private void ChooseColor_Click( object sender, EventArgs e )
		{
			colorDialog1.Color = color;
			colorDialog1.ShowDialog();
			color = colorDialog1.Color;
		}
		private void textBox2_TextChanged( object sender, EventArgs e )
		{
			str = textBox2.Text;
		}
		private void radioButtontab1_CheckedChanged( object sender, EventArgs e )
		{
			if(( (RadioButton)sender ).Checked)
			{
				font = ( (RadioButton)sender ).Text;
			}
		}
		private void radioButtontab2_CheckedChanged( object sender, EventArgs e )
		{
			if(( (RadioButton)sender ).Checked)
			{
				size = int.Parse(( (RadioButton)sender ).Text);
			}
		}

	}
}