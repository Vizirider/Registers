/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-02-23
 * Time: 09:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.OracleClient;



namespace Liquidinster
{
	/// <summary>
	/// Description of MainForm1.
	/// Gyártásellenőrzési regiszterek
	/// </summary>
	public partial class MainForm1 : Form
	{

		public MainForm1(string mws, string lang)
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
			
			this.textBox8.Text = mws;
			button56.Font = new Font(button56.Font.FontFamily, 14);
			button72.Text = lang;
			if(button72.Text == "Lang")
			{
			textBox4.Text = " " + weekNum + ". hét";	
			}
			else if(button72.Text == "Nyelv")
			{
			textBox4.Text = " " + weekNum + ". week";	
			}
			dateTimePicker2.Format = DateTimePickerFormat.Custom;
			dateTimePicker2.CustomFormat = "yyyy.MM.dd";
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy.MM.dd";
			
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Name FROM dbo.Admins WHERE ID=('" + textBox8.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox14.Text = (read["Name"].ToString());		
				}
				else {
				this.textBox14.Text = textBox8.Text;				
				}
				read.Close();
			}

		}
		public System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
		public void InitTimer(object sender, EventHandler e)
		{
		    timer1.Interval = 5000; // in miliseconds
		    timer1.Tick += new System.EventHandler(timer1_Tick);
		    timer1.Start();
		}
		
		void timer1_Tick(object sender, EventArgs e)
		{
			Button13Click(null,null);
		}

		public void Refresh()
		{
			Button13Click(null,null);
		}
		public void Button9Click(object sender, EventArgs e)
		{
			Button1Click(sender, e);
			Button8Click(sender, e);
			Button10Click(sender, e);
			Button11Click(sender, e);
			Button12Click(sender, e);
			Button34Click(sender, e);
			Button33Click(sender, e);
			Button26Click(sender, e);
			button9.ForeColor = Color.White;
			button25.ForeColor = Color.Black;
			button13.ForeColor = Color.Black;
			
		}
		void Button13Click(object sender, EventArgs e)
		{
			Button18Click(sender, e);
			Button17Click(sender, e);
			Button16Click(sender, e);
			Button15Click(sender, e);
			Button14Click(sender, e);
			Button32Click(sender, e);
			Button31Click(sender, e);
			Button45Click(sender, e);
			button9.ForeColor = Color.Black;
			button25.ForeColor = Color.Black;
			button13.ForeColor = Color.White;
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM liquidella WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'06:00:00.000' AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'14:00:00.000'", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liquidella WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'06:00:00.000' AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM liquidella WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'14:00:00.000' AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'22:00:00.000'", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liquidella WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'14:00:00.000' AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM liquidella WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'06:00:00.000')", conn);
			dataAdapter2.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liquidella  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
			}
			
		}

		void Button8Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM bmpella WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 06:00:00.000' AND Termelesveg <'1899-12-30 14:00:00.000'", conn);
			dataAdapter2.Fill(ds);	
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			dataGridView2.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM bmpella WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 06:00:00.000' AND Termelesveg <'1899-12-30 14:00:00.000'", con))
    		{
		   	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox3.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután"|| comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM bmpella WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 14:00:00.000' AND Termelesveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter2.Fill(ds);	
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			dataGridView2.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM bmpella WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 14:00:00.000' AND Termelesveg <'1899-12-30 22:00:00.000'", con))
    		{
		   	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox3.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM bmpella WHERE (Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesveg >'1899-12-30 22:00:00.000') OR (Termelesdatum BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter2.Fill(ds);	
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			dataGridView2.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM bmpella WHERE (Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesveg >'1899-12-30 22:00:00.000') OR (Termelesdatum BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg <'1899-12-30 06:00:00.000')", con))
    		{
		   	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox3.Text = result.ToString();
    		}
			}
		}

		void Button10Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning" )
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM packella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 06:00:00.000' AND Termelesveg <'1899-12-30 14:00:00.000' ", conn);
			dataAdapter3.Fill(ds);	
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			dataGridView3.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM packella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND  Termelesveg >'1899-12-30 06:00:00.000' AND Termelesveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM packella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 14:00:00.000' AND Termelesveg <'1899-12-30 22:00:00.000' ", conn);
			dataAdapter3.Fill(ds);	
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			dataGridView3.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM packella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 14:00:00.000' AND Termelesveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM packella  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter3.Fill(ds);	
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			dataGridView3.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM packella  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
		}
		void Button11Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter4 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg < '1899-12-30 14:00:00.000'", conn);
			dataAdapter4.Fill(ds);	
			dataGridView4.DataSource = ds.Tables[0];
			dataGridView4.AutoResizeColumns();
			dataGridView4.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg < '1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox6.Text = result.ToString();
			}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter4 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter4.Fill(ds);	
			dataGridView4.DataSource = ds.Tables[0];
			dataGridView4.AutoResizeColumns();
			dataGridView4.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox6.Text = result.ToString();
			}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter4 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendella  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter4.Fill(ds);	
			dataGridView4.DataSource = ds.Tables[0];
			dataGridView4.AutoResizeColumns();
			dataGridView4.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendella  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox6.Text = result.ToString();
			}
			}
		}
		void Button12Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendkisella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView5.DataSource = ds.Tables[0];
			dataGridView5.AutoResizeColumns();
			dataGridView5.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendkisella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox7.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendkisella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView5.DataSource = ds.Tables[0];
			dataGridView5.AutoResizeColumns();
			dataGridView5.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendkisella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox7.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendkisella  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter5.Fill(ds);	
			dataGridView5.DataSource = ds.Tables[0];
			dataGridView5.AutoResizeColumns();
			dataGridView5.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendkisella  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox7.Text = result.ToString();
    		}
			}			
		}

		void Button34Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM sdella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView7.DataSource = ds.Tables[0];
			dataGridView7.AutoResizeColumns();
			dataGridView7.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM sdella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox10.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM sdella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView7.DataSource = ds.Tables[0];
			dataGridView7.AutoResizeColumns();
			dataGridView7.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM sdella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox10.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM sdella  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter5.Fill(ds);	
			dataGridView7.DataSource = ds.Tables[0];
			dataGridView7.AutoResizeColumns();
			dataGridView7.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM sdella  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox10.Text = result.ToString();
    		}
			}

		}

		void Button33Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM pfella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView6.DataSource = ds.Tables[0];
			dataGridView6.AutoResizeColumns();
			dataGridView6.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM pfella WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox9.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM pfella  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView6.DataSource = ds.Tables[0];
			dataGridView6.AutoResizeColumns();
			dataGridView6.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM pfella WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox9.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM pfella  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter5.Fill(ds);	
			dataGridView6.DataSource = ds.Tables[0];
			dataGridView6.AutoResizeColumns();
			dataGridView6.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM pfella WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox9.Text = result.ToString();
    		}
			}
		}
		void Button18Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM liquidelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'06:00:00.000' AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'14:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liquidelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'06:00:00.000' AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM liquidelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'14:00:00.000' AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'22:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liquidelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'14:00:00.000' AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM liquidelletlen WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'06:00:00.000')", conn);
			dataAdapter5.Fill(ds);	
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liquidelletlen WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
		}
		void Button17Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM bmpelletlen WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg>'1899-12-30 06:00:00.000' AND Termelesveg <'1899-12-30 14:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			dataGridView2.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM bmpelletlen WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 06:00:00.000' AND Termelesveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox3.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM bmpelletlen WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 14:00:00.000' AND Termelesveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			dataGridView2.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM bmpelletlen WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 14:00:00.000' AND Termelesveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox3.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM bmpelletlen WHERE (Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND  Termelesveg >'1899-12-30 22:00:00.000') OR (Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter5.Fill(ds);	
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			dataGridView2.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM bmpelletlen WHERE (Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND  Termelesveg >'1899-12-30 22:00:00.000') OR (Termelesdatum BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox3.Text = result.ToString();
    		}
			}
		}
		void Button16Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM packelletlen WHERE  Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 06:00:00.000' AND Termelesveg <'1899-12-30 14:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			dataGridView3.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM packelletlen WHERE  Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 06:00:00.000' AND Termelesveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM packelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 14:00:00.000' AND Termelesveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			dataGridView3.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM packelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 14:00:00.000' AND Termelesveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM packelletlen WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND  Termelesveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter5.Fill(ds);	
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			dataGridView3.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM packelletlen WHERE  (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND  Termelesveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
		}
		void Button15Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView4.DataSource = ds.Tables[0];
			dataGridView4.AutoResizeColumns();
			dataGridView4.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox6.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView4.DataSource = ds.Tables[0];
			dataGridView4.AutoResizeColumns();
			dataGridView4.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox6.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendelletlen WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter5.Fill(ds);	
			dataGridView4.DataSource = ds.Tables[0];
			dataGridView4.AutoResizeColumns();
			dataGridView4.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendelletlen WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox6.Text = result.ToString();
    		}
			}
		}
		void Button14Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendkiselletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView5.DataSource = ds.Tables[0];
			dataGridView5.AutoResizeColumns();
			dataGridView5.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendkiselletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox7.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendkiselletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView5.DataSource = ds.Tables[0];
			dataGridView5.AutoResizeColumns();
			dataGridView5.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendkiselletlen WHERE  Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox7.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendkiselletlen WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter5.Fill(ds);	
			dataGridView5.DataSource = ds.Tables[0];
			dataGridView5.AutoResizeColumns();
			dataGridView5.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendkiselletlen WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox7.Text = result.ToString();
    		}
			}
		}
		void Button32Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM sdelletlen  WHERE  Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView7.DataSource = ds.Tables[0];
			dataGridView7.AutoResizeColumns();
			dataGridView7.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM sdelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox10.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon") 
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM sdelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView7.DataSource = ds.Tables[0];
			dataGridView7.AutoResizeColumns();
			dataGridView7.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM sdelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox10.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM sdelletlen  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter5.Fill(ds);	
			dataGridView7.DataSource = ds.Tables[0];
			dataGridView7.AutoResizeColumns();
			dataGridView7.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM sdelletlen WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox10.Text = result.ToString();
    		}
			}
		}
		void Button31Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM pfelletlen  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView6.DataSource = ds.Tables[0];
			dataGridView6.AutoResizeColumns();
			dataGridView6.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM pfelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox9.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM pfelletlen WHERE  Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView6.DataSource = ds.Tables[0];
			dataGridView6.AutoResizeColumns();
			dataGridView6.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM pfelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox9.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM pfelletlen  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter5.Fill(ds);	
			dataGridView6.DataSource = ds.Tables[0];
			dataGridView6.AutoResizeColumns();
			dataGridView6.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM pfelletlen WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox9.Text = result.ToString();
    		}
			}
		}
		void Button7Click(object sender, EventArgs e)
		{
			if(textBox1.TextLength > 0)
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM liquidella WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			Button20Click(sender, e);
			Button21Click(sender, e);
			Button22Click(sender, e);
			Button23Click(sender, e);
			Button37Click(sender, e);
			Button38Click(sender, e);
			Button46Click(sender, e);
			textBox2.Text = "";
			textBox3.Text = "";
			textBox6.Text = "";
			textBox7.Text = "";
			textBox10.Text = "";
			textBox9.Text = "";
			textBox5.Text = "";
			textBox11.Text = "";
			}
			else{
						MessageBox.Show("Empty PO", "Warning");
			
			}
		}
		void Button20Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM bmpella WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
		}
		void Button21Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM packella WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
		}
		void Button22Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendella WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView4.DataSource = ds.Tables[0];
			dataGridView4.AutoResizeColumns();
		}
		void Button23Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendkisella WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView5.DataSource = ds.Tables[0];
			dataGridView5.AutoResizeColumns();
		}
		void Button37Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM sdella WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView7.DataSource = ds.Tables[0];
			dataGridView7.AutoResizeColumns();
		}
		void Button38Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM pfella WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView6.DataSource = ds.Tables[0];
			dataGridView6.AutoResizeColumns();
		}
		void Button19Click(object sender, EventArgs e)
		{
			Form8 f8 = new Form8(this.textBox8.Text);
			f8.Show();
		}
		void Button6Click(object sender, EventArgs e)
		{
			Form9 f9 = new Form9(this.textBox8.Text);
			f9.Show();
		}
		void Button2Click(object sender, EventArgs e)
		{
			Form10 f10 = new Form10(this.textBox8.Text);
			f10.Show();
		}
		void Button4Click(object sender, EventArgs e)
		{
			Form11 f11 = new Form11(this.textBox8.Text);
			f11.Show();
		}
		void Button5Click(object sender, EventArgs e)
		{
			Form12 f12 = new Form12(this.textBox8.Text);
			f12.Show();
		}
		void Button36Click(object sender, EventArgs e)
		{
			Form13 f13 = new Form13(this.textBox8.Text);
			f13.Show();
		}
		void Button35Click(object sender, EventArgs e)
		{
			Form14 f14 = new Form14(this.textBox8.Text);
			f14.Show();		
		}
		void Button29Click(object sender, EventArgs e)
		{
			MessageBox.Show("Sikeresen tisztítottad a listát, frissült. Beléphetsz újra", "Üzenet");
			this.Close();
		}
		void Button24Click(object sender, EventArgs e)
		{
			Liquidter liqter = new Liquidter(textBox8.Text,textBox1.Text, this);
			liqter.Show();
		}
		void Button39Click(object sender, EventArgs e)
		{
			Nemfelvitt1 nf1 = new Nemfelvitt1();
		        nf1.Show();		
		}
		void Button40Click(object sender, EventArgs e)
		{
		MessageBox.Show("Napi riport megy ki a production gmailre, iletve heti keddenként 8:00-kor", "Üzenet");
		Process.Start(@"V:\Common (Don't share confidential docs here)\adminregisters\ellenorzes.accdb");

		}
		void Button71Click(object sender, EventArgs e)
		{
		DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete Register from " + comboBox2.Text, MessageBoxButtons.YesNo);
		if(dialogResult == DialogResult.Yes)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			if(comboBox2.Text == "liquid")
			{
			SqlCommand cmd1 = new SqlCommand(@"DELETE FROM dbo.liquidell  WHERE POszam = ('" + textBox1.Text +"')",conn);
			SqlCommand cmd2 = new SqlCommand(@"DELETE FROM dbo.liquidella  WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd1.ExecuteNonQuery();
			cmd2.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "bmp")
			{
			SqlCommand cmd3 = new SqlCommand(@"DELETE FROM dbo.bmpell  WHERE POszam = ('" + textBox1.Text +"')",conn);
			SqlCommand cmd4 = new SqlCommand(@"DELETE FROM dbo.bmpella  WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			cmd4.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "blendingnagy")
			{
			SqlCommand cmd5 = new SqlCommand(@"DELETE FROM dbo.blendell  WHERE POszam = ('" + textBox1.Text +"')",conn);
			SqlCommand cmd6 = new SqlCommand(@"DELETE FROM dbo.blendella  WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd5.ExecuteNonQuery();
			cmd6.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "blendingkicsi")
			{
			SqlCommand cmd7 = new SqlCommand(@"DELETE FROM dbo.blendkisell  WHERE POszam = ('" + textBox1.Text +"')",conn);
			SqlCommand cmd8 = new SqlCommand(@"DELETE FROM dbo.blendkisella  WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd7.ExecuteNonQuery();
			cmd8.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "sd")
			{
			SqlCommand cmd9 = new SqlCommand(@"DELETE FROM dbo.sdell  WHERE POszam = ('" + textBox1.Text +"')",conn);
			SqlCommand cmd10 = new SqlCommand(@"DELETE FROM dbo.sdella  WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd9.ExecuteNonQuery();
			cmd10.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "pf")
			{
			SqlCommand cmd11 = new SqlCommand(@"DELETE FROM dbo.pfell  WHERE POszam = ('" + textBox1.Text +"')",conn);
			SqlCommand cmd12 = new SqlCommand(@"DELETE FROM dbo.pfella  WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd11.ExecuteNonQuery();
			cmd12.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "lödige")
			{
			SqlCommand cmd13 = new SqlCommand(@"DELETE FROM dbo.lodige  WHERE POszam = ('" + textBox1.Text +"')",conn);
			SqlCommand cmd14 = new SqlCommand(@"DELETE FROM dbo.lodigea  WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd13.ExecuteNonQuery();
			cmd14.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "packingoff")
			{
			SqlCommand cmd15 = new SqlCommand(@"DELETE FROM dbo.packell  WHERE POszam = ('" + textBox1.Text +"')",conn);
			SqlCommand cmd16 = new SqlCommand(@"DELETE FROM dbo.packella  WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd15.ExecuteNonQuery();
			cmd16.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			conn.Close();
		}
		else{
			
		}
		}
		void Button41Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM pfnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView6.DataSource = ds.Tables[0];
			dataGridView6.AutoResizeColumns();
			dataGridView6.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM pfnemmeg WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox9.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM pfnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView6.DataSource = ds.Tables[0];
			dataGridView6.AutoResizeColumns();
			dataGridView6.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM pfnemmeg WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox9.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM pfnemmeg  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter5.Fill(ds);	
			dataGridView6.DataSource = ds.Tables[0];
			dataGridView6.AutoResizeColumns();
			dataGridView6.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM pfnemmeg WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox9.Text = result.ToString();
    		}
			}

		}
		void Button42Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			if(comboBox2.Text == "liquid")
			{
			SqlCommand cmd1 = new SqlCommand(@"Update dbo.liquidella set Ellenorizve = 1, Ellenorzo='" + textBox8.Text + "' WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			cmd1.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "bmp")
			{
			SqlCommand cmd2 = new SqlCommand(@"Update dbo.bmpella set Ellenorizve = 1, Ellenorzo='" + textBox8.Text + "' WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			cmd2.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "blendingnagy")
			{
			SqlCommand cmd3 = new SqlCommand(@"Update dbo.blendella set Ellenorizve = 1, Ellenorzo='" + textBox8.Text + "' WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			cmd3.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "blendingkicsi")
			{
			SqlCommand cmd4 = new SqlCommand(@"Update dbo.blendkisella set Ellenorizve = 1, Ellenorzo='" + textBox8.Text + "' WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			cmd4.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "sd")
			{
			SqlCommand cmd5 = new SqlCommand(@"Update dbo.sdella set Ellenorizve = 1, Ellenorzo='" + textBox8.Text + "' WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			cmd5.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "pf")
			{
			SqlCommand cmd6 = new SqlCommand(@"Update dbo.pfella set Ellenorizve = 1, Ellenorzo='" + textBox8.Text + "' WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			cmd6.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "lödige")
			{
			SqlCommand cmd7 = new SqlCommand(@"Update dbo.lodigea set Ellenorizve = 1, Ellenorzo='" + textBox8.Text + "' WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			cmd7.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "packingoff")
			{
			SqlCommand cmd8 = new SqlCommand(@"Update dbo.packella set Ellenorizve = 1, Ellenorzo='" + textBox8.Text + "' WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			cmd8.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			conn.Close();		
		}
		void Button43Click(object sender, EventArgs e)
		{
			Liquidter liqter = new Liquidter(textBox8.Text, textBox1.Text, this);
			liqter.Show();
		}
		void MainForm1Load(object sender, EventArgs e)
		{
			if(button72.Text == "Nyelv")
			{
		    Image myimage = new Bitmap(@"V:\Production\14 REGISTER\hun.png");
		    button72.BackgroundImage = myimage;
		    button9.Text = "All";
		    button25.Text = "Wrongs";
		    button13.Text = "Unchecked";
			button39.Text = "Missing POs";
			button29.Text = "Update,Delete null rows, wrong POs";
			label10.Text = "table";
			label1.Text = "POnumber";
			button7.Text = "Search";
			button71.Text = "Delete";
			button64.Text = "Drop";
			button47.Text = "Multi check";
			button42.Text = "Check";	
			button40.Text = "Mail riport";
			button56.Text = "Statistic riport";	
			label5.Text = "bigBlend";			
			label6.Text = "smallBlend";
			button4.Text = "bigBlend";
			button5.Text = "smallBlend";
			button52.Text = "Missing POs";
			label12.Text = "what";
			comboBox1.Items.Add("Morning");	
			comboBox1.Items.Add("Afternoon");	
			comboBox1.Items.Add("Night");	
			comboBox1.Items.Remove("Délelőtt");
			comboBox1.Items.Remove("Délután");
			comboBox1.Items.Remove("Éjszaka");
			}
			else if(button72.Text == "Lang")
			{
//		    Image myimage = new Bitmap(@"V:\Production\14 REGISTER\eng.png");
//			button72.BackgroundImage = myimage;
		    button9.Text = "Összes";
		    button25.Text = "Hibás";
		    button13.Text = "Ellenőrizetlen";
			button39.Text = "Nem felvittek";
			button29.Text = "Frissítés, Törlés üres sorok, hibás PO-k";
			label10.Text = "táblázatos";
			label1.Text = "POszam";		
			button7.Text = "Keres";	
			button71.Text = "törlés";
			button64.Text = "kivétel";
			button47.Text = "Multi ellenőrzés";
			button42.Text = "ellenőrzés";	
			button40.Text = "Levél riport";
			button56.Text = "Statisztika riport";	
			label5.Text = "Blendingnagy";			
			label6.Text = "Blendingkicsi";
			button4.Text = "Blendingnagy";
			button5.Text = "Blendingkicsi";	
			button52.Text = "Hiányzó PO-k";
			label12.Text = "ami";
			comboBox1.Items.Remove("Morning");	
			comboBox1.Items.Remove("Afternoon");	
			comboBox1.Items.Remove("Night");				
			}			
			var dateTimeStr = "06:00:00";
			var dateTimeStr1 = "14:00:00";
			var dateTimeStr2 = "22:00:00";
			var user_time = DateTime.Parse( dateTimeStr );
			var user_time1 = DateTime.Parse( dateTimeStr1 );
			var user_time2 = DateTime.Parse( dateTimeStr2 );
			
			var time_now = DateTime.Now;
			
			if( time_now > user_time &&  time_now < user_time1 ) 
			{
				comboBox1.SelectedIndex = 0;
			}
			if( time_now > user_time1 &&  time_now < user_time2 ) 
			{
				comboBox1.SelectedIndex = 1;
			}
			if( time_now > user_time2 ||  time_now < user_time ) 
			{
				comboBox1.SelectedIndex = 2;
			}
		}
		void Button44Click(object sender, EventArgs e)
		{
			bmpter bmps = new bmpter(textBox8.Text, textBox1.Text, this);
			bmps.Show();
			
		}
		void Button26Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM lodigea  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg7 >'1899-12-30 06:00:00.000' AND Termelesidoveg7 <'1899-12-30 14:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView8.DataSource = ds.Tables[0];
			dataGridView8.AutoResizeColumns();
			dataGridView8.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM lodigea  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg7 >'1899-12-30 06:00:00.000' AND Termelesidoveg7 <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox11.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM lodigea  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg7 >'1899-12-30 14:00:00.000' AND Termelesidoveg7 <'1899-12-30 22:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView8.DataSource = ds.Tables[0];
			dataGridView8.AutoResizeColumns();
			dataGridView8.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM lodigea  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg7 >'1899-12-30 14:00:00.000' AND Termelesidoveg7 <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox11.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM lodigea  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesidoveg7 >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg7 <'1899-12-30 06:00:00.000')", conn);
			dataAdapter5.Fill(ds);	
			dataGridView8.DataSource = ds.Tables[0];
			dataGridView8.AutoResizeColumns();
			dataGridView8.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM lodigea  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND Termelesidoveg7 >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg7 <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox11.Text = result.ToString();
    		}
			}			
		}
		void Button45Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM lodigelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg7 >'1899-12-30 06:00:00.000' AND Termelesidoveg7 <'1899-12-30 14:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView8.DataSource = ds.Tables[0];
			dataGridView8.AutoResizeColumns();
			dataGridView8.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM lodigelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg7 >'1899-12-30 06:00:00.000' AND Termelesidoveg7 <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox11.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM lodigelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg7 >'1899-12-30 14:00:00.000' AND Termelesidoveg7 <'1899-12-30 22:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView8.DataSource = ds.Tables[0];
			dataGridView8.AutoResizeColumns();
			dataGridView8.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM lodigelletlen WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg7 >'1899-12-30 14:00:00.000' AND Termelesidoveg7 <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox11.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM lodigelletlen WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg7 >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg7 <'1899-12-30 06:00:00.000')", conn);
			dataAdapter5.Fill(ds);	
			dataGridView8.DataSource = ds.Tables[0];
			dataGridView8.AutoResizeColumns();
			dataGridView8.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM lodigelletlen WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg7 >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg7 <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox11.Text = result.ToString();
    		}
			}	
		}
		void Button46Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM lodigea WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView8.DataSource = ds.Tables[0];
			dataGridView8.AutoResizeColumns();	
		}
		void Button47Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
		DialogResult result2 = MessageBox.Show("Átnézted az összes ellenőrizetlen PO-t (leszűrve az adott műszakra)?",
	    "Ellenőrzés",
	    MessageBoxButtons.YesNoCancel,
	    MessageBoxIcon.Question);
			if(result2 == DialogResult.Yes)
			{
			SqlCommand cmd1 = new SqlCommand(@"Update dbo.liquidella set Ellenorizve = 1, Ellenorzo='" + textBox14.Text + "' WHERE (Ellenorizve IS NULL) OR (Ellenorizve = 0)",conn);
			cmd1.ExecuteNonQuery();
			SqlCommand cmd2 = new SqlCommand(@"Update dbo.bmpella set Ellenorizve = 1, Ellenorzo='" + textBox14.Text + "' WHERE (Ellenorizve IS NULL) OR (Ellenorizve = 0)",conn);
			cmd2.ExecuteNonQuery();
			SqlCommand cmd3 = new SqlCommand(@"Update dbo.blendkisella set Ellenorizve = 1, Ellenorzo='" + textBox14.Text + "' WHERE (Ellenorizve IS NULL) OR (Ellenorizve = 0)",conn);
			cmd3.ExecuteNonQuery();
			SqlCommand cmd4 = new SqlCommand(@"Update dbo.blendella set Ellenorizve = 1, Ellenorzo='" + textBox14.Text + "' WHERE (Ellenorizve IS NULL) OR (Ellenorizve = 0)",conn);
			cmd4.ExecuteNonQuery();
			SqlCommand cmd5 = new SqlCommand(@"Update dbo.packella set Ellenorizve = 1, Ellenorzo='" + textBox14.Text + "' WHERE (Ellenorizve IS NULL) OR (Ellenorizve = 0)",conn);
			cmd5.ExecuteNonQuery();		
			SqlCommand cmd6 = new SqlCommand(@"Update dbo.sdella set Ellenorizve = 1, Ellenorzo='" + textBox14.Text + "' WHERE (Ellenorizve IS NULL) OR (Ellenorizve = 0)",conn);
			cmd6.ExecuteNonQuery();		
			SqlCommand cmd7 = new SqlCommand(@"Update dbo.pfella set Ellenorizve = 1, Ellenorzo='" + textBox14.Text + "' WHERE (Ellenorizve IS NULL) OR (Ellenorizve = 0)",conn);
			cmd7.ExecuteNonQuery();		
			SqlCommand cmd8 = new SqlCommand(@"Update dbo.lodigea set Ellenorizve = 1, Ellenorzo='" + textBox14.Text + "' WHERE (Ellenorizve IS NULL) OR (Ellenorizve = 0)",conn);
			cmd8.ExecuteNonQuery();				
			Button9Click(sender, e);				
			}
		}
		void Button48Click(object sender, EventArgs e)
		{
			packter pack = new packter(textBox8.Text, textBox1.Text,this);
			pack.Show();
		}
		void Button49Click(object sender, EventArgs e)
		{
			blendingter blendtermeles = new blendingter(textBox8.Text, textBox1.Text, this);
			blendtermeles.Show();
		}
		void Button50Click(object sender, EventArgs e)
		{
			sd sd = new sd(textBox8.Text, textBox1.Text,this);
			sd.Show();	
		}
		void Button51Click(object sender, EventArgs e)
		{
			pf pf = new pf(textBox8.Text, textBox1.Text,this);
			pf.Show();		
		}
		void Button52Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.Napihiany WHERE Termeles = ('" + dateTimePicker1.Text + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox12.Text = (read["Ossz"].ToString());	
					textBox13.Text = (read["Hiany"].ToString());
					}
				else{
					textBox12.Text = "0";
					textBox13.Text = "100%";
				}	
			}
		}

		void Button3Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM liqnemmeg WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liqnemmeg WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM liqnemmeg WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liqnemmeg WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM liqnemmeg WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liqnemmeg WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
			}		
		}		void Button25Click(object sender, EventArgs e)
		{
		Button3Click(sender, e);
		Button27Click(sender, e);
		Button28Click(sender, e);
		Button30Click(sender, e);
		Button41Click(sender, e);
		Button54Click(sender, e);
		Button55Click(sender, e);
		button9.ForeColor = Color.Black;
		button25.ForeColor = Color.White;
		button13.ForeColor = Color.Black;
		Button58Click(sender, e);

		}
		void Button27Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM bmpnemmeg WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 06:00:00.000' AND Termelesveg <'1899-12-30 14:00:00.000'", conn);
			dataAdapter2.Fill(ds);	
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			dataGridView2.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM bmpnemmeg WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 06:00:00.000' AND Termelesveg <'1899-12-30 14:00:00.000'", con))
    		{
		   	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox3.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM bmpnemmeg WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 14:00:00.000' AND Termelesveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter2.Fill(ds);	
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			dataGridView2.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM bmpnemmeg WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 14:00:00.000' AND Termelesveg <'1899-12-30 22:00:00.000'", con))
    		{
		   	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox3.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM bmpnemmeg WHERE (Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 22:00:00.000') OR (Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter2.Fill(ds);	
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			dataGridView2.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM bmpnemmeg WHERE (Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 22:00:00.000') OR (Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg <'1899-12-30 06:00:00.000')", con))
    		{
		   	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox3.Text = result.ToString();
    		}
			}
	
		}
		void Button28Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter4 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg < '1899-12-30 14:00:00.000'", conn);
			dataAdapter4.Fill(ds);	
			dataGridView4.DataSource = ds.Tables[0];
			dataGridView4.AutoResizeColumns();
			dataGridView4.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg < '1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox6.Text = result.ToString();
			}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter4 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter4.Fill(ds);	
			dataGridView4.DataSource = ds.Tables[0];
			dataGridView4.AutoResizeColumns();
			dataGridView4.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox6.Text = result.ToString();
			}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter4 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendnemmeg  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter4.Fill(ds);	
			dataGridView4.DataSource = ds.Tables[0];
			dataGridView4.AutoResizeColumns();
			dataGridView4.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendnemmeg  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox6.Text = result.ToString();
			}
			}
	
		}
		void Button30Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM sdnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView7.DataSource = ds.Tables[0];
			dataGridView7.AutoResizeColumns();
			dataGridView7.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM sdnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox10.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM sdnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView7.DataSource = ds.Tables[0];
			dataGridView7.AutoResizeColumns();
			dataGridView7.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM sdnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox10.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM sdnemmeg  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter5.Fill(ds);	
			dataGridView7.DataSource = ds.Tables[0];
			dataGridView7.AutoResizeColumns();
			dataGridView7.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM sdnemmeg  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox10.Text = result.ToString();
    		}
			}
	
		}
		void Button54Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendkisellnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView5.DataSource = ds.Tables[0];
			dataGridView5.AutoResizeColumns();
			dataGridView5.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendkisellnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox7.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendkisellnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView5.DataSource = ds.Tables[0];
			dataGridView5.AutoResizeColumns();
			dataGridView5.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendkisellnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox7.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendkisellnemmeg  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter5.Fill(ds);	
			dataGridView5.DataSource = ds.Tables[0];
			dataGridView5.AutoResizeColumns();
			dataGridView5.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendkisellnemmeg  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox7.Text = result.ToString();
    		}
			}			

		}
		void Button55Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM packnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 06:00:00.000' AND Termelesveg <'1899-12-30 14:00:00.000' ", conn);
			dataAdapter3.Fill(ds);	
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			dataGridView3.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM packnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND  Termelesveg >'1899-12-30 06:00:00.000' AND Termelesveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM packnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 14:00:00.000' AND Termelesveg <'1899-12-30 22:00:00.000' ", conn);
			dataAdapter3.Fill(ds);	
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			dataGridView3.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM packnemmeg  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 14:00:00.000' AND Termelesveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM packnemmeg  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter3.Fill(ds);	
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			dataGridView3.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM packnemmeg  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
	
		}
		void Button25MouseHover(object sender, EventArgs e)
		{
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button25, "Nem megfelelőségek");		
		}
		void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Liquidter liqter = new Liquidter(textBox8.Text, this.dataGridView1.CurrentCell.Value.ToString(), this);
			liqter.Show();
		}
		void DataGridView2CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bmpter bmps = new bmpter(textBox8.Text, this.dataGridView2.CurrentCell.Value.ToString(), this);
			bmps.Show();	
		}
		void DataGridView4CellClick(object sender, DataGridViewCellEventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select * from dbo.blendella WHERE POszam = ('" +this.dataGridView4.CurrentCell.Value.ToString() + "')", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				while (read.Read()) {
					
					if(read["kevero"].ToString() == "1" || read["kevero"].ToString() == "2" || read["kevero"].ToString() == "3" || read["kevero"].ToString() == "4" || read["kevero"].ToString() == "5" ||
					   read["kevero"].ToString() == "8"){
						Registers.blendingteruj blend = new Registers.blendingteruj(textBox8.Text, this.dataGridView4.CurrentCell.Value.ToString(), this);
						blend.Show();
			        }
					else{
						blendingter blendtermeles = new blendingter(textBox8.Text, this.dataGridView4.CurrentCell.Value.ToString(), this);
						blendtermeles.Show();
					}
				}
				
			}	
		}
		void DataGridView7CellClick(object sender, DataGridViewCellEventArgs e)
		{
			sd sd = new sd(textBox8.Text, this.dataGridView7.CurrentCell.Value.ToString(),this);
			sd.Show();	
		}
		void DataGridView6CellClick(object sender, DataGridViewCellEventArgs e)
		{
			pf pf = new pf(textBox8.Text, this.dataGridView6.CurrentCell.Value.ToString(),this);
			pf.Show();	
		}
		void DataGridView3CellClick(object sender, DataGridViewCellEventArgs e)
		{
			packter pack = new packter(textBox8.Text, this.dataGridView3.CurrentCell.Value.ToString(),this);
			pack.Show();	
		}
		void DataGridView5CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			blendkis blendkister = new blendkis(textBox8.Text, this.dataGridView5.CurrentCell.Value.ToString(), this);
			blendkister.Show();		
		}
		void Button56Click(object sender, EventArgs e)
		{
			Stat stat = new Stat();
			stat.Show();
		}
		void DataGridView8CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			lodige lod = new lodige(textBox8.Text, dataGridView8.CurrentCell.Value.ToString(),this);
			lod.Show();
		}
		void Button58Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM nemmeglodige  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000' ", conn);
			dataAdapter3.Fill(ds);	
			dataGridView8.DataSource = ds.Tables[0];
			dataGridView8.AutoResizeColumns();
			dataGridView8.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM nemmeglodige  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND  Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox11.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM nemmeglodige  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000' ", conn);
			dataAdapter3.Fill(ds);	
			dataGridView8.DataSource = ds.Tables[0];
			dataGridView8.AutoResizeColumns();
			dataGridView8.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM nemmeglodige  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox11.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM nemmeglodige  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter3.Fill(ds);	
			dataGridView8.DataSource = ds.Tables[0];
			dataGridView8.AutoResizeColumns();
			dataGridView8.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM nemmeglodige  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox11.Text = result.ToString();
    		}
			}		
		}
		void Button72Click(object sender, EventArgs e)
		{
			if(button72.Text == "Lang")
			{
		    Image myimage = new Bitmap(@"V:\Production\14 REGISTER\hun.png");
		    button72.BackgroundImage = myimage;
		    button72.Text = "Nyelv";
		    button9.Text = "All";
		    button25.Text = "Wrongs";
		    button13.Text = "Unchecked";
			button39.Text = "Missing POs";
			button29.Text = "Update,Delete null rows, wrong POs";
			label10.Text = "table";
			label1.Text = "POnumber";
			button7.Text = "Search";
			button71.Text = "Delete";
			button64.Text = "Drop";
			button47.Text = "Multi check";
			button42.Text = "Check";	
			button40.Text = "Mail riport";
			button56.Text = "Statistic riport";	
			label5.Text = "bigBlend";			
			label6.Text = "smallBlend";
			button4.Text = "bigBlend";
			button5.Text = "smallBlend";
			button52.Text = "Missing POs";
			label12.Text = "what";
			comboBox1.Items.Add("Morning");	
			comboBox1.Items.Add("Afternoon");	
			comboBox1.Items.Add("Night");	
			comboBox1.Items.Remove("Délelőtt");
			comboBox1.Items.Remove("Délután");
			comboBox1.Items.Remove("Éjszaka");			
			}
			else if(button72.Text == "Nyelv")
			{
		    Image myimage = new Bitmap(@"V:\Production\14 REGISTER\eng.png");
		    button72.BackgroundImage = myimage;
		    button72.Text = "Lang";
		    button9.Text = "Összes";
		    button25.Text = "Hibás";
		    button13.Text = "Ellenőrizetlen";
			button39.Text = "Nem felvittek";
			button29.Text = "Frissítés, Törlés üres sorok, hibás PO-k";
			label10.Text = "táblázatos";
			label1.Text = "POszam";		
			button7.Text = "Keres";	
			button71.Text = "törlés";
			button64.Text = "kivétel";
			button47.Text = "Multi ellenőrzés";
			button42.Text = "ellenőrzés";	
			button40.Text = "Levél riport";
			button56.Text = "Statisztika riport";	
			label5.Text = "Blendingnagy";			
			label6.Text = "Blendingkicsi";
			button4.Text = "Blendingnagy";
			button5.Text = "Blendingkicsi";	
			button52.Text = "Hiányzó PO-k";
			label12.Text = "ami";	
			comboBox1.Items.Remove("Morning");	
			comboBox1.Items.Remove("Afternoon");	
			comboBox1.Items.Remove("Night");
			comboBox1.Items.Add("Délelőtt");	
			comboBox1.Items.Add("Délután");	
			comboBox1.Items.Add("Éjszaka");				
			}			
		}
		void Button63Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM liquidellapep WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'06:00:00.000' AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'14:00:00.000'", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liquidellapep WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'06:00:00.000' AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM liquidellapep WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'14:00:00.000' AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'22:00:00.000'", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liquidellapep WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'14:00:00.000' AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM liquidellapep WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'06:00:00.000')", conn);
			dataAdapter2.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM liquidellapep  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker1.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) >'22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker2.Text +"') AND ('" + dateTimePicker2.Text +"') AND CONVERT(DATETIME,RIGHT(termelesidoveg,8)) <'06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox2.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}
			}
			
	
		}
		void Button53Click(object sender, EventArgs e)
		{
			Button63Click(null,null);
			Button62Click(null,null);
			Button61Click(null,null);
			Button60Click(null,null);
			Button59Click(null,null);
			dataGridView7.DataSource = null;
			dataGridView6.DataSource = null;		
			dataGridView8.DataSource = null;				
		}
		void Button62Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM bmpellapep WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 06:00:00.000' AND Termelesveg <'1899-12-30 14:00:00.000'", conn);
			dataAdapter2.Fill(ds);	
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			dataGridView2.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM bmpellapep WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 06:00:00.000' AND Termelesveg <'1899-12-30 14:00:00.000'", con))
    		{
		   	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox3.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután"|| comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM bmpellapep WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 14:00:00.000' AND Termelesveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter2.Fill(ds);	
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			dataGridView2.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM bmpellapep WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 14:00:00.000' AND Termelesveg <'1899-12-30 22:00:00.000'", con))
    		{
		   	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox3.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter2 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM bmpellapep WHERE (Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 22:00:00.000') OR (Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter2.Fill(ds);	
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			dataGridView2.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM bmpellapep WHERE (Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 22:00:00.000') OR (Termelesdatum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg <'1899-12-30 06:00:00.000')", con))
    		{
		   	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox3.Text = result.ToString();
    		}
			}
	
		}
		void Button61Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendkisellapep  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView5.DataSource = ds.Tables[0];
			dataGridView5.AutoResizeColumns();
			dataGridView5.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendkisellapep  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox7.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendkisellapep  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter5.Fill(ds);	
			dataGridView5.DataSource = ds.Tables[0];
			dataGridView5.AutoResizeColumns();
			dataGridView5.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendkisellapep  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox7.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night"){
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter5 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendkisellapep  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter5.Fill(ds);	
			dataGridView5.DataSource = ds.Tables[0];
			dataGridView5.AutoResizeColumns();
			dataGridView5.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendkisellapep  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox7.Text = result.ToString();
    		}
			}			
	
		}
		void Button60Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter4 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendellapep  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg < '1899-12-30 14:00:00.000'", conn);
			dataAdapter4.Fill(ds);	
			dataGridView4.DataSource = ds.Tables[0];
			dataGridView4.AutoResizeColumns();
			dataGridView4.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendellapep  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 06:00:00.000' AND Termelesidoveg < '1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox6.Text = result.ToString();
			}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter4 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendellapep  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", conn);
			dataAdapter4.Fill(ds);	
			dataGridView4.DataSource = ds.Tables[0];
			dataGridView4.AutoResizeColumns();
			dataGridView4.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendellapep  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 14:00:00.000' AND Termelesidoveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox6.Text = result.ToString();
			}
			}
			if(comboBox1.Text == "Éjszaka" || comboBox1.Text == "Night")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter4 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM blendellapep  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter4.Fill(ds);	
			dataGridView4.DataSource = ds.Tables[0];
			dataGridView4.AutoResizeColumns();
			dataGridView4.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM blendellapep  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesidoveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox6.Text = result.ToString();
			}
			}
	
		}
		void Button59Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == "Délelőtt" || comboBox1.Text == "Morning" )
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM packellapep  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 06:00:00.000' AND Termelesveg <'1899-12-30 14:00:00.000' ", conn);
			dataAdapter3.Fill(ds);	
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			dataGridView3.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM packellapep  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND  Termelesveg >'1899-12-30 06:00:00.000' AND Termelesveg <'1899-12-30 14:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Délután" || comboBox1.Text == "Afternoon")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM packellapep  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 14:00:00.000' AND Termelesveg <'1899-12-30 22:00:00.000' ", conn);
			dataAdapter3.Fill(ds);	
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			dataGridView3.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM packellapep  WHERE Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 14:00:00.000' AND Termelesveg <'1899-12-30 22:00:00.000'", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
			if(comboBox1.Text == "Éjszaka")
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter3 = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM packellapep  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg <'1899-12-30 06:00:00.000')", conn);
			dataAdapter3.Fill(ds);	
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			dataGridView3.AutoResizeColumnHeadersHeight();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM packellapep  WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg >'1899-12-30 22:00:00.000') OR (Termeles BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Termelesveg <'1899-12-30 06:00:00.000')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
	
		}
		void TextBox1KeyUp(object sender, KeyEventArgs e)
		{		
			if (e.KeyCode == Keys.Enter)
		{
			if(textBox1.TextLength > 0)
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Ellenorizve, Ellenorzo FROM liquidella WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			Button20Click(sender, e);
			Button21Click(sender, e);
			Button22Click(sender, e);
			Button23Click(sender, e);
			Button37Click(sender, e);
			Button38Click(sender, e);
			Button46Click(sender, e);
			textBox2.Text = "";
			textBox3.Text = "";
			textBox6.Text = "";
			textBox7.Text = "";
			textBox10.Text = "";
			textBox9.Text = "";
			textBox5.Text = "";
			textBox11.Text = "";
			}
			else{
						MessageBox.Show("Empty PO", "Warning");
			}
			}
		}
		void Button64Click(object sender, EventArgs e)
		{
		DialogResult dialogResult = MessageBox.Show("Are you sure?", "n/a in " + comboBox2.Text, MessageBoxButtons.YesNo);
		if(dialogResult == DialogResult.Yes)		
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			if(comboBox2.Text == "liquid")
			{
			SqlCommand cmd1 = new SqlCommand(@"UPDATE [dbo].[reportall] SET [LIQ] = 'n/a' WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd1.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "bmp")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[reportall] SET [BMP] = 'n/a' WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "blendingnagy")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[reportall] SET [BLEND] = 'n/a' WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "blendingkicsi")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[reportall] SET [BLEND] = 'n/a' WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "sd")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[reportall] SET [SD] = 'n/a' WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "pf")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[reportall] SET [PF] = 'n/a' WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "lödige")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[reportall] SET [PF] = 'n/a' WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			else if(comboBox2.Text == "packingoff")
			{
			SqlCommand cmd3 = new SqlCommand(@"UPDATE [dbo].[reportall] SET [PACK_OFF] = 'n/a' WHERE POszam = ('" + textBox1.Text +"')",conn);
			cmd3.ExecuteNonQuery();
			Button7Click(sender, e);
			}
			conn.Close();
		}
		else{
			
		}
		}
		void Button65Click(object sender, EventArgs e)
		{
			Registers.OEE oee = new Registers.OEE();
			oee.Show();
		}
		void Button66Click(object sender, EventArgs e)
		{
		OracleConnection con; 
		con = new OracleConnection();
        con.ConnectionString = "User Id=cms_usr;Password=cmslcmsu;Data Source=huncp.emea.givaudan.com"; 
        con.Open(); 
        MessageBox.Show("Connected to Oracle"); 	
        con.Close();
        Registers.CMS cms = new Registers.CMS();
        cms.Show();
		}
		void Button67Click(object sender, EventArgs e)
		{
			Registers.Regtime reg = new Registers.Regtime();
			reg.Show();
		}

	
	}
}
