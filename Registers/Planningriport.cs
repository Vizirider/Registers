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
			Button1Click(null,null);
			Button2Click(null,null);
		}
		void Button1Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM Planningriport ORDER BY Datum", conn);
			dataAdapter1.Fill(ds);	
			chart1.DataSource = ds.Tables[0];
			chart1.Series.Add("POszam");
			chart1.Series["POszam"].YValueMembers = "POszam";
			chart1.Series["POszam"].XValueMember = "Datum";
			chart1.Series["POszam"].ChartType = SeriesChartType.StackedColumn;
			chart1.Series["POszam"].LegendText = "POszam";
			chart1.Series["Series1"].IsVisibleInLegend = false;	
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM Planningriporttarget ORDER BY Datum", conn);
			dataAdapter1.Fill(ds);	
			chart1.DataSource = ds.Tables[0];
			chart1.Series.Add("Target");
			chart1.Series["Target"].YValueMembers = "POszam";
			chart1.Series["Target"].XValueMember = "Datum";
			chart1.Series["Target"].ChartType = SeriesChartType.Line;
			chart1.Series["Target"].LegendText = "Target";	
		}
//   protected override void WndProc(ref Message m)
//    {
//        FormWindowState previousWindowState = this.WindowState;
//
//        base.WndProc(ref m);
//
//        FormWindowState currentWindowState = this.WindowState;
//
//        if (previousWindowState != currentWindowState && currentWindowState == FormWindowState.Maximized)
//        {
//			chart1.Size = new System.Drawing.Size(2000, 400);
//        }
//        else if (currentWindowState == FormWindowState.Minimized)
//        {
//			chart1.Size = new System.Drawing.Size(1180, 352);
//        }
//    }

	}
}
