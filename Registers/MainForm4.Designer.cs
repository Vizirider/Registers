/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-05-17
 * Time: 11:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Liquidinster
{
	partial class MainForm4
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox4;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm4));
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button7 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(341, 283);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(44, 20);
			this.textBox2.TabIndex = 231;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(22, 241);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 23);
			this.label4.TabIndex = 230;
			this.label4.Text = "REG Read";
			// 
			// button2
			// 
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Location = new System.Drawing.Point(153, 222);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(62, 50);
			this.button2.TabIndex = 229;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(22, 175);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 23);
			this.label3.TabIndex = 228;
			this.label3.Text = "REG Add";
			// 
			// button3
			// 
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.Location = new System.Drawing.Point(153, 154);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(62, 55);
			this.button3.TabIndex = 227;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(330, 284);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(44, 23);
			this.button1.TabIndex = 226;
			this.button1.Text = "Show";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(316, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(155, 24);
			this.label2.TabIndex = 225;
			this.label2.Text = "REG-Warehouse";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(234, 94);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(265, 183);
			this.dataGridView1.TabIndex = 224;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellDoubleClick);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(153, 125);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(62, 23);
			this.button7.TabIndex = 223;
			this.button7.Text = "Keres";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(32, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 20);
			this.label1.TabIndex = 222;
			this.label1.Text = "SOnumber";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(115, 94);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 221;
			// 
			// textBox8
			// 
			this.textBox8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.textBox8.Location = new System.Drawing.Point(419, 12);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(80, 20);
			this.textBox8.TabIndex = 233;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(227, 12);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(61, 20);
			this.textBox4.TabIndex = 232;
			// 
			// MainForm4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 323);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm4";
			this.Text = "PepsiCo Check";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
