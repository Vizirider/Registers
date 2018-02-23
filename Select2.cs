/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-17
 * Time: 16:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace Liquidinster
{
	/// <summary>
	/// Description of Select2.
	/// </summary>
	public partial class Select2 : Form
	{
		public Select2(string mws)
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
		void Button3Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			MainForm3 mf3 = new MainForm3(this.textBox8.Text);
			mf3.Show();
			
			SqlCommand cmd = new SqlCommand(@"insert into Planner (POszam, Datum)
    		select *
    		from Plannerdate t1
    		where not exists (select * from Planner t2 where t2.POszam = t1.POszam);",conn);
			cmd.ExecuteNonQuery();
		}
		void Button8Click(object sender, EventArgs e)
		{
			Planningriport plr = new Planningriport();
			plr.Show();
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
			proc.StartInfo.FileName = @"\\gmacsm0001\dept\Production\14 REGISTER\01 Documents\MA-PRO-IN 427 Digitális regiszterek-.docx";
			proc.StartInfo.WorkingDirectory = @"V:\ROC\";
			proc.Start();		
		}
	}
}
