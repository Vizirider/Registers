/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-10-21
 * Time: 10:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registers
{
	/// <summary>
	/// Description of Regtime.
	/// </summary>
	public partial class Regtimep : Form
	{
		public Regtimep()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy.MM.dd";
			dateTimePicker2.Format = DateTimePickerFormat.Custom;
			dateTimePicker2.CustomFormat = "yyyy.MM.dd";
		}
		void DataGridView1CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			textBox2.Text = dataGridView1.RowCount.ToString();
			dataGridView1.Columns["Termelesveg"].DefaultCellStyle.BackColor = Color.Aqua;
			dataGridView1.Columns["Termelesidoveg1"].DefaultCellStyle.BackColor = Color.Aqua;
			dataGridView1.Columns["Termeleskezd"].DefaultCellStyle.BackColor = Color.Aqua;
			dataGridView1.Columns["Termelesidokezd1"].DefaultCellStyle.BackColor = Color.Aqua;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Int32 rowtype = Convert.ToInt32(row.Cells["Diffveg"].Value);
                Int32 rowtype1 = Convert.ToInt32(row.Cells["Diffkezd"].Value);
//4 hours diff
				if ((rowtype > 14400 || rowtype < -14400 || rowtype1 > 14400 || rowtype1 < -14400))
                {
                    dataGridView1.ClearSelection();
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (rowtype > 7200 && rowtype < 14400 || rowtype < -7200 && rowtype > -14400 || rowtype1 > 7200 && rowtype1 < 14400 || rowtype1 < -7200 && rowtype1 > -14400)
                {
                    dataGridView1.ClearSelection();
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
                else if (rowtype > 3600 && rowtype < 7200 || rowtype < -3600 && rowtype > -7200 || rowtype1 > 3600 && rowtype1 < 7200 || rowtype1 < -3600 && rowtype1 > -7200)
                {
                    dataGridView1.ClearSelection();
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }	
		}
		void Button19Click(object sender, EventArgs e)
		{
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Registertimediffpep WHERE Termelesdatum BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			}
	    catch(Exception)
	    {
		MessageBox.Show("Don't have permission to acces! Turn to the local IT group", "Warning");	    	
	    }	
		}	
		}
	}
		void Button18Click(object sender, EventArgs e)
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Registertimediffpep WHERE (Diffveg > 14400 OR Diffveg < -14400 OR Diffkezd > 14400 OR Diffkezd < -14400) AND (Termelesdatum BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "'))",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			}
	    catch(Exception)
	    {
		MessageBox.Show("Don't have permission to acces! Turn to the local IT group", "Warning");	    	
	    }	
		}	
		}
		void Button17Click(object sender, EventArgs e)
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Registertimediffpep WHERE ((Diffveg > 7200 AND Diffveg < 14400) OR (Diffveg < -7200 AND Diffveg > -14400) OR (Diffkezd > 7200 AND Diffkezd < 14400) OR (Diffkezd < -7200 AND Diffkezd > -14400)) AND (Termelesdatum BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "'))",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			}
	    catch(Exception)
	    {
		MessageBox.Show("Don't have permission to acces! Turn to the local IT group", "Warning");	    	
	    }	
		}	
		}
		void Button16Click(object sender, EventArgs e)
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Registertimediffpep WHERE ((Diffveg > 3600 AND Diffveg < 7200) OR (Diffveg < -3600 AND Diffveg > -7200) OR (Diffkezd > 3600 AND Diffkezd < 7200) OR (Diffkezd < -3600 AND Diffkezd > -7200)) AND (Termelesdatum BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "'))",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			}
	    catch(Exception)
	    {
		MessageBox.Show("Don't have permission to acces! Turn to the local IT group", "Warning");	    	
	    }	
		}	
		}
		void Button12Click(object sender, EventArgs e)
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Registertimediffpep WHERE (Termelesdatum BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "')) AND (Szoba = 'BMP01' OR Szoba = 'BMP02' OR Szoba = 'BMP03' OR Szoba = 'BMP04' OR Szoba = 'BMP05' OR Szoba = 'BMP06' OR Szoba = 'BMP07' OR Szoba = 'BMP09')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			}
	    catch(Exception)
	    {
		MessageBox.Show("Don't have permission to acces! Turn to the local IT group", "Warning");	    	
	    }	
		}	
		}
		void Button11Click(object sender, EventArgs e)
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Registertimediffpep WHERE (Termelesdatum BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "')) AND (Szoba = '6001' OR Szoba = '6002' OR Szoba = '6003' OR Szoba = '1501' OR Szoba = '1502' OR Szoba = 'Najis' OR Szoba = '1504' OR Szoba = '501' OR Szoba = '101')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			}
	    catch(Exception)
	    {
		MessageBox.Show("Don't have permission to acces! Turn to the local IT group", "Warning");	    	
	    }	
		}	
		}
		void Button10Click(object sender, EventArgs e)
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Registertimediffpep WHERE (Termelesdatum BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "')) AND (Szoba = 'Diosna' OR Szoba = 'Henschel' OR Szoba = 'Stephan44L' OR Szoba = 'Najis44L' OR Szoba = 'Hobar')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			}
	    catch(Exception)
	    {
		MessageBox.Show("Don't have permission to acces! Turn to the local IT group", "Warning");	    	
	    }	
		}	
		}
		void Button14Click(object sender, EventArgs e)
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Registertimediffpep WHERE (Termelesdatum BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "')) AND (Szoba = 'M20' OR Szoba = 'M60' OR Szoba = 'M450')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			}
	    catch(Exception)
	    {
		MessageBox.Show("Don't have permission to acces! Turn to the local IT group", "Warning");	    	
	    }	
		}	
		}
		void Button13Click(object sender, EventArgs e)
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Registertimediffpep WHERE (Termelesdatum BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "')) AND (Szoba like 'AK%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			}
	    catch(Exception)
	    {
		MessageBox.Show("Don't have permission to acces! Turn to the local IT group", "Warning");	    	
	    }	
		}	
		}
		void Button9Click(object sender, EventArgs e)
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Registertimediffpep WHERE (Termelesdatum BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "')) AND (Szoba = 'POS01' OR Szoba = 'POS02' OR Szoba = 'POS03' OR Szoba = 'POS04' OR Szoba = 'POS06' OR Szoba = 'POS07' OR Szoba = 'BigBag')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			}
	    catch(Exception)
	    {
		MessageBox.Show("Don't have permission to acces! Turn to the local IT group", "Warning");	    	
	    }	
		}	
		}
		void Button15Click(object sender, EventArgs e)
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Registertimediffpep WHERE (Diffveg > 3600 OR Diffveg < -3600 OR Diffkezd > 3600 OR Diffkezd < -3600) AND (Termelesdatum BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "'))",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			}
	    catch(Exception)
	    {
		MessageBox.Show("Don't have permission to acces! Turn to the local IT group", "Warning");	    	
	    }	
		}	
		}
		void Button1Click(object sender, EventArgs e)
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Registertimediffpep WHERE (Termelesdatum BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "')) AND (Szoba like 'L%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			}
	    catch(Exception)
	    {
		MessageBox.Show("Don't have permission to acces! Turn to the local IT group", "Warning");	    	
	    }	
		}		
		}
		void Button2Click(object sender, EventArgs e)
		{
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    // Bind Grid Data to Datatable
                    DataTable dt = new DataTable();
                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        dt.Columns.Add(col.HeaderText, col.ValueType);
                    }
                    int count = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (count < dataGridView1.Rows.Count - 1)
                        {
                            dt.Rows.Add();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                            }
                        }
                        count++;
                    }
                    // Bind table data to Stream Writer to export data to respective folder
                    StreamWriter wr = new StreamWriter(@"V:\Production\14 REGISTER\03 Timestamp\Timestamppep.xls");
                    // Write Columns to excel file
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        wr.Write(dt.Columns[i].ToString().ToUpper() + "\t");
                    }
                    wr.WriteLine();
                    //write rows to excel file
                    for (int i = 0; i < (dt.Rows.Count); i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            if (dt.Rows[i][j] != null)
                            {
                                wr.Write(Convert.ToString(dt.Rows[i][j]) + "\t");
                            }
                            else
                            {
                                wr.Write("\t");
                            }
                        }
                        wr.WriteLine();
                    }
                    wr.Close();
				MessageBox.Show("Data Exported Successfully to V:/Production/14 REGISTER/03 Timestamp", "");	
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }			
		}
		void Button3Click(object sender, EventArgs e)
		{
			Registers.Timestamptable times = new Timestamptable();
			times.Show();
		}
	}
}
