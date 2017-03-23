/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-07-06
 * Time: 12:42
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Liquidinster
{
	/// <summary>
	/// Description of Statpep.
	/// </summary>
	/// Pepsico registers chart
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
			System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.CurrentCulture;
			int weekNum = cul.Calendar.GetWeekOfYear(
   			DateTime.Now, 
    		System.Globalization.CalendarWeekRule.FirstFourDayWeek, 
    		DayOfWeek.Monday);
			textBox14.Text = weekNum.ToString();
			Button3Click(null,null);
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
					new SqlCommand("select * from dbo.PepsiweekQM10 WHERE Week = ('" + textBox14.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					textBox3.Text = (read["Feltoltott"].ToString());
					textBox1.Text = (read["QM10"].ToString());		
					textBox4.Text = (read["NonCom"].ToString());					
					}
				}	
		}
		void Button3Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM PepsiweekQM10 WHERE Year = '2016' ORDER BY Week", conn);
			dataAdapter1.Fill(ds);	
			chart1.DataSource = ds.Tables[0];
			chart1.Series.Add("NonCom");
			chart1.Series["NonCom"].YValueMembers = "NonCom";
			chart1.Series["NonCom"].XValueMember = "Week";
			chart1.Series["NonCom"].LegendText = "Non comfort registers number";
			chart1.ChartAreas[0].AxisX.Title = "Week";
			chart1.ChartAreas[0].AxisX.Interval = 1;
			chart1.Series["NonCom"].IsValueShownAsLabel = true;
			chart1.Series["NonCom"].ChartType = SeriesChartType.StackedColumn;
			chart1.Series["NonCom"].Color = Color.Red;
			chart1.Series["NonCom"]["PixelPointWidth"] = "100";
			chart1.Titles.Add("Production Pepsico check registers");
			chart1.Series.Add("Feltoltott");
			chart1.Series["Feltoltott"].YValueMembers = "Feltoltott";
			chart1.Series["Feltoltott"].XValueMember = "Week";
			chart1.Series["Feltoltott"].ChartType = SeriesChartType.StackedColumn;
			chart1.Series["Feltoltott"].LegendText = "Registers number";
			chart1.Series["Feltoltott"].Color = Color.Green;
			chart1.Series["Feltoltott"].IsValueShownAsLabel = true;
			chart1.Series.Add("Target");
			chart1.Series["Target"].YValueMembers = "Target";
			chart1.Series["Target"].XValueMember = "Week";
			chart1.Series["Target"].ChartType = SeriesChartType.FastLine;
			chart1.Series["Target"].LegendText = "Target";
			chart1.Series["Target"].Color = Color.Black;
			chart1.Series["Target"].IsValueShownAsLabel = true;
			chart1.DataSource = ds.Tables[0];
			chart1.Series.Add("PepsiNonCom");
			chart1.Series["PepsiNonCom"].YValueMembers = "QM10";
			chart1.Series["PepsiNonCom"].XValueMember = "Week";
			chart1.Series["PepsiNonCom"].LegendText = "QM 10";
			chart1.Series["PepsiNonCom"].ChartType = SeriesChartType.Line;
			chart1.Series["PepsiNonCom"].IsValueShownAsLabel = true;
			chart1.Series["Series1"].IsVisibleInLegend = false;	
		}
	}
}
