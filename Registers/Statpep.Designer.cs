/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-07-06
 * Time: 12:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Liquidinster
{
	partial class Statpep
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Button button3;
		
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1324, 384);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 46);
			this.button1.TabIndex = 2;
			this.button1.Text = "Excel tábla";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(1196, 311);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(160, 23);
			this.label5.TabIndex = 273;
			this.label5.Text = "Non comform registers number:";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(1362, 308);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(86, 20);
			this.textBox4.TabIndex = 272;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(1262, 334);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 23);
			this.label3.TabIndex = 269;
			this.label3.Text = "Registers QM10:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(1362, 331);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(86, 20);
			this.textBox1.TabIndex = 268;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(1255, 288);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 23);
			this.label2.TabIndex = 267;
			this.label2.Text = "Registers numbers:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1334, 222);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 266;
			this.button2.Text = "Show";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(1362, 285);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(86, 20);
			this.textBox3.TabIndex = 265;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(1277, 262);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 23);
			this.label1.TabIndex = 264;
			this.label1.Text = "Actual week:";
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(1362, 259);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(36, 20);
			this.textBox14.TabIndex = 263;
			// 
			// chart1
			// 
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart1.Legends.Add(legend2);
			this.chart1.Location = new System.Drawing.Point(9, 12);
			this.chart1.Name = "chart1";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(1445, 652);
			this.chart1.TabIndex = 274;
			this.chart1.Text = "chart1";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(689, 321);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(85, 34);
			this.button3.TabIndex = 275;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Visible = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// Statpep
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1463, 677);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox14);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.chart1);
			this.Name = "Statpep";
			this.Text = "Pepsico registers";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
