/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-07
 * Time: 14:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Liquidinster
{
	partial class Blender
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
		
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
			this.button2 = new System.Windows.Forms.Button();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(159, 66);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(103, 45);
			this.button1.TabIndex = 0;
			this.button1.Text = "Kiskeverők transzponált";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(159, 131);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(103, 45);
			this.button2.TabIndex = 1;
			this.button2.Text = "Nagykeverők transzponált";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox11
			// 
			this.textBox11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.textBox11.Location = new System.Drawing.Point(222, 3);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(50, 20);
			this.textBox11.TabIndex = 145;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(119, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(47, 20);
			this.textBox1.TabIndex = 146;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(22, 131);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(103, 45);
			this.button3.TabIndex = 148;
			this.button3.Text = "Nagykeverők";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(22, 66);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(103, 45);
			this.button4.TabIndex = 147;
			this.button4.Text = "Kiskeverők";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.DarkRed;
			this.label1.Location = new System.Drawing.Point(22, 212);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 23);
			this.label1.TabIndex = 149;
			this.label1.Text = "A blending timesheet adatgyűjtés szünetel";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Blender
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBox11);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Blender";
			this.Text = "Blender";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
