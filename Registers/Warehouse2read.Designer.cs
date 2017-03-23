/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-04-08
 * Time: 15:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Liquidinster
{
	partial class Warehouse2read
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button7;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox14;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBox3;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse2read));
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button7 = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox14 = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(421, 530);
			this.comboBox2.MinimumSize = new System.Drawing.Size(150, 0);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(150, 21);
			this.comboBox2.TabIndex = 87;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(100, 531);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
			this.dateTimePicker1.TabIndex = 86;
			// 
			// checkBox2
			// 
			this.checkBox2.BackColor = System.Drawing.Color.White;
			this.checkBox2.Location = new System.Drawing.Point(482, 439);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(25, 17);
			this.checkBox2.TabIndex = 85;
			this.checkBox2.UseVisualStyleBackColor = false;
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.Color.White;
			this.checkBox1.Location = new System.Drawing.Point(482, 398);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(15, 17);
			this.checkBox1.TabIndex = 84;
			this.checkBox1.UseVisualStyleBackColor = false;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(467, 327);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(83, 20);
			this.textBox4.TabIndex = 83;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(467, 265);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(83, 20);
			this.textBox3.TabIndex = 82;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(166, 146);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(394, 20);
			this.textBox2.TabIndex = 81;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(121, 172);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(439, 55);
			this.textBox1.TabIndex = 80;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(165, 115);
			this.comboBox1.MinimumSize = new System.Drawing.Size(150, 0);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(236, 21);
			this.comboBox1.TabIndex = 79;
			// 
			// button7
			// 
			this.button7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.button7.Location = new System.Drawing.Point(251, 474);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(90, 24);
			this.button7.TabIndex = 89;
			this.button7.Text = "Nyomtatás";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1PrintPage);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(121, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 90;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// checkBox14
			// 
			this.checkBox14.Location = new System.Drawing.Point(467, 583);
			this.checkBox14.Name = "checkBox14";
			this.checkBox14.Size = new System.Drawing.Size(104, 24);
			this.checkBox14.TabIndex = 91;
			this.checkBox14.Text = "Módosítva";
			this.checkBox14.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
			this.button2.Location = new System.Drawing.Point(251, 583);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 24);
			this.button2.TabIndex = 92;
			this.button2.Text = "Módosítás";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(421, 500);
			this.comboBox3.MinimumSize = new System.Drawing.Size(150, 0);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(150, 21);
			this.comboBox3.TabIndex = 93;
			// 
			// Warehouse2read
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(573, 619);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.checkBox14);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Name = "Warehouse2read";
			this.Text = "Warehouse2read";
			this.Load += new System.EventHandler(this.Form_load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
