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
		private System.Windows.Forms.PictureBox pictureBox1;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stat));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1449, 642);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(703, 134);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 71);
			this.button1.TabIndex = 1;
			this.button1.Text = "Excel tábla";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(635, 82);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(36, 20);
			this.textBox14.TabIndex = 251;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(550, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 23);
			this.label1.TabIndex = 253;
			this.label1.Text = "Az aktuális hét:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(714, 53);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 255;
			this.button2.Text = "Mutasd";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(736, 82);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(86, 20);
			this.textBox3.TabIndex = 254;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(677, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 23);
			this.label2.TabIndex = 256;
			this.label2.Text = "Feltöltött:";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(677, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 23);
			this.label3.TabIndex = 258;
			this.label3.Text = "Hiányzó:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(736, 105);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(86, 20);
			this.textBox1.TabIndex = 257;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(867, 88);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(43, 20);
			this.textBox2.TabIndex = 259;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(828, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 23);
			this.label4.TabIndex = 260;
			this.label4.Text = "Cél:";
			// 
			// Stat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1463, 677);
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
			this.Controls.Add(this.pictureBox1);
			this.Name = "Stat";
			this.Text = "Stat";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
