/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2017-09-11
 * Time: 02:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Registers
{
	partial class Liquidnew
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liquidnew));
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// checkBox7
			// 
			this.checkBox7.BackColor = System.Drawing.Color.White;
			this.checkBox7.Location = new System.Drawing.Point(510, 557);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(40, 31);
			this.checkBox7.TabIndex = 74;
			this.checkBox7.UseVisualStyleBackColor = false;
			// 
			// checkBox6
			// 
			this.checkBox6.BackColor = System.Drawing.Color.White;
			this.checkBox6.Location = new System.Drawing.Point(510, 505);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(40, 31);
			this.checkBox6.TabIndex = 73;
			this.checkBox6.UseVisualStyleBackColor = false;
			// 
			// checkBox5
			// 
			this.checkBox5.BackColor = System.Drawing.Color.White;
			this.checkBox5.Location = new System.Drawing.Point(510, 457);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(40, 31);
			this.checkBox5.TabIndex = 72;
			this.checkBox5.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Location = new System.Drawing.Point(682, 314);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 71;
			this.button1.Text = "Módosít";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(611, 55);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 70;
			this.button3.Text = "keres";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Visible = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button4.Location = new System.Drawing.Point(682, 240);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 57;
			this.button4.Text = "Ellenőrzés";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {
			"vizir",
			"kisst",
			"ga5",
			"szaboz1",
			"beg",
			"szombatm",
			"tkr",
			"bko",
			"ani",
			"gok"});
			this.comboBox3.Location = new System.Drawing.Point(671, 625);
			this.comboBox3.MinimumSize = new System.Drawing.Size(120, 0);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(120, 21);
			this.comboBox3.TabIndex = 69;
			// 
			// checkBox3
			// 
			this.checkBox3.BackColor = System.Drawing.Color.White;
			this.checkBox3.Location = new System.Drawing.Point(510, 404);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(40, 31);
			this.checkBox3.TabIndex = 63;
			this.checkBox3.UseVisualStyleBackColor = false;
			// 
			// checkBox2
			// 
			this.checkBox2.BackColor = System.Drawing.Color.White;
			this.checkBox2.Location = new System.Drawing.Point(510, 287);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(40, 31);
			this.checkBox2.TabIndex = 62;
			this.checkBox2.UseVisualStyleBackColor = false;
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.Color.White;
			this.checkBox1.Location = new System.Drawing.Point(510, 239);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(40, 36);
			this.checkBox1.TabIndex = 61;
			this.checkBox1.UseVisualStyleBackColor = false;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(501, 343);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(101, 20);
			this.textBox5.TabIndex = 64;
			// 
			// checkBox4
			// 
			this.checkBox4.BackColor = System.Drawing.Color.White;
			this.checkBox4.Location = new System.Drawing.Point(642, 365);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(104, 24);
			this.checkBox4.TabIndex = 68;
			this.checkBox4.UseVisualStyleBackColor = false;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(670, 587);
			this.comboBox2.MinimumSize = new System.Drawing.Size(120, 0);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(120, 21);
			this.comboBox2.TabIndex = 67;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(642, 707);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
			this.dateTimePicker1.TabIndex = 66;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(258, 652);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(499, 20);
			this.textBox3.TabIndex = 65;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(501, 132);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(231, 20);
			this.textBox2.TabIndex = 60;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(451, 104);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(149, 20);
			this.textBox1.TabIndex = 59;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(451, 76);
			this.comboBox1.MinimumSize = new System.Drawing.Size(150, 0);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(150, 21);
			this.comboBox1.TabIndex = 58;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(556, 243);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(101, 32);
			this.textBox4.TabIndex = 75;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(556, 287);
			this.textBox6.Multiline = true;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(101, 32);
			this.textBox6.TabIndex = 76;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(556, 409);
			this.textBox7.Multiline = true;
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(101, 32);
			this.textBox7.TabIndex = 77;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(556, 457);
			this.textBox8.Multiline = true;
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(101, 32);
			this.textBox8.TabIndex = 78;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(556, 504);
			this.textBox9.Multiline = true;
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(101, 32);
			this.textBox9.TabIndex = 79;
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(556, 557);
			this.textBox10.Multiline = true;
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(101, 32);
			this.textBox10.TabIndex = 80;
			// 
			// Liquidnew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(804, 739);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.checkBox7);
			this.Controls.Add(this.checkBox6);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Name = "Liquidnew";
			this.Text = "Liquidnew";
			this.Load += new System.EventHandler(this.LiquidnewLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
