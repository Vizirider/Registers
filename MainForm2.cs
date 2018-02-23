/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-17
 * Time: 13:07
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
	/// Description of MainForm2.
	/// </summary>
	public partial class MainForm2 : Form
	{
		private String connectionString = null;
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
		public MainForm2(string mws)
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
			textBox4.Text = " " + weekNum + ". hét";
			
			this.textBox8.Text = mws;
		}
		void Button39Click(object sender, EventArgs e)
		{

				Nemfelvitt nf = new Nemfelvitt();
		        nf.Show();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
					SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();			

			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT POszam, Batch, Datum FROM warehouse WHERE Datum > '2016-05-08'", conn);
			dataAdapter1.Fill(ds);
			
			
//			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
    		using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM warehouse WHERE Datum > '2016-05-08'", con))
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
			if(textBox3.Text.Length == 0)
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Datum, Batch FROM warehouse WHERE Batch LIKE ('" + textBox1.Text +"%') AND Datum > '2016-05-08' ORDER BY Datum Desc",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(Batch) FROM warehouse WHERE Batch LIKE ('" + textBox1.Text +"%') AND Datum > '2016-05-08'",conn))
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
			else if(textBox1.Text.Length == 0)
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Datum, Batch FROM warehouse WHERE POszam LIKE ('" + textBox3.Text +"%') AND Datum > '2016-05-08' ORDER BY Datum Desc",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM warehouse WHERE POszam LIKE ('" + textBox3.Text +"%') AND Datum > '2016-05-08'",conn))
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
			else{
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Datum, Batch FROM warehouse WHERE (POszam LIKE ('" + textBox3.Text +"%') AND Batch LIKE ('" + textBox1.Text +"%'))  AND Datum > '2016-05-08' ORDER BY Datum Desc",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM warehouse WHERE (POszam LIKE ('" + textBox3.Text +"%') AND Batch LIKE ('" + textBox1.Text +"%')) AND Datum > '2016-05-08'",conn))
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
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			Warehouse wh = new Warehouse(textBox8.Text);
			wh.Show();
		}

		void Button12Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Hu, Datum FROM warehouse2 WHERE Hu LIKE ('" + textBox7.Text +"%') ORDER BY Datum DESC",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			dataGridView3.Columns[0].Width = 145;
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(Hu) FROM warehouse2 WHERE Hu LIKE ('" + textBox7.Text +"%')",conn))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}	
		}

		void Button8Click(object sender, EventArgs e)
		{
			Warehouse2 wh2 = new Warehouse2(textBox8.Text);
			wh2.Show();	
		}
		void Button6Click(object sender, EventArgs e)
		{
			Warehouse2read wh2 = new Warehouse2read(textBox7.Text);
			wh2.Show();		
		}
		void DataGridView1CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(textBox3.Text.Length == 0)
			{
			MessageBox.Show("Hiányzó SO szám", "Üzenet");	
			}
			else{
			Warehouseread wh = new Warehouseread(this.dataGridView1.CurrentCell.Value.ToString(), textBox3.Text);
			wh.Show();					
			}
				
		}

		void DataGridView3CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Warehouse2read wh2 = new Warehouse2read(this.dataGridView3.CurrentCell.Value.ToString());
			wh2.Show();		
		}
		void DataGridView1CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			   	if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Batch")
			    {

			                e.CellStyle.BackColor = Color.Black;
							e.CellStyle.ForeColor = Color.White;			                
			   	}	
		}

		void DataGridView3CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			   	if (this.dataGridView3.Columns[e.ColumnIndex].Name == "Hu")
			    {

			                e.CellStyle.BackColor = Color.Black;
							e.CellStyle.ForeColor = Color.White;			                
			   	}		
		}
		void Button13Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam, Datum, Batch FROM Warehousenem WHERE POszam LIKE ('" + textBox1.Text +"%') AND Datum > '2016-05-08' ORDER BY Datum Desc",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM Warehousenem WHERE POszam LIKE ('" + textBox1.Text +"%') AND Datum > '2016-05-08'",conn))
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

		void Button15Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Batch, Datum FROM Warehousemintazonem WHERE Batch LIKE ('" + textBox7.Text +"%') AND Datum > '2016-05-08' ORDER BY Datum Desc",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			try{
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(Batch) FROM Warehousemintazonem WHERE Batch LIKE ('" + textBox7.Text +"%') AND Datum > '2016-05-08'",conn))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}
			}
			catch (SqlException ex)
			{
			    MessageBox.Show(ex.ToString()); // do you get any Exception here?
			}		
		}

		void Button2Click(object sender, EventArgs e)
		{
			Warehouseread wh = new Warehouseread(textBox1.Text, textBox3.Text);
			wh.Show();	
		}

	}
}
