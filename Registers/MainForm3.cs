/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-17
 * Time: 16:16
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
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Liquidinster
{
	/// <summary>
	/// Description of MainForm3.
	/// </summary>
	public partial class MainForm3 : Form
	{
		public MainForm3(string mws)
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
    		DayOfWeek.Monday);;
			textBox4.Text = " " + weekNum + ". hét";
			dateTimePicker2.Format = DateTimePickerFormat.Custom;
			dateTimePicker2.CustomFormat = "yyyy.MM.dd";
			
			this.textBox8.Text = mws;
			Button1Click(null, null);
		}
		void Button1Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Datum FROM Planner", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM Planner", con))
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
		void Button7Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Datum FROM Planner WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
		}
		void Button39Click(object sender, EventArgs e)
		{
		}
		void Button3Click(object sender, EventArgs e)
		{
			Planning pl = new Planning(dateTimePicker2.Text, textBox8.Text);
			pl.Show();
		}

		void Button34Click(object sender, EventArgs e)
		{
				Nemfelvitt nf = new Nemfelvitt();
		        nf.Show();
		}
		void Button70Click(object sender, EventArgs e)
		{
			if(comboBox1.Text == ""){
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = @"V:\ROC\PepsiCo ROC summary 2014-2015.xlsx";
			proc.StartInfo.FileName = @"V:\ROC\PepsiCo ROC summary 2016.xlsx";
			proc.StartInfo.WorkingDirectory = @"V:\ROC\";
			proc.Start();
	        MessageBox.Show("Excel 2014-2015-2016 archív!");
			}
			else if(comboBox1.Text == "2014-2015"){
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = @"V:\ROC\PepsiCo ROC summary 2014-2015.xlsx";
			proc.StartInfo.WorkingDirectory = @"V:\ROC\";
			proc.Start();
	        MessageBox.Show("Excel 2014-2015 archív!");			
			}
			else if(comboBox1.Text == "2016"){
			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = @"V:\ROC\PepsiCo ROC summary 2016.xlsx";
			proc.StartInfo.WorkingDirectory = @"V:\ROC\";
			proc.Start();
	        MessageBox.Show("Excel 2016 archív!");				
			}	
		}
	}
}
