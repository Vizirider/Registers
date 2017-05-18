/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-10-21
 * Time: 10:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Registers
{
	partial class Regtime
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBox1;
		
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
			this.button19 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button19
			// 
			this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button19.Location = new System.Drawing.Point(908, 34);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(85, 23);
			this.button19.TabIndex = 42;
			this.button19.Text = "All Register";
			this.button19.UseVisualStyleBackColor = true;
			this.button19.Click += new System.EventHandler(this.Button19Click);
			// 
			// button15
			// 
			this.button15.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.button15.Location = new System.Drawing.Point(1580, 37);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(75, 23);
			this.button15.TabIndex = 41;
			this.button15.Text = "All";
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += new System.EventHandler(this.Button15Click);
			// 
			// button16
			// 
			this.button16.BackColor = System.Drawing.Color.Yellow;
			this.button16.Location = new System.Drawing.Point(1483, 37);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(75, 23);
			this.button16.TabIndex = 39;
			this.button16.Text = "1 hour";
			this.button16.UseVisualStyleBackColor = false;
			this.button16.Click += new System.EventHandler(this.Button16Click);
			// 
			// button17
			// 
			this.button17.BackColor = System.Drawing.Color.Orange;
			this.button17.Location = new System.Drawing.Point(1381, 37);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(75, 23);
			this.button17.TabIndex = 38;
			this.button17.Text = "2 hours";
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += new System.EventHandler(this.Button17Click);
			// 
			// button18
			// 
			this.button18.BackColor = System.Drawing.Color.Red;
			this.button18.Location = new System.Drawing.Point(1278, 37);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(75, 23);
			this.button18.TabIndex = 37;
			this.button18.Text = "4 hours";
			this.button18.UseVisualStyleBackColor = false;
			this.button18.Click += new System.EventHandler(this.Button18Click);
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(706, 37);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(75, 23);
			this.button14.TabIndex = 36;
			this.button14.Text = "sd";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.Button14Click);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(805, 37);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(75, 23);
			this.button13.TabIndex = 35;
			this.button13.Text = "pf";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.Button13Click);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(303, 37);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(75, 23);
			this.button12.TabIndex = 34;
			this.button12.Text = "bmp";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.Button12Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(607, 37);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(75, 23);
			this.button9.TabIndex = 33;
			this.button9.Text = "pack off";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(503, 37);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(75, 23);
			this.button10.TabIndex = 32;
			this.button10.Text = "small blend";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(402, 37);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(75, 23);
			this.button11.TabIndex = 31;
			this.button11.Text = "big blend";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.Button11Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(11, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(178, 23);
			this.label3.TabIndex = 30;
			this.label3.Text = "Register log - Register type compare";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 97);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1664, 915);
			this.dataGridView1.TabIndex = 29;
			this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1CellFormatting);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Location = new System.Drawing.Point(1, 26);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1664, 40);
			this.panel2.TabIndex = 43;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(203, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 49;
			this.button1.Text = "liq";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(764, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
			this.dateTimePicker1.TabIndex = 44;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(1579, 71);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(86, 20);
			this.textBox2.TabIndex = 45;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(1008, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(248, 19);
			this.label4.TabIndex = 40;
			this.label4.Text = "Difference between Real and Register timestamp";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(996, 0);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(152, 20);
			this.dateTimePicker2.TabIndex = 46;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(719, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 23);
			this.label1.TabIndex = 47;
			this.label1.Text = "from:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(951, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 23);
			this.label2.TabIndex = 48;
			this.label2.Text = "to:";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.Location = new System.Drawing.Point(104, 1);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(85, 23);
			this.button2.TabIndex = 49;
			this.button2.Text = "Export";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Morning",
			"Afternoon",
			"Night",
			"All"});
			this.comboBox1.Location = new System.Drawing.Point(1202, 0);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 210;
			this.comboBox1.Text = "All";
			// 
			// Regtime
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1664, 1012);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button19);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel2);
			this.Name = "Regtime";
			this.Text = "Regtime";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
