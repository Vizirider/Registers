/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-10-11
 * Time: 11:49
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

namespace Registers
{
	/// <summary>
	/// Description of OEE.
	/// </summary>
	public partial class OEE : Form
	{
		public OEE()
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
		void Button1Click(object sender, EventArgs e)
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM blendccp WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "')) AND Szitatimediff IS NOT NULL",conn);
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
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM blendkisccp WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "')) AND Szitatimediff IS NOT NULL",conn);
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
		void Button3Click(object sender, EventArgs e)
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM packccp WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "')) AND Szitatimediff IS NOT NULL",conn);
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
		void Button4Click(object sender, EventArgs e)
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Registerccp WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "')) AND Szitatimediff IS NOT NULL",conn);
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
		void DataGridView1CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			textBox2.Text = dataGridView1.RowCount.ToString();
			dataGridView1.Columns["Szitatimee"].DefaultCellStyle.BackColor = Color.Aqua;
			dataGridView1.Columns["Szitatimeu"].DefaultCellStyle.BackColor = Color.Aqua;
			dataGridView1.Columns["Detektortimee"].DefaultCellStyle.BackColor = Color.Aqua;
			dataGridView1.Columns["Detektortimeu"].DefaultCellStyle.BackColor = Color.Aqua;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Int32 rowtype = Convert.ToInt32(row.Cells["Szitatimediff"].Value);
//10 minutes diff
                if (rowtype < 500)
                {
                    dataGridView1.ClearSelection();
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }	
		}
		void Button8Click(object sender, EventArgs e)
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Registerccp WHERE Szitatimediff < 500 OR Detektordiff < 500 AND Szitatimediff IS NOT NULL",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];

			}
	    catch(Exception)
	    {
		MessageBox.Show("Don't have permission to access! Turn to the local IT group", "Warning");	    	
	    }	
		}	
		}
		void Button9Click(object sender, EventArgs e)
		{
			using 
				(SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")){
	    try{
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM sdccp WHERE (Termeles BETWEEN ('" + dateTimePicker1.Text + "') AND ('" + dateTimePicker2.Text + "')) AND Szitatimediff IS NOT NULL",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			}
	    catch(Exception)
	    {
		MessageBox.Show("Don't have permission to access! Turn to the local IT group", "Warning");	    	
	    }	
		}	
		}

}
}

