namespace Lab7_3_Bonus
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.penToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(0, 22);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(600, 600);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
			this.statusStrip1.Location = new System.Drawing.Point(0, 622);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(600, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(25, 17);
			this.toolStripStatusLabel1.Text = "0, 0";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(25, 17);
			this.toolStripStatusLabel2.Text = "0, 0";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel3.Text = "Shape";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shapeToolStripMenuItem,
            this.penToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(600, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// shapeToolStripMenuItem
			// 
			this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.triangleToolStripMenuItem,
            this.lineToolStripMenuItem});
			this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
			this.shapeToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.shapeToolStripMenuItem.Text = "&Shape";
			// 
			// rectangleToolStripMenuItem
			// 
			this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
			this.rectangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.rectangleToolStripMenuItem.Text = "Rectangle";
			this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
			// 
			// ellipseToolStripMenuItem
			// 
			this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
			this.ellipseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.ellipseToolStripMenuItem.Text = "Ellipse";
			this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
			// 
			// triangleToolStripMenuItem
			// 
			this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
			this.triangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.triangleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.triangleToolStripMenuItem.Text = "Triangle";
			this.triangleToolStripMenuItem.Click += new System.EventHandler(this.triangleToolStripMenuItem_Click);
			// 
			// lineToolStripMenuItem
			// 
			this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
			this.lineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.lineToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.lineToolStripMenuItem.Text = "Line";
			this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
			// 
			// penToolStripMenuItem
			// 
			this.penToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.sizeToolStripMenuItem});
			this.penToolStripMenuItem.Name = "penToolStripMenuItem";
			this.penToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.penToolStripMenuItem.Text = "Pen";
			// 
			// colorToolStripMenuItem
			// 
			this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
			this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
			this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.colorToolStripMenuItem.Text = "Color";
			// 
			// blackToolStripMenuItem
			// 
			this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
			this.blackToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.blackToolStripMenuItem.Text = "Black";
			this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
			// 
			// redToolStripMenuItem
			// 
			this.redToolStripMenuItem.Name = "redToolStripMenuItem";
			this.redToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.redToolStripMenuItem.Text = "Red";
			this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
			// 
			// greenToolStripMenuItem
			// 
			this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
			this.greenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.greenToolStripMenuItem.Text = "Green";
			this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
			// 
			// blueToolStripMenuItem
			// 
			this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
			this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.blueToolStripMenuItem.Text = "Blue";
			this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
			// 
			// sizeToolStripMenuItem
			// 
			this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
			this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
			this.sizeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.sizeToolStripMenuItem.Text = "Size";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
			this.toolStripMenuItem2.Text = "1";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
			this.toolStripMenuItem3.Text = "2";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
			this.toolStripMenuItem4.Text = "3";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
			this.toolStripMenuItem5.Text = "4";
			this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(80, 22);
			this.toolStripMenuItem6.Text = "5";
			this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(80, 22);
			this.toolStripMenuItem7.Text = "6";
			this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(80, 22);
			this.toolStripMenuItem8.Text = "7";
			this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 644);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.panel1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shapeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem penToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
	}
}

