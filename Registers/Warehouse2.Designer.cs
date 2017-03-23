/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-04-08
 * Time: 15:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Liquidinster
{
	partial class Warehouse2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse2));
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(166, 145);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(394, 20);
			this.textBox2.TabIndex = 47;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(121, 171);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(439, 55);
			this.textBox1.TabIndex = 46;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(165, 114);
			this.comboBox1.MinimumSize = new System.Drawing.Size(150, 0);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(236, 21);
			this.comboBox1.TabIndex = 45;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(467, 264);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(83, 20);
			this.textBox3.TabIndex = 48;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(467, 326);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(83, 20);
			this.textBox4.TabIndex = 49;
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.Color.White;
			this.checkBox1.Location = new System.Drawing.Point(482, 398);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(25, 17);
			this.checkBox1.TabIndex = 75;
			this.checkBox1.UseVisualStyleBackColor = false;
			// 
			// checkBox2
			// 
			this.checkBox2.BackColor = System.Drawing.Color.White;
			this.checkBox2.Location = new System.Drawing.Point(482, 439);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(25, 17);
			this.checkBox2.TabIndex = 76;
			this.checkBox2.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.Location = new System.Drawing.Point(272, 479);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 79;
			this.button2.Text = "Hozzáad";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(421, 529);
			this.comboBox2.MinimumSize = new System.Drawing.Size(150, 0);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(150, 21);
			this.comboBox2.TabIndex = 78;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(99, 530);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
			this.dateTimePicker1.TabIndex = 77;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(421, 499);
			this.comboBox3.MinimumSize = new System.Drawing.Size(150, 0);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(150, 21);
			this.comboBox3.TabIndex = 80;
			// 
			// Warehouse2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(583, 572);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Name = "Warehouse2";
			this.Text = "Warehouse2";
			this.Load += new System.EventHandler(this.Form_load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
