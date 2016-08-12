/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-05-17
 * Time: 11:14
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
	/// Description of MainForm4.
	/// </summary>
	public partial class MainForm4 : Form
	{
		public MainForm4(string mws)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.CurrentCulture;
			int weekNum = cul.Calendar.GetWeekOfYear(
   			DateTime.Now, 
    		System.Globalization.CalendarWeekRule.FirstFourDayWeek, 
    		DayOfWeek.Monday);
			textBox4.Text = " " + weekNum + ". week";
			
			this.textBox8.Text = mws;		
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button3Click(object sender, EventArgs e)
		{
			warehouseout who = new warehouseout(textBox8.Text);
			who.Show();
		}
		void Button7Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam AS SOnumber, Date, Batch FROM warehouseout WHERE POszam LIKE ('" + textBox1.Text +"%') ORDER BY Date Desc",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM warehouseout WHERE POszam LIKE ('" + textBox1.Text +"%')",conn))
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
		void Button2Click(object sender, EventArgs e)
		{
			warehouseoutread whor = new warehouseoutread(textBox1.Text);
			whor.Show();		
		}
		void DataGridView1CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			warehouseoutread whor = new warehouseoutread(this.dataGridView1.CurrentCell.Value.ToString());
			whor.Show();		
		}	
		
	}
}
