/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-05-09
 * Time: 10:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Liquidinster
{
	partial class Stat
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
		private System.Windows.Forms.Button button5;
		
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button4 = new System.Windows.Forms.Button();
			this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1339, 509);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 40);
			this.button1.TabIndex = 1;
			this.button1.Text = "Excel tábla";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(1371, 323);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(36, 20);
			this.textBox14.TabIndex = 251;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(1292, 323);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 23);
			this.label1.TabIndex = 253;
			this.label1.Text = "Actual week:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1339, 269);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 255;
			this.button2.Text = "Show";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(1371, 352);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(86, 20);
			this.textBox3.TabIndex = 254;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(1267, 355);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 23);
			this.label2.TabIndex = 256;
			this.label2.Text = "Registers number:";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(1233, 378);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 23);
			this.label3.TabIndex = 258;
			this.label3.Text = "Missing registers number:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(1371, 375);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(86, 20);
			this.textBox1.TabIndex = 257;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(1371, 470);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(43, 20);
			this.textBox2.TabIndex = 259;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(1312, 470);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 23);
			this.label4.TabIndex = 260;
			this.label4.Text = "Target:";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(1210, 401);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(155, 23);
			this.label5.TabIndex = 262;
			this.label5.Text = "Non comfort registers number:";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(1371, 398);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(86, 20);
			this.textBox4.TabIndex = 261;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(200, 174);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(85, 34);
			this.button3.TabIndex = 264;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Visible = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(12, 1);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(1445, 652);
			this.chart1.TabIndex = 263;
			this.chart1.Text = "chart1";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(1195, 447);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(170, 23);
			this.label6.TabIndex = 268;
			this.label6.Text = "Pepsico wrong registers number:";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(1371, 444);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(86, 20);
			this.textBox5.TabIndex = 267;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(1202, 424);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(163, 23);
			this.label7.TabIndex = 266;
			this.label7.Text = "Pepsico good registers number:";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(1371, 421);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(86, 20);
			this.textBox6.TabIndex = 265;
			// 
			// chart2
			// 
			chartArea2.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart2.Legends.Add(legend2);
			this.chart2.Location = new System.Drawing.Point(12, 659);
			this.chart2.Name = "chart2";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chart2.Series.Add(series2);
			this.chart2.Size = new System.Drawing.Size(1445, 652);
			this.chart2.TabIndex = 269;
			this.chart2.Text = "chart2";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(681, 486);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(85, 34);
			this.button4.TabIndex = 270;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Visible = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// chart3
			// 
			chartArea3.Name = "ChartArea1";
			this.chart3.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.chart3.Legends.Add(legend3);
			this.chart3.Location = new System.Drawing.Point(0, 1308);
			this.chart3.Name = "chart3";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "Series1";
			this.chart3.Series.Add(series3);
			this.chart3.Size = new System.Drawing.Size(1445, 652);
			this.chart3.TabIndex = 271;
			this.chart3.Text = "chart3";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(681, 657);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(85, 34);
			this.button5.TabIndex = 272;
			this.button5.Text = "button5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Visible = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// Stat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1463, 675);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.chart3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox14);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.chart1);
			this.Name = "Stat";
			this.Text = "Production registers";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
