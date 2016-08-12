/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-05-09
 * Time: 10:34
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
using System.Net;


namespace Liquidinster
{
	/// <summary>
	/// Description of Stat.
	/// </summary>
	public partial class Stat : Form
	{
		public Stat()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			button1.Font = new Font(button1.Font.FontFamily, 14);
			System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.CurrentCulture;
			int weekNum = cul.Calendar.GetWeekOfYear(
   			DateTime.Now, 
    		System.Globalization.CalendarWeekRule.FirstFourDayWeek, 
    		DayOfWeek.Monday);
			textBox14.Text = weekNum.ToString();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = @"V:\Production\14 REGISTER\regiszter.xlsx";
			proc.StartInfo.WorkingDirectory = @"V:\Production\14 REGISTER";
			proc.Start();
	        MessageBox.Show("Regiszterek riport!");	
		}
		void Button2Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.chartweek WHERE Week = ('" + textBox14.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					textBox3.Text = (read["Feltoltott"].ToString());
					textBox1.Text = (read["Hianyzo"].ToString());	
					textBox2.Text = (read["Cel"].ToString());					
					}
				}		
		}
	}
}
