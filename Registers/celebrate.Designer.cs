/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-08-03
 * Time: 11:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Liquidinster
{
	partial class celebrate
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(celebrate));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.button9 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(500, 283);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 5000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// textBox8
			// 
			this.textBox8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox8.ForeColor = System.Drawing.Color.Transparent;
			this.textBox8.Location = new System.Drawing.Point(409, 12);
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new System.Drawing.Size(80, 13);
			this.textBox8.TabIndex = 12;
			// 
			// button9
			// 
			this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
			this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button9.Location = new System.Drawing.Point(226, 118);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(48, 48);
			this.button9.TabIndex = 13;
			this.button9.Text = "Lang";
			this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Visible = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(318, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 15);
			this.label1.TabIndex = 14;
			this.label1.Text = "Sikeres projekt!";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.ForeColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(367, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 15);
			this.label2.TabIndex = 15;
			this.label2.Text = "Köszi!";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(367, 95);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 16;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.ForeColor = System.Drawing.Color.Transparent;
			this.textBox1.Location = new System.Drawing.Point(353, 34);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(24, 13);
			this.textBox1.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.ForeColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(383, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 15);
			this.label3.TabIndex = 18;
			this.label3.Text = "regisztert javítottál";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.ForeColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(383, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 15);
			this.label4.TabIndex = 20;
			this.label4.Text = ". legtöbbet";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.ForeColor = System.Drawing.Color.Transparent;
			this.textBox2.Location = new System.Drawing.Point(367, 65);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(17, 13);
			this.textBox2.TabIndex = 19;
			// 
			// celebrate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 284);
			this.ControlBox = false;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.pictureBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "celebrate";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
