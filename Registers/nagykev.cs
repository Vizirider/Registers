/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-08
 * Time: 09:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Data;

namespace Liquidinster
{
	/// <summary>
	/// Description of nagykev.
	/// </summary>
	public partial class nagykev : Form
	{
	public nagykev()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Blendertime WHERE PO LIKE ('" + textBox2.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			Button3Click(null,null);
			Button6Click(null,null);
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Blendertime",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
		}
		void Button3Click(object sender, EventArgs e)
		{
				using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("select SUM(COALESCE(Time1,0)+COALESCE(Time2,0)+COALESCE(Time3,0)+COALESCE(Time4,0)+COALESCE(Time5,0)+COALESCE(Time6,0)+COALESCE(Time7,0)+COALESCE(Time8,0)+COALESCE(Time9,0)+COALESCE(Time10,0)+COALESCE(Time11,0)+COALESCE(Time12,0)+COALESCE(Time13,0)+COALESCE(Time14,0)+COALESCE(Time15,0)+COALESCE(Time14,0)+COALESCE(Time15,0)+COALESCE(Time14,0)+COALESCE(Time15,0)+COALESCE(Time14,0)+COALESCE(Time15,0)+COALESCE(Time14,0)+COALESCE(Time15,0)+COALESCE(Time14,0)+COALESCE(Time15,0)+COALESCE(Time14,0)+COALESCE(Time15,0)+COALESCE(Time14,0)+COALESCE(Time15,0)+COALESCE(Time16,0)+COALESCE(Time17,0)+COALESCE(Time18,0)+COALESCE(Time19,0)+COALESCE(Time20,0)+COALESCE(Time21,0)+COALESCE(Time22,0)+COALESCE(Time23,0)+COALESCE(Time24,0)+COALESCE(Time25,0)+COALESCE(Time26,0)) AS Ido  from dbo.Blendertime WHERE PO=('" + textBox2.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        textBox1.Text = (read["Ido"].ToString());
			    }
			    read.Close();
			}
		
		}
		void DateTimePicker1ValueChanged(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Blendertime WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Gep = ('" + comboBox1.Text +"')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			Button4Click(null,null);
			Button5Click(null,null);
		}
		void Button4Click(object sender, EventArgs e)
		{
				using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("select SUM(COALESCE(Time1,0)+COALESCE(Time2,0)+COALESCE(Time3,0)+COALESCE(Time4,0)+COALESCE(Time5,0)+COALESCE(Time6,0)+COALESCE(Time7,0)+COALESCE(Time8,0)+COALESCE(Time9,0)+COALESCE(Time10,0)+COALESCE(Time11,0)+COALESCE(Time12,0)+COALESCE(Time13,0)+COALESCE(Time14,0)+COALESCE(Time15,0)+COALESCE(Time14,0)+COALESCE(Time15,0)+COALESCE(Time14,0)+COALESCE(Time15,0)+COALESCE(Time14,0)+COALESCE(Time15,0)+COALESCE(Time14,0)+COALESCE(Time15,0)+COALESCE(Time14,0)+COALESCE(Time15,0)+COALESCE(Time14,0)+COALESCE(Time15,0)+COALESCE(Time14,0)+COALESCE(Time15,0)+COALESCE(Time16,0)+COALESCE(Time17,0)+COALESCE(Time18,0)+COALESCE(Time19,0)+COALESCE(Time20,0)+COALESCE(Time21,0)+COALESCE(Time22,0)+COALESCE(Time23,0)+COALESCE(Time24,0)+COALESCE(Time25,0)+COALESCE(Time26,0)) AS Ido  from dbo.Blendertime WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Gep=('" + comboBox1.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        textBox1.Text = (read["Ido"].ToString());
			    }
			    read.Close();
			}		
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Blendertime WHERE Gep = ('" + comboBox1.Text +"')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			DateTimePicker1ValueChanged(null,null);
		}
		void Button5Click(object sender, EventArgs e)
		{
				using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("select SUM(COALESCE(Batchkg,0)) AS kg  from dbo.Blendertime WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Gep=('" + comboBox1.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        textBox3.Text = (read["kg"].ToString());
			    }
			    read.Close();
			}			
		}
		void Button6Click(object sender, EventArgs e)
		{
				using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("select SUM(COALESCE(Batchkg,0)) AS kg  from dbo.Blendertime WHERE PO=('" + textBox2.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        textBox3.Text = (read["kg"].ToString());
			    }
			    read.Close();
			}			
		}
		void DateTimePicker2ValueChanged(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Blendertime WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"') AND Gep = ('" + comboBox1.Text +"')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			Button4Click(null,null);
			Button5Click(null,null);		
		}

	}
}
