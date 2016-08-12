/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-17
 * Time: 10:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Liquidinster
{
	partial class Nemfelvittarchiv1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.TextBox textBox1;
		
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
			this.label7 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(214, 23);
			this.label7.TabIndex = 48;
			this.label7.Text = "Handover archív";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(209, 20);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(160, 23);
			this.button2.TabIndex = 47;
			this.button2.Text = "button";
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(0, 35);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(963, 644);
			this.dataGridView2.TabIndex = 46;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(103, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 49;
			this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox1KeyUp);
			// 
			// Nemfelvittarchiv1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(975, 680);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.dataGridView2);
			this.Name = "Nemfelvittarchiv1";
			this.Text = "Nemfelvittarchiv1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
