/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-07-06
 * Time: 12:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Liquidinster
{
	/// <summary>
	/// Description of Statpep.
	/// </summary>
	public partial class Statpep : Form
	{
		public Statpep()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = @"V:\Production\14 REGISTER\regiszter.xlsx";
			proc.StartInfo.WorkingDirectory = @"V:\Production\14 REGISTER";
			proc.Start();
	        MessageBox.Show("Regiszterek riport!");		
		}
	}
}
