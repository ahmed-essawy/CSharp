using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11_1
{
	public partial class Form1 : Form
	{
		private int focused = 1;

		public Form1()
		{
			InitializeComponent();
			this_pc(this.listBox1, this.textBox1);
			this_pc(this.listBox2, this.textBox2);
		}

		private void this_pc( ListBox listbox, TextBox textbox )
		{
			listbox.Items.Clear();
			foreach(DriveInfo d in DriveInfo.GetDrives())
			{
				if(d.IsReady)
					listbox.Items.Add(d.Name);
			}
			listbox.SelectedIndex = 0;
			textbox.Text = "root";
		}

		private void listBox1_SelectedIndexChanged( object sender, EventArgs e )
		{
			try
			{
				string temp = ( (ListBox)sender ).SelectedItem.ToString();
				if(temp != "..")
					textBox1.Text = temp;
			}
			catch(Exception) { }
		}

		private void listBox2_SelectedIndexChanged( object sender, EventArgs e )
		{
			try
			{
				string temp = ( (ListBox)sender ).SelectedItem.ToString();
				if(temp != "..")
					textBox2.Text = temp;
			}
			catch(Exception) { }
		}

		private void listBox1_MouseDoubleClick( object sender, MouseEventArgs e )
		{
			string path = listBox1.SelectedItem.ToString();
			listBox1.Items.Clear();
			if(path != "..")
				ProcessDirectory(path, this.listBox1);
			else if(path == "..")
				ProcessDirectory(Path.GetDirectoryName(textBox1.Text), this.listBox1);
		}

		private void listBox2_MouseDoubleClick( object sender, MouseEventArgs e )
		{
			string path = listBox2.SelectedItem.ToString();
			listBox2.Items.Clear();
			if(path != "..")
				ProcessDirectory(path, this.listBox2);
			else if(path == "..")
				ProcessDirectory(Path.GetDirectoryName(textBox2.Text), this.listBox2);
		}

		public void ProcessDirectory( string path, ListBox listbox )
		{
			if(path != null && path != String.Empty && path != "..")
			{
				FileAttributes attr = File.GetAttributes(path);
				if(( attr & FileAttributes.Directory ) == FileAttributes.Directory)
				{
					if(listbox.Name == "listBox1")
						textBox1.Text = path;
					else if(listbox.Name == "listBox2")
						textBox2.Text = path;
					string[] contents = Directory.GetDirectories(path).Concat(Directory.GetFiles(path)).ToArray();
					foreach(string item in contents)
						ProcessFile(item, listbox);
					listbox.Items.Add("..");
				}
				else
					System.Diagnostics.Process.Start(path);
			}
			else
			{
				if(listbox.Name == "listBox1")
					this_pc(listbox, this.textBox1);
				else if(listbox.Name == "listBox2")
					this_pc(listbox, this.textBox2);
			}
		}

		public void ProcessFile( string path, ListBox listbox )
		{
			listbox.Items.Add(path);
		}

		private void button5_Click( object sender, EventArgs e )
		{
			if(focused == 1)
			{
				string path = textBox1.Text;
				listBox1.Items.Clear();
				ProcessDirectory(Path.GetDirectoryName(path), listBox1);
			}
			else if(focused == 2)
			{
				string path = textBox2.Text;
				listBox2.Items.Clear();
				ProcessDirectory(Path.GetDirectoryName(path), listBox2);
			}
		}

		private void focused_f( object sender, EventArgs e )
		{
			switch(( (ListBox)sender ).Name)
			{
				case "listBox1":
				focused = 1;
				break;

				case "listBox2":
				focused = 2;
				break;
			}
		}

		private void button1_Click( object sender, EventArgs e )
		{
			string file = listBox1.SelectedItem.ToString();
			string dest = textBox2.Text;
			if(file != String.Empty && dest != String.Empty)
			{
				string fileName = Path.GetFileName(file);
				string source = Path.GetDirectoryName(file);
				FileAttributes attr = File.GetAttributes(file);
				if(( attr & FileAttributes.Directory ) == FileAttributes.Directory)
				{
					if(!Directory.Exists(dest + fileName))
					{
						Directory.CreateDirectory(dest + fileName);
						listBox2.Items.RemoveAt(listBox2.Items.Count - 1);
						listBox2.Items.Add(dest + fileName);
						listBox2.Items.Add("..");
					}
					if(Directory.Exists(file))
					{
						string[] files = Directory.GetFiles(file);
						foreach(string s in files)
						{
							string file_Name = Path.GetFileName(s);
							string dest_File = Path.Combine(dest, fileName);
							File.Copy(s, dest_File, true);
						}
					}
				}
				else
				{
					string sourceFile = Path.Combine(source, fileName);
					string destFile = Path.Combine(dest, fileName);
					File.Copy(sourceFile, destFile, true);
					listBox2.Items.RemoveAt(listBox2.Items.Count - 1);
					listBox2.Items.Add(destFile);
					listBox2.Items.Add("..");
				}
			}
		}

		private void button2_Click( object sender, EventArgs e )
		{
			string file = listBox2.SelectedItem.ToString();
			string dest = textBox1.Text;
			if(file != String.Empty && dest != String.Empty)
			{
				string fileName = Path.GetFileName(file);
				string source = Path.GetDirectoryName(file);
				FileAttributes attr = File.GetAttributes(file);
				if(( attr & FileAttributes.Directory ) == FileAttributes.Directory)
				{
					if(!Directory.Exists(dest + fileName))
					{
						Directory.CreateDirectory(dest + fileName);
						listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
						listBox1.Items.Add(dest + fileName);
						listBox1.Items.Add("..");
					}
					if(Directory.Exists(file))
					{
						string[] files = Directory.GetFiles(file);
						foreach(string s in files)
						{
							string file_Name = Path.GetFileName(s);
							string dest_File = Path.Combine(dest, fileName);
							File.Copy(s, dest_File, true);
						}
					}
				}
				else
				{
					string sourceFile = Path.Combine(source, fileName);
					string destFile = Path.Combine(dest, fileName);
					File.Copy(sourceFile, destFile, true);
					listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
					listBox1.Items.Add(destFile);
					listBox1.Items.Add("..");
				}
			}
		}

		private void button4_Click( object sender, EventArgs e )
		{
			ListBox temp = null;
			if(focused == 1)
				temp = listBox1;
			else if(focused == 2)
				temp = listBox2;
			if(temp.SelectedItem.ToString() != null)
			{
				FileAttributes attr = File.GetAttributes(temp.SelectedItem.ToString());
				if(( attr & FileAttributes.Directory ) == FileAttributes.Directory)
				{
					Directory.Delete(temp.SelectedItem.ToString(), true);
				}
				else
				{
					File.Delete(temp.SelectedItem.ToString());
				}
				int index = temp.SelectedIndex;
				temp.Items.RemoveAt(index);
				temp.SelectedIndex = index;
			}
		}

		private void copy( object sender, EventArgs e )
		{
			ListBox mainl = new ListBox();
			ListBox secl = new ListBox();
			TextBox maint = new TextBox();
			TextBox sect = new TextBox();
			if(focused == 1)
			{
				mainl = listBox1;
				secl = listBox2;
				maint = textBox1;
				sect = textBox2;
			}
			else if(focused == 2)
			{
				mainl = listBox2;
				secl = listBox1;
				maint = textBox2;
				sect = textBox1;
			}
			string file = mainl.SelectedItem.ToString();
			string dest = sect.Text;
			if(file != String.Empty && dest != String.Empty)
			{
				string fileName = Path.GetFileName(file);
				string source = Path.GetDirectoryName(file);
				FileAttributes attr = File.GetAttributes(file);
				if(( attr & FileAttributes.Directory ) == FileAttributes.Directory)
				{
					if(!Directory.Exists(dest + fileName))
					{
						Directory.CreateDirectory(dest + fileName);
						secl.Items.RemoveAt(secl.Items.Count - 1);
						secl.Items.Add(dest + fileName);
						secl.Items.Add("..");
					}
					if(Directory.Exists(file))
					{
						string[] files = Directory.GetFiles(file);
						foreach(string s in files)
						{
							string file_Name = Path.GetFileName(s);
							string dest_File = Path.Combine(dest, fileName);
							File.Copy(s, dest_File, true);
						}
					}
				}
				else
				{
					string sourceFile = Path.Combine(source, fileName);
					string destFile = Path.Combine(dest, fileName);
					File.Copy(sourceFile, destFile, true);
					secl.Items.RemoveAt(secl.Items.Count - 1);
					secl.Items.Add(destFile);
					secl.Items.Add("..");
				}
			}
		}
	}
}