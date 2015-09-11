/*
 * Created by SharpDevelop.
 * User: Lockgo
 * Date: 4/16/2014
 * Time: 9:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sqlReaderTest
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.connectionTextBox = new System.Windows.Forms.TextBox();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.dataTextBox1 = new System.Windows.Forms.TextBox();
            this.dataTextBox2 = new System.Windows.Forms.TextBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DirectorytextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Execute Query";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1160, 268);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // connectionTextBox
            // 
            this.connectionTextBox.Location = new System.Drawing.Point(12, 286);
            this.connectionTextBox.Name = "connectionTextBox";
            this.connectionTextBox.Size = new System.Drawing.Size(849, 20);
            this.connectionTextBox.TabIndex = 4;
            // 
            // queryTextBox
            // 
            this.queryTextBox.Location = new System.Drawing.Point(12, 312);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(849, 20);
            this.queryTextBox.TabIndex = 5;
            // 
            // dataTextBox1
            // 
            this.dataTextBox1.Location = new System.Drawing.Point(320, 338);
            this.dataTextBox1.Name = "dataTextBox1";
            this.dataTextBox1.Size = new System.Drawing.Size(233, 20);
            this.dataTextBox1.TabIndex = 6;
            // 
            // dataTextBox2
            // 
            this.dataTextBox2.Location = new System.Drawing.Point(628, 338);
            this.dataTextBox2.Name = "dataTextBox2";
            this.dataTextBox2.Size = new System.Drawing.Size(233, 20);
            this.dataTextBox2.TabIndex = 7;
            // 
            // idTextBox1
            // 
            this.idTextBox1.Location = new System.Drawing.Point(12, 338);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(233, 20);
            this.idTextBox1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(628, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "LogFileTest";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1046, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "SecondaryLogFile";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DirectorytextBox1
            // 
            this.DirectorytextBox1.Location = new System.Drawing.Point(1046, 338);
            this.DirectorytextBox1.Name = "DirectorytextBox1";
            this.DirectorytextBox1.Size = new System.Drawing.Size(126, 20);
            this.DirectorytextBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1043, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Directory For Log Files";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DirectorytextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(this.dataTextBox2);
            this.Controls.Add(this.dataTextBox1);
            this.Controls.Add(this.queryTextBox);
            this.Controls.Add(this.connectionTextBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "sqlReaderTest";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox idTextBox1;
		private System.Windows.Forms.TextBox dataTextBox2;
		private System.Windows.Forms.TextBox dataTextBox1;
		private System.Windows.Forms.TextBox queryTextBox;
		private System.Windows.Forms.TextBox connectionTextBox;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox DirectorytextBox1;
        private System.Windows.Forms.Label label1;
	}
}
