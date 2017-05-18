/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-17
 * Time: 16:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Liquidinster
{
	partial class Select2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button8;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select2));
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(288, 294);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 33);
			this.label2.TabIndex = 15;
			this.label2.Text = "Developer: Robert Vizi robert.vizi@givaudan.com";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(107, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 23);
			this.label1.TabIndex = 16;
			this.label1.Text = "Üdv, ";
			// 
			// textBox8
			// 
			this.textBox8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.textBox8.Location = new System.Drawing.Point(145, 18);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(80, 20);
			this.textBox8.TabIndex = 17;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Swis721 BlkEx BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button3.ForeColor = System.Drawing.Color.Navy;
			this.button3.Location = new System.Drawing.Point(64, 101);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(235, 55);
			this.button3.TabIndex = 13;
			this.button3.Text = "PEPSICO";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button8
			// 
			this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
			this.button8.Location = new System.Drawing.Point(141, 192);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(84, 71);
			this.button8.TabIndex = 18;
			this.button8.Text = "Stat";
			this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(299, 18);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 19;
			this.button5.Text = "Login";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// Select2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(386, 326);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.button3);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(402, 364);
			this.MinimumSize = new System.Drawing.Size(402, 364);
			this.Name = "Select2";
			this.Text = "Planner register";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
