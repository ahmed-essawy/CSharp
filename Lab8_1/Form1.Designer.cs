namespace Lab8_1
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
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dashedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dottedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.redToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.greenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.blueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.styleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.solidToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.dashedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.dottedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.colorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.redToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.greenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.blueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.styleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.solidToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.dashedToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.dottedToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.colorToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.redToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.greenToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.blueToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.styleToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.crossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.rectangleToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// lineToolStripMenuItem
			// 
			this.lineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.styleToolStripMenuItem});
			this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
			this.lineToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.lineToolStripMenuItem.Text = "Line";
			// 
			// colorToolStripMenuItem
			// 
			this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
			this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
			this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.colorToolStripMenuItem.Text = "Color";
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
			this.blueToolStripMenuItem.Checked = true;
			this.blueToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
			this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.blueToolStripMenuItem.Text = "Blue";
			this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
			// 
			// styleToolStripMenuItem
			// 
			this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem,
            this.dashedToolStripMenuItem,
            this.dottedToolStripMenuItem});
			this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
			this.styleToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.styleToolStripMenuItem.Text = "Style";
			// 
			// solidToolStripMenuItem
			// 
			this.solidToolStripMenuItem.Checked = true;
			this.solidToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
			this.solidToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.solidToolStripMenuItem.Text = "Solid";
			this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
			// 
			// dashedToolStripMenuItem
			// 
			this.dashedToolStripMenuItem.Name = "dashedToolStripMenuItem";
			this.dashedToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.dashedToolStripMenuItem.Text = "Dashed";
			this.dashedToolStripMenuItem.Click += new System.EventHandler(this.dashedToolStripMenuItem_Click);
			// 
			// dottedToolStripMenuItem
			// 
			this.dottedToolStripMenuItem.Name = "dottedToolStripMenuItem";
			this.dottedToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.dottedToolStripMenuItem.Text = "Dotted";
			this.dottedToolStripMenuItem.Click += new System.EventHandler(this.dottedToolStripMenuItem_Click);
			// 
			// rectangleToolStripMenuItem
			// 
			this.rectangleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem1,
            this.styleToolStripMenuItem1});
			this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
			this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.rectangleToolStripMenuItem.Text = "Rectangle";
			// 
			// colorToolStripMenuItem1
			// 
			this.colorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem1,
            this.greenToolStripMenuItem1,
            this.blueToolStripMenuItem1});
			this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
			this.colorToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.colorToolStripMenuItem1.Text = "Color";
			// 
			// redToolStripMenuItem1
			// 
			this.redToolStripMenuItem1.Checked = true;
			this.redToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.redToolStripMenuItem1.Name = "redToolStripMenuItem1";
			this.redToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
			this.redToolStripMenuItem1.Text = "Red";
			this.redToolStripMenuItem1.Click += new System.EventHandler(this.redToolStripMenuItem1_Click);
			// 
			// greenToolStripMenuItem1
			// 
			this.greenToolStripMenuItem1.Name = "greenToolStripMenuItem1";
			this.greenToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
			this.greenToolStripMenuItem1.Text = "Green";
			this.greenToolStripMenuItem1.Click += new System.EventHandler(this.greenToolStripMenuItem1_Click);
			// 
			// blueToolStripMenuItem1
			// 
			this.blueToolStripMenuItem1.Name = "blueToolStripMenuItem1";
			this.blueToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
			this.blueToolStripMenuItem1.Text = "Blue";
			this.blueToolStripMenuItem1.Click += new System.EventHandler(this.blueToolStripMenuItem1_Click);
			// 
			// styleToolStripMenuItem1
			// 
			this.styleToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem1,
            this.dashedToolStripMenuItem1,
            this.dottedToolStripMenuItem1});
			this.styleToolStripMenuItem1.Name = "styleToolStripMenuItem1";
			this.styleToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.styleToolStripMenuItem1.Text = "Style";
			// 
			// solidToolStripMenuItem1
			// 
			this.solidToolStripMenuItem1.Checked = true;
			this.solidToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.solidToolStripMenuItem1.Name = "solidToolStripMenuItem1";
			this.solidToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.solidToolStripMenuItem1.Text = "Right";
			this.solidToolStripMenuItem1.Click += new System.EventHandler(this.solidToolStripMenuItem1_Click);
			// 
			// dashedToolStripMenuItem1
			// 
			this.dashedToolStripMenuItem1.Name = "dashedToolStripMenuItem1";
			this.dashedToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.dashedToolStripMenuItem1.Text = "Left";
			this.dashedToolStripMenuItem1.Click += new System.EventHandler(this.dashedToolStripMenuItem1_Click);
			// 
			// dottedToolStripMenuItem1
			// 
			this.dottedToolStripMenuItem1.Name = "dottedToolStripMenuItem1";
			this.dottedToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.dottedToolStripMenuItem1.Text = "Cross";
			this.dottedToolStripMenuItem1.Click += new System.EventHandler(this.dottedToolStripMenuItem1_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem2,
            this.styleToolStripMenuItem2});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
			// 
			// colorToolStripMenuItem2
			// 
			this.colorToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem2,
            this.greenToolStripMenuItem2,
            this.blueToolStripMenuItem2});
			this.colorToolStripMenuItem2.Name = "colorToolStripMenuItem2";
			this.colorToolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
			this.colorToolStripMenuItem2.Text = "Color";
			// 
			// redToolStripMenuItem2
			// 
			this.redToolStripMenuItem2.Name = "redToolStripMenuItem2";
			this.redToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			this.redToolStripMenuItem2.Text = "Red";
			this.redToolStripMenuItem2.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
			// 
			// greenToolStripMenuItem2
			// 
			this.greenToolStripMenuItem2.Name = "greenToolStripMenuItem2";
			this.greenToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			this.greenToolStripMenuItem2.Text = "Green";
			this.greenToolStripMenuItem2.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
			// 
			// blueToolStripMenuItem2
			// 
			this.blueToolStripMenuItem2.Checked = true;
			this.blueToolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.blueToolStripMenuItem2.Name = "blueToolStripMenuItem2";
			this.blueToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			this.blueToolStripMenuItem2.Text = "Blue";
			this.blueToolStripMenuItem2.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
			// 
			// styleToolStripMenuItem2
			// 
			this.styleToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem2,
            this.dashedToolStripMenuItem2,
            this.dottedToolStripMenuItem2});
			this.styleToolStripMenuItem2.Name = "styleToolStripMenuItem2";
			this.styleToolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
			this.styleToolStripMenuItem2.Text = "Style";
			// 
			// solidToolStripMenuItem2
			// 
			this.solidToolStripMenuItem2.Checked = true;
			this.solidToolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.solidToolStripMenuItem2.Name = "solidToolStripMenuItem2";
			this.solidToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			this.solidToolStripMenuItem2.Text = "Solid";
			this.solidToolStripMenuItem2.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
			// 
			// dashedToolStripMenuItem2
			// 
			this.dashedToolStripMenuItem2.Name = "dashedToolStripMenuItem2";
			this.dashedToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			this.dashedToolStripMenuItem2.Text = "Dashed";
			this.dashedToolStripMenuItem2.Click += new System.EventHandler(this.dashedToolStripMenuItem_Click);
			// 
			// dottedToolStripMenuItem2
			// 
			this.dottedToolStripMenuItem2.Name = "dottedToolStripMenuItem2";
			this.dottedToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			this.dottedToolStripMenuItem2.Text = "Dotted";
			this.dottedToolStripMenuItem2.Click += new System.EventHandler(this.dottedToolStripMenuItem_Click);
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem3,
            this.styleToolStripMenuItem3});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(153, 70);
			// 
			// colorToolStripMenuItem3
			// 
			this.colorToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem3,
            this.greenToolStripMenuItem3,
            this.blueToolStripMenuItem3});
			this.colorToolStripMenuItem3.Name = "colorToolStripMenuItem3";
			this.colorToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
			this.colorToolStripMenuItem3.Text = "Color";
			// 
			// redToolStripMenuItem3
			// 
			this.redToolStripMenuItem3.Name = "redToolStripMenuItem3";
			this.redToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
			this.redToolStripMenuItem3.Text = "Red";
			this.redToolStripMenuItem3.Click += new System.EventHandler(this.redToolStripMenuItem1_Click);
			// 
			// greenToolStripMenuItem3
			// 
			this.greenToolStripMenuItem3.Name = "greenToolStripMenuItem3";
			this.greenToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
			this.greenToolStripMenuItem3.Text = "Green";
			this.greenToolStripMenuItem3.Click += new System.EventHandler(this.greenToolStripMenuItem1_Click);
			// 
			// blueToolStripMenuItem3
			// 
			this.blueToolStripMenuItem3.Checked = true;
			this.blueToolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.blueToolStripMenuItem3.Name = "blueToolStripMenuItem3";
			this.blueToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
			this.blueToolStripMenuItem3.Text = "Blue";
			this.blueToolStripMenuItem3.Click += new System.EventHandler(this.blueToolStripMenuItem1_Click);
			// 
			// styleToolStripMenuItem3
			// 
			this.styleToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightToolStripMenuItem,
            this.leftToolStripMenuItem,
            this.crossToolStripMenuItem});
			this.styleToolStripMenuItem3.Name = "styleToolStripMenuItem3";
			this.styleToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
			this.styleToolStripMenuItem3.Text = "Style";
			// 
			// rightToolStripMenuItem
			// 
			this.rightToolStripMenuItem.Checked = true;
			this.rightToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
			this.rightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.rightToolStripMenuItem.Text = "Right";
			this.rightToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem1_Click);
			// 
			// leftToolStripMenuItem
			// 
			this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
			this.leftToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.leftToolStripMenuItem.Text = "Left";
			this.leftToolStripMenuItem.Click += new System.EventHandler(this.dashedToolStripMenuItem1_Click);
			// 
			// crossToolStripMenuItem
			// 
			this.crossToolStripMenuItem.Name = "crossToolStripMenuItem";
			this.crossToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.crossToolStripMenuItem.Text = "Cross";
			this.crossToolStripMenuItem.Click += new System.EventHandler(this.dottedToolStripMenuItem1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dashedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dottedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem dashedToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem dottedToolStripMenuItem1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem dashedToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem dottedToolStripMenuItem2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem crossToolStripMenuItem;
	}
}

