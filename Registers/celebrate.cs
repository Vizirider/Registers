/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-08-03
 * Time: 11:15
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
	/// Description of celebrate.
	/// </summary>
	public partial class celebrate : Form
	{
		public celebrate(string mws, string lang)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.textBox8.Text = mws;
			button9.Text = lang;			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			// Timer
  	this.timer1.Enabled = true;
    this.timer1.Interval = 5000;
    this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
    Button1Click(null,null);
		}
		void Timer1Tick(object sender, EventArgs e)
		{ 
			
//			MainForm1 mf1 = new MainForm1(this.textBox8.Text, button9.Text);
//			mf1.Show(); 
			Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Töltött, Helyezett from dbo.Helyezes WHERE ID = ('" + textBox8.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox1.Text = (read["Töltött"].ToString());	
					textBox2.Text = (read["Helyezett"].ToString());					
					}
				else{
					textBox1.Text = "0";
					textBox2.Visible = false;
					label4.Visible = false;
					}
			}
			
		}
	}
}
