namespace WindowsFormsApp1
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
            this.custom_Chart1 = new Custom_Chart.Custom_Chart();
            this.SuspendLayout();
            // 
            // custom_Chart1
            // 
            this.custom_Chart1.Location = new System.Drawing.Point(0, 0);
            this.custom_Chart1.Margin = new System.Windows.Forms.Padding(0);
            this.custom_Chart1.Name = "custom_Chart1";
            this.custom_Chart1.Size = new System.Drawing.Size(300, 300);
            this.custom_Chart1.TabIndex = 0;
            this.custom_Chart1.View = Custom_Chart.view_type.Line;
            this.custom_Chart1.X_Axis = "X-Axis";
            this.custom_Chart1.Y_Axis = "Y-Axis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.custom_Chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Chart.Custom_Chart custom_Chart1;
    }
}

