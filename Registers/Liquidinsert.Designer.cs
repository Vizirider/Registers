/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-01-29
 * Time: 12:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Liquidinster
{
	partial class Liquidinsert
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox7;
		
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(155, 21);
			this.comboBox1.MinimumSize = new System.Drawing.Size(150, 0);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(150, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Button1Click);
			this.comboBox1.Click += new System.EventHandler(this.Button1Click);
			this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Combobox1KeyUp);
			this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox1KeyPress);
			this.comboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Combobox1KeyUp);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(49, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "POszam";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(49, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Group code";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(156, 49);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(149, 20);
			this.textBox1.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 513);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(384, 69);
			this.dataGridView1.TabIndex = 14;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(321, 21);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "cooispi";
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 487);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "cooispi";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(155, 75);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(149, 20);
			this.textBox2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(48, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Material name";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(155, 217);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(241, 20);
			this.textBox3.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(48, 217);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 13;
			this.label5.Text = "Komment";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(155, 244);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(50, 375);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "Ellenőrző";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(156, 375);
			this.comboBox2.MinimumSize = new System.Drawing.Size(150, 0);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(150, 21);
			this.comboBox2.TabIndex = 10;
			// 
			// checkBox4
			// 
			this.checkBox4.Location = new System.Drawing.Point(156, 396);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(104, 24);
			this.checkBox4.TabIndex = 11;
			this.checkBox4.Text = "Ellenőrizve";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.Location = new System.Drawing.Point(185, 473);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "Hozzáad";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(157, 191);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(149, 20);
			this.textBox5.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(48, 191);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 22;
			this.label8.Text = "Kannaszám";
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(157, 161);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(104, 24);
			this.checkBox3.TabIndex = 6;
			this.checkBox3.Text = "Felcímkézve";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(157, 131);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(104, 24);
			this.checkBox2.TabIndex = 5;
			this.checkBox2.Text = "Felrázva";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(157, 101);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 24);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Kimérve";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(51, 429);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 28;
			this.label9.Text = "Admin";
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
			this.comboBox3.Location = new System.Drawing.Point(157, 429);
			this.comboBox3.MinimumSize = new System.Drawing.Size(150, 0);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(150, 21);
			this.comboBox3.TabIndex = 12;
			// 
			// checkBox5
			// 
			this.checkBox5.Location = new System.Drawing.Point(154, 332);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(104, 24);
			this.checkBox5.TabIndex = 31;
			this.checkBox5.Text = "Megfelelőhőe";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// checkBox6
			// 
			this.checkBox6.Location = new System.Drawing.Point(154, 302);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.checkBox6.Size = new System.Drawing.Size(104, 24);
			this.checkBox6.TabIndex = 30;
			this.checkBox6.Text = "Idegene";
			this.checkBox6.UseVisualStyleBackColor = true;
			// 
			// checkBox7
			// 
			this.checkBox7.Location = new System.Drawing.Point(154, 272);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(104, 24);
			this.checkBox7.TabIndex = 29;
			this.checkBox7.Text = "Uledeke";
			this.checkBox7.UseVisualStyleBackColor = true;
			// 
			// Liquidinsert
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(413, 594);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.checkBox6);
			this.Controls.Add(this.checkBox7);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Name = "Liquidinsert";
			this.Text = "Liquidinsert";
			this.Load += new System.EventHandler(this.LiquidinsertLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
