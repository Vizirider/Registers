/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-05-24
 * Time: 12:24
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
using System.Net.Mail;
using System.Windows.Forms.DataVisualization.Charting;

namespace Liquidinster
{
	/// <summary>
	/// Description of Planningriport.
	/// </summary>
	public partial class Planningriport : Form
	{
		public Planningriport()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Button2Click(null,null);
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM Planningriporttarget ORDER BY Datum", conn);
			dataAdapter1.Fill(ds);	
			chart1.DataSource = ds.Tables[0];
			chart1.Series.Add("Hianyzo");
			chart1.Series["Hianyzo"].YValueMembers = "Hianyzo";
			chart1.Series["Hianyzo"].XValueMember = "Datum";
			chart1.Series["Hianyzo"].ChartType = SeriesChartType.StackedColumn;
			chart1.Series["Hianyzo"].LegendText = "Hianyzo";	
			chart1.Series["Hianyzo"].Color = Color.Red;
			chart1.Series.Add("POszam");
			chart1.Series["POszam"].YValueMembers = "POszam";
			chart1.Series["POszam"].XValueMember = "Datum";
			chart1.Series["POszam"].ChartType = SeriesChartType.StackedColumn;
			chart1.Series["POszam"].LegendText = "POszam";
			chart1.Series["Series1"].IsVisibleInLegend = false;	
			chart1.ChartAreas[0].AxisX.Title = "Week";
			chart1.ChartAreas[0].AxisX.Interval = 1;
			chart1.Series.Add("Target");
			chart1.Series["Target"].YValueMembers = "Target";
			chart1.Series["Target"].XValueMember = "Datum";
			chart1.Series["Target"].ChartType = SeriesChartType.Line;
			chart1.Series["Target"].LegendText = "Target";	
		}

	}
}
