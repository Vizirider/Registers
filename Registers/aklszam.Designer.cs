/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-08-24
 * Time: 08:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Registers
{
	partial class aklszam
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox textBox7;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aklszam));
			this.button1 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(565, 202);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(65, 29);
			this.button1.TabIndex = 118;
			this.button1.Text = "Hibák";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(517, 311);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(65, 20);
			this.textBox3.TabIndex = 117;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(517, 263);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(65, 20);
			this.textBox2.TabIndex = 116;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(517, 237);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(65, 20);
			this.textBox1.TabIndex = 115;
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(535, 205);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(28, 23);
			this.label31.TabIndex = 114;
			this.label31.Text = "-ig";
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(353, 205);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(36, 23);
			this.label30.TabIndex = 113;
			this.label30.Text = "-tól";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(386, 204);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(143, 20);
			this.dateTimePicker2.TabIndex = 112;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(213, 204);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
			this.dateTimePicker1.TabIndex = 111;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(198, 451);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(528, 20);
			this.textBox7.TabIndex = 119;
			// 
			// aklszam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(816, 517);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label31);
			this.Controls.Add(this.label30);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Name = "aklszam";
			this.Text = "aklszam";
			this.Load += new System.EventHandler(this.Button1Click);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
