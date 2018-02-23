/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-17
 * Time: 11:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Liquidinster
{
	/// <summary>
	/// Description of Select1.
	/// </summary>
	public partial class Select1 : Form
	{
		public Select1(string mws)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.textBox8.Text = mws;
		}
		void Button30Click(object sender, EventArgs e)
		{
		
		}
		void Button3Click(object sender, EventArgs e)
		{
			MainForm2 mf2 = new MainForm2(this.textBox8.Text);
			mf2.Show();
		}
		void Button1Click(object sender, EventArgs e)
		{
			MainForm4 mf4 = new MainForm4(this.textBox8.Text);
			mf4.Show();
		}
		void Button8Click(object sender, EventArgs e)
		{
			Statwh sw = new Statwh();
			sw.Show();
		}
		void Button5Click(object sender, EventArgs e)
		{
			LogReg f2 = new LogReg();
			f2.Show();	
		}
		void Label2MouseHover(object sender, EventArgs e)
		{
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.label2, "Version 1.0 \nCreated and Developed by Robert Vizi - robert.vizi@givaudan.com");		
		}
		void Button12Click(object sender, EventArgs e)
		{
		MessageBox.Show("Version 1.0 with User Guide\nCreated and Developed by Robert Vizi - robert.vizi@givaudan.com", "Message");
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = @"\\gmacsm0001\dept\Production\14 REGISTER\01 Documents\Warehouse PepsiCo digitális regiszterek.docx";
			proc.StartInfo.WorkingDirectory = @"V:\ROC\";
			proc.Start();		
		}
	}
}
