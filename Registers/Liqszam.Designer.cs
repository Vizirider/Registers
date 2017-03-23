/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-08-23
 * Time: 15:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Registers
{
	partial class Liqszam
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Button button1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liqszam));
			this.label31 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(545, 187);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(28, 23);
			this.label31.TabIndex = 102;
			this.label31.Text = "-ig";
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(363, 187);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(36, 23);
			this.label30.TabIndex = 101;
			this.label30.Text = "-tól";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(396, 186);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(143, 20);
			this.dateTimePicker2.TabIndex = 100;
			this.dateTimePicker2.ValueChanged += new System.EventHandler(this.Button1Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(223, 186);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
			this.dateTimePicker1.TabIndex = 99;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(575, 244);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(65, 20);
			this.textBox1.TabIndex = 103;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(575, 290);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(65, 20);
			this.textBox2.TabIndex = 104;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(575, 348);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(65, 20);
			this.textBox3.TabIndex = 105;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(575, 487);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(65, 20);
			this.textBox4.TabIndex = 106;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(575, 534);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(65, 20);
			this.textBox5.TabIndex = 107;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(575, 587);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(65, 20);
			this.textBox6.TabIndex = 108;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(263, 652);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(496, 20);
			this.textBox7.TabIndex = 109;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(575, 184);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(65, 29);
			this.button1.TabIndex = 110;
			this.button1.Text = "Hibák";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Liqszam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(806, 699);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label31);
			this.Controls.Add(this.label30);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Name = "Liqszam";
			this.Text = "Liqszam";
			this.Load += new System.EventHandler(this.Button1Click);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
