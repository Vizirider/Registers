/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-05-23
 * Time: 09:26
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
	/// Description of Statwh.
	/// </summary>
	public partial class Statwh : Form
	{
		public Statwh()
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
			Button4Click(null,null);
			Button3Click(null,null);
		}
		void Button1Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM Warehousebatch ORDER BY Datum", conn);
			dataAdapter1.Fill(ds);	
			chart1.DataSource = ds.Tables[0];
			chart1.Series.Add("Batchszam");
			chart1.Series["Batchszam"].YValueMembers = "Batchszam";
			chart1.Series["Batchszam"].XValueMember = "Datum";
			chart1.Series["Batchszam"].ChartType = SeriesChartType.StackedArea;
			chart1.Series["Batchszam"].LegendText = "Batchszám";
			chart1.Series["Batchszam"].Color = Color.Green;
			chart1.Series.Add("Nem felvittek");
			chart1.Series["Nem felvittek"].YValueMembers = "Nincsbatch";
			chart1.Series["Nem felvittek"].XValueMember = "Datum";
			chart1.Series["Nem felvittek"].ChartType = SeriesChartType.StackedColumn;
			chart1.Series["Nem felvittek"].Color = Color.Red;
			chart1.Series.Add("Target");
			chart1.Series["Target"].YValueMembers = "Target";
			chart1.Series["Target"].XValueMember = "Datum";
			chart1.Series["Target"].ChartType = SeriesChartType.Line;
			chart1.Series["Series1"].IsVisibleInLegend = false;
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM Warehousenemmeg ORDER BY Datum", conn);
			dataAdapter1.Fill(ds);	
			chart2.DataSource = ds.Tables[0];			
			chart2.Series.Add("Nem megfelelősség");
			chart2.Series["Nem megfelelősség"].Color = Color.IndianRed;
			chart2.Series["Nem megfelelősség"].YValueMembers = "Nemmeg";
			chart2.Series["Nem megfelelősség"].XValueMember = "Datum";
			chart2.Series["Nem megfelelősség"].ChartType = SeriesChartType.StackedColumn;
			chart2.Series["Nem megfelelősség"].LegendText = "Nem megfelelősség";
			chart2.Series["Series1"].IsVisibleInLegend = false;
		}
		void Button4Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM Warehouseraklap ORDER BY Datum", conn);
			dataAdapter1.Fill(ds);	
			chart4.DataSource = ds.Tables[0];
			chart4.Series.Add("Batchszam");
			chart4.Series["Batchszam"].YValueMembers = "Batchszam";
			chart4.Series["Batchszam"].XValueMember = "Datum";
			chart4.Series["Batchszam"].ChartType = SeriesChartType.StackedArea;
			chart4.Series["Batchszam"].LegendText = "Batchszám";
			chart4.Series["Batchszam"].Color = Color.Green;
			chart4.Series["Series1"].IsVisibleInLegend = false;
			chart4.Series.Add("Nem felvittek");
			chart4.Series["Nem felvittek"].YValueMembers = "Nincsbatch";
			chart4.Series["Nem felvittek"].XValueMember = "Datum";
			chart4.Series["Nem felvittek"].ChartType = SeriesChartType.StackedColumn;
			chart4.Series["Nem felvittek"].Color = Color.Red;			
			chart4.Series.Add("Target");
			chart4.Series["Target"].YValueMembers = "Target";
			chart4.Series["Target"].XValueMember = "Datum";
			chart4.Series["Target"].ChartType = SeriesChartType.Line;
			chart4.Series["Series1"].IsVisibleInLegend = false;
		}
		void Button3Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM Warehouseraklapnemmeg ORDER BY Datum", conn);
			dataAdapter1.Fill(ds);	
			chart3.DataSource = ds.Tables[0];			
			chart3.Series.Add("Nem megfelelősség");
			chart3.Series["Nem megfelelősség"].Color = Color.IndianRed;
			chart3.Series["Nem megfelelősség"].YValueMembers = "Nemmeg";
			chart3.Series["Nem megfelelősség"].XValueMember = "Datum";
			chart3.Series["Nem megfelelősség"].ChartType = SeriesChartType.StackedColumn;
			chart3.Series["Nem megfelelősség"].LegendText = "Nem megfelelősség";
			chart3.Series["Series1"].IsVisibleInLegend = false;	
		}
	}
}
