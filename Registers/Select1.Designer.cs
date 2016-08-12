/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-17
 * Time: 11:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Liquidinster
{
	partial class Select1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button8;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select1));
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(309, 314);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 33);
			this.label2.TabIndex = 10;
			this.label2.Text = "Developer: Vizi Róbert robert.vizi@givaudan.com";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(123, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 23);
			this.label1.TabIndex = 11;
			this.label1.Text = "Hello, ";
			// 
			// textBox8
			// 
			this.textBox8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.textBox8.Location = new System.Drawing.Point(161, 36);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(80, 20);
			this.textBox8.TabIndex = 12;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Swis721 BlkEx BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button3.ForeColor = System.Drawing.Color.Navy;
			this.button3.Location = new System.Drawing.Point(80, 82);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(235, 55);
			this.button3.TabIndex = 8;
			this.button3.Text = "PEPSICO";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Swis721 BlkEx BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.ForeColor = System.Drawing.Color.Navy;
			this.button1.Location = new System.Drawing.Point(80, 163);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(235, 55);
			this.button1.TabIndex = 13;
			this.button1.Text = "PEPSICO";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.Navy;
			this.label3.Location = new System.Drawing.Point(27, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 17);
			this.label3.TabIndex = 14;
			this.label3.Text = "Mako";
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.Navy;
			this.label4.Location = new System.Drawing.Point(27, 184);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 17);
			this.label4.TabIndex = 15;
			this.label4.Text = "Other";
			// 
			// button8
			// 
			this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
			this.button8.Location = new System.Drawing.Point(157, 250);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(84, 71);
			this.button8.TabIndex = 16;
			this.button8.Text = "Stat";
			this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// Select1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 344);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.button3);
			this.Name = "Select1";
			this.Text = "Warehouse Registers";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
