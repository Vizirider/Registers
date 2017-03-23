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
			label2.Font = new Font(label2.Font.FontFamily, 5);
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
	}
}
