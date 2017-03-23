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
	///  Chart of batches from warehouse outbound
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
			Button5Click(null,null);
			Button6Click(null,null);
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
			chart1.Series["Batchszam"].LegendText = "Batch number";
			chart1.Series["Batchszam"].Color = Color.Green;
			chart1.Series.Add("Nem felvittek");
			chart1.Series["Nem felvittek"].YValueMembers = "Nincsbatch";
			chart1.Series["Nem felvittek"].XValueMember = "Datum";
			chart1.Series["Nem felvittek"].LegendText = "Missing batch number";
			chart1.ChartAreas[0].AxisX.Title = "Week";
			chart1.ChartAreas[0].AxisX.Interval = 1;
			chart1.Series["Nem felvittek"].ChartType = SeriesChartType.StackedColumn;
			chart1.Series["Nem felvittek"].Color = Color.Red;
			chart1.Series["Nem felvittek"]["PixelPointWidth"] = "100";
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
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM warehousenemekw ORDER BY Datum", conn);
			dataAdapter1.Fill(ds);	
			chart2.DataSource = ds.Tables[0];			
			chart2.Series.Add("Matdep");
			chart2.Titles.Add("Non comfort");
			chart2.Series["Matdep"].Color = Color.Red;
			chart2.Series["Matdep"].YValueMembers = "Matdep";
			chart2.Series["Matdep"].XValueMember = "Datum";
			chart2.Series["Matdep"].ChartType = SeriesChartType.StackedColumn;
			chart2.Series["Matdep"].LegendText = "Material description";
			chart2.ChartAreas[0].AxisX.Title = "Week";
			chart2.ChartAreas[0].AxisX.Interval = 1;
			chart2.Series.Add("Matcom");
			chart2.Series["Matcom"].Color = Color.Orange;
			chart2.Series["Matcom"].YValueMembers = "Matcom";
			chart2.Series["Matcom"].XValueMember = "Datum";
			chart2.Series["Matcom"].ChartType = SeriesChartType.StackedColumn;
			chart2.Series["Matcom"].LegendText = "Material commercial";		
			chart2.Series.Add("Labsled");
			chart2.Series["Labsled"].Color = Color.Purple;
			chart2.Series["Labsled"].YValueMembers = "Labsled";
			chart2.Series["Labsled"].XValueMember = "Datum";
			chart2.Series["Labsled"].ChartType = SeriesChartType.StackedColumn;
			chart2.Series["Labsled"].LegendText = "Label SLED";			
			chart2.Series.Add("Zealab");
			chart2.Series["Zealab"].Color = Color.Blue;
			chart2.Series["Zealab"].YValueMembers = "Zealab";
			chart2.Series["Zealab"].XValueMember = "Datum";
			chart2.Series["Zealab"].ChartType = SeriesChartType.StackedColumn;
			chart2.Series["Zealab"].LegendText = "ZEA label";		
			chart2.Series.Add("Zexlab");
			chart2.Series["Zexlab"].Color = Color.Green;
			chart2.Series["Zexlab"].YValueMembers = "Zexlab";
			chart2.Series["Zexlab"].XValueMember = "Datum";
			chart2.Series["Zexlab"].ChartType = SeriesChartType.StackedColumn;
			chart2.Series["Zexlab"].LegendText = "ZEX label";	
			chart2.Series.Add("Corpal");
			chart2.Series["Corpal"].Color = Color.Yellow;
			chart2.Series["Corpal"].YValueMembers = "Corpal";
			chart2.Series["Corpal"].XValueMember = "Datum";
			chart2.Series["Corpal"].ChartType = SeriesChartType.StackedColumn;
			chart2.Series["Corpal"].LegendText = "Pallet type";		
			chart2.Series.Add("Thegood");
			chart2.Series["Thegood"].Color = Color.Brown;
			chart2.Series["Thegood"].YValueMembers = "Thegood";
			chart2.Series["Thegood"].XValueMember = "Datum";
			chart2.Series["Thegood"].ChartType = SeriesChartType.StackedColumn;
			chart2.Series["Thegood"].LegendText = "Shrink wrapped properly";		
			chart2.Series.Add("Thepall");
			chart2.Series["Thepall"].Color = Color.DarkSeaGreen;
			chart2.Series["Thepall"].YValueMembers = "Thepall";
			chart2.Series["Thepall"].XValueMember = "Datum";
			chart2.Series["Thepall"].ChartType = SeriesChartType.StackedColumn;
			chart2.Series["Thepall"].LegendText = "Pallet only one batch";
			chart2.Series.Add("Packun");
			chart2.Series["Packun"].Color = Color.Turquoise;
			chart2.Series["Packun"].YValueMembers = "Packun";
			chart2.Series["Packun"].XValueMember = "Datum";
			chart2.Series["Packun"].ChartType = SeriesChartType.StackedColumn;
			chart2.Series["Packun"].LegendText = "Package damage";
			chart2.Series["Series1"].IsVisibleInLegend = false;
			chart2.Series.Add("Nobox");
			chart2.Series["Nobox"].Color = Color.LightGray;
			chart2.Series["Nobox"].YValueMembers = "Nobox";
			chart2.Series["Nobox"].XValueMember = "Datum";
			chart2.Series["Nobox"].ChartType = SeriesChartType.StackedColumn;
			chart2.Series["Nobox"].LegendText = "Box overhang from pallet";
			chart2.Series["Series1"].IsVisibleInLegend = false;
			chart2.Series.Add("Palletli");
			chart2.Series["Palletli"].Color = Color.LightGoldenrodYellow;
			chart2.Series["Palletli"].YValueMembers = "Palletli";
			chart2.Series["Palletli"].XValueMember = "Datum";
			chart2.Series["Palletli"].ChartType = SeriesChartType.StackedColumn;
			chart2.Series["Palletli"].LegendText = "Pallet liner";
			chart2.Series["Series1"].IsVisibleInLegend = false;
			chart2.Series.Add("Zmp");
			chart2.Series["Zmp"].Color = Color.CornflowerBlue;
			chart2.Series["Zmp"].YValueMembers = "Zmp";
			chart2.Series["Zmp"].XValueMember = "Datum";
			chart2.Series["Zmp"].ChartType = SeriesChartType.StackedColumn;
			chart2.Series["Zmp"].LegendText = "ZMP label";
			chart2.Series["Series1"].IsVisibleInLegend = false;
			chart2.Series.Add("Givfelirat");
			chart2.Series["Givfelirat"].Color = Color.MediumSlateBlue;
			chart2.Series["Givfelirat"].YValueMembers = "Givfelirat";
			chart2.Series["Givfelirat"].XValueMember = "Datum";
			chart2.Series["Givfelirat"].ChartType = SeriesChartType.StackedColumn;
			chart2.Series["Givfelirat"].LegendText = "Givaudan logo";
			chart2.Series["Series1"].IsVisibleInLegend = false;
			chart2.Series.Add("Givfolia");
			chart2.Series["Givfolia"].Color = Color.MediumVioletRed;
			chart2.Series["Givfolia"].YValueMembers = "Givfolia";
			chart2.Series["Givfolia"].XValueMember = "Datum";
			chart2.Series["Givfolia"].ChartType = SeriesChartType.StackedColumn;
			chart2.Series["Givfolia"].LegendText = "Givaudan foil";
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
			chart4.Series["Batchszam"].LegendText = "Batch number";
			chart4.Series["Batchszam"].Color = Color.Green;
			chart4.Series["Series1"].IsVisibleInLegend = false;
			chart4.ChartAreas[0].AxisX.Title = "Week";
			chart4.ChartAreas[0].AxisX.Interval = 1;
			chart4.Series.Add("Nem felvittek");
			chart4.Series["Nem felvittek"].YValueMembers = "Nincsbatch";
			chart4.Series["Nem felvittek"].XValueMember = "Datum";
			chart4.Series["Nem felvittek"].ChartType = SeriesChartType.StackedColumn;
			chart4.Series["Nem felvittek"].LegendText = "Missing batch number";
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
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM warehouseraklapnemekw ORDER BY Datum", conn);
			dataAdapter1.Fill(ds);	
			chart3.DataSource = ds.Tables[0];			
			chart3.Series.Add("Cimketart");
			chart3.Titles.Add("Non comfort");
			chart3.Series["Cimketart"].Color = Color.Red;
			chart3.Series["Cimketart"].YValueMembers = "Cimketart";
			chart3.Series["Cimketart"].XValueMember = "Datum";
			chart3.Series["Cimketart"].ChartType = SeriesChartType.StackedColumn;
			chart3.Series["Cimketart"].LegendText = "Label ";
			chart3.Series["Cimketart"]["PixelPointWidth"] = "100";
			chart3.ChartAreas[0].AxisX.Title = "Week";
			chart3.ChartAreas[0].AxisX.Interval = 1;
			chart3.Series.Add("Arumeg");
			chart3.Series["Arumeg"].Color = Color.Orange;
			chart3.Series["Arumeg"].YValueMembers = "Arumeg";
			chart3.Series["Arumeg"].XValueMember = "Datum";
			chart3.Series["Arumeg"].ChartType = SeriesChartType.StackedColumn;
			chart3.Series["Arumeg"].LegendText = "Shrink wrapped properly";		
			chart3.Series["Arumeg"]["PixelPointWidth"] = "100";	
			chart3.Series.Add("Givfelirat");
			chart3.Series["Givfelirat"].Color = Color.Purple;
			chart3.Series["Givfelirat"].YValueMembers = "Givfelirat";
			chart3.Series["Givfelirat"].XValueMember = "Datum";
			chart3.Series["Givfelirat"].ChartType = SeriesChartType.StackedColumn;
			chart3.Series["Givfelirat"].LegendText = "Givaudan logo";
			chart3.Series["Givfelirat"]["PixelPointWidth"] = "100";				
			chart3.Series.Add("Csomag");
			chart3.Series["Csomag"].Color = Color.Blue;
			chart3.Series["Csomag"].YValueMembers = "Csomag";
			chart3.Series["Csomag"].XValueMember = "Datum";
			chart3.Series["Csomag"].ChartType = SeriesChartType.StackedColumn;
			chart3.Series["Csomag"].LegendText = "Package damage";
			chart3.Series["Csomag"]["PixelPointWidth"] = "100";			
			chart3.Series.Add("Raklap");
			chart3.Series["Raklap"].Color = Color.Green;
			chart3.Series["Raklap"].YValueMembers = "Raklap";
			chart3.Series["Raklap"].XValueMember = "Datum";
			chart3.Series["Raklap"].ChartType = SeriesChartType.StackedColumn;
			chart3.Series["Raklap"].LegendText = "No overhang from pallet";	
			chart3.Series["Raklap"]["PixelPointWidth"] = "100";
			chart3.Series.Add("Zmp");
			chart3.Series["Zmp"].Color = Color.Yellow;
			chart3.Series["Zmp"].YValueMembers = "Zmp";
			chart3.Series["Zmp"].XValueMember = "Datum";
			chart3.Series["Zmp"].ChartType = SeriesChartType.StackedColumn;
			chart3.Series["Zmp"].LegendText = "ZMP label";
			chart3.Series["Zmp"]["PixelPointWidth"] = "100";			
		}
		void Button5Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM Warehousemintazonemekw ORDER BY Datum", conn);
			dataAdapter1.Fill(ds);	
			chart5.DataSource = ds.Tables[0];			
			chart5.Titles.Add("Non comfort");
			chart5.ChartAreas[0].AxisX.Title = "Week";
			chart5.ChartAreas[0].AxisX.Interval = 1;
			chart5.Series.Add("Kanal");
			chart5.Series["Kanal"].Color = Color.Orange;
			chart5.Series["Kanal"].YValueMembers = "Kanal";
			chart5.Series["Kanal"].XValueMember = "Datum";
			chart5.Series["Kanal"].ChartType = SeriesChartType.StackedColumn;
			chart5.Series["Kanal"].LegendText = "New sample spoon used";		
			chart5.Series["Kanal"]["PixelPointWidth"] = "100";	
			chart5.Series.Add("Kidobva");
			chart5.Series["Kidobva"].Color = Color.Purple;
			chart5.Series["Kidobva"].YValueMembers = "Kidobva";
			chart5.Series["Kidobva"].XValueMember = "Datum";
			chart5.Series["Kidobva"].ChartType = SeriesChartType.StackedColumn;
			chart5.Series["Kidobva"].LegendText = "All sample spoons discarded";
			chart5.Series["Kidobva"]["PixelPointWidth"] = "100";				
			chart5.Series.Add("Edenykulonb");
			chart5.Series["Edenykulonb"].Color = Color.Blue;
			chart5.Series["Edenykulonb"].YValueMembers = "Edenykulonb";
			chart5.Series["Edenykulonb"].XValueMember = "Datum";
			chart5.Series["Edenykulonb"].ChartType = SeriesChartType.StackedColumn;
			chart5.Series["Edenykulonb"].LegendText = "Sampling bottles and cups difference";
			chart5.Series["Edenykulonb"]["PixelPointWidth"] = "100";
			chart5.Series["Series1"].IsVisibleInLegend = false;					
		}
		void Button6Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM Warehousemintazo ORDER BY Datum", conn);
			dataAdapter1.Fill(ds);	
			chart6.DataSource = ds.Tables[0];
			chart6.Series.Add("Batchszam");
			chart6.Series["Batchszam"].YValueMembers = "Batchszam";
			chart6.Series["Batchszam"].XValueMember = "Datum";
			chart6.Series["Batchszam"].ChartType = SeriesChartType.StackedArea;
			chart6.Series["Batchszam"].LegendText = "Batch number";
			chart6.Series["Batchszam"].Color = Color.Green;
			chart6.Series.Add("Nem felvittek");
			chart6.Series["Nem felvittek"].YValueMembers = "Nincsbatch";
			chart6.Series["Nem felvittek"].XValueMember = "Datum";
			chart6.Series["Nem felvittek"].LegendText = "Missing batch number";
			chart6.ChartAreas[0].AxisX.Title = "Week";
			chart6.ChartAreas[0].AxisX.Interval = 1;
			chart6.Series["Nem felvittek"].ChartType = SeriesChartType.StackedColumn;
			chart6.Series["Nem felvittek"].Color = Color.Red;
			chart6.Series["Nem felvittek"]["PixelPointWidth"] = "100";
			chart6.Series.Add("Target");
			chart6.Series["Target"].YValueMembers = "Target";
			chart6.Series["Target"].XValueMember = "Datum";
			chart6.Series["Target"].ChartType = SeriesChartType.Line;
			chart6.Series["Series1"].IsVisibleInLegend = false;		
		}

	}
}
