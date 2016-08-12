/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-07-18
 * Time: 08:52
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
	/// Description of naplok.
	/// </summary>
	public partial class naplok : Form
	{
		public naplok()
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
		}
		void Button1Click(object sender, EventArgs e)
		{
			Button2Click(null,null);
			Button4Click(null,null);
			Button5Click(null,null);
			Button6Click(null,null);
			Button7Click(null,null);
			Button8Click(null,null);
			Button9Click(null,null);
			Button10Click(null,null);			
		}
		void Button2Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Operator1, Operator2, Operator3 from dbo.BMPnap WHERE Datum = ('" + dateTimePicker1.Text + "') AND Allomas = 2", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox57.Text = (read["Operator1"].ToString());	
					textBox57.BackColor = Color.White;	
					textBox56.Text = (read["Operator2"].ToString());	
					textBox56.BackColor = Color.White;	
					textBox55.Text = (read["Operator3"].ToString());	
					textBox55.BackColor = Color.White;						
					}
				else {
					textBox57.Text = "0";
					textBox56.Text = "0";
					textBox55.Text = "0";
				}
				}	
		}
		void Button3Click(object sender, EventArgs e)
		{
		System.Diagnostics.Process.Start(@"V:\Production\14 REGISTER\naplo.accdb");	
		}
		void Button4Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Operator1, Operator2, Operator3 from dbo.SD WHERE Datum = ('" + dateTimePicker1.Text + "') AND SD = 'M450' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox60.Text = (read["Operator1"].ToString());	
					textBox60.BackColor = Color.White;	
					textBox59.Text = (read["Operator2"].ToString());	
					textBox59.BackColor = Color.White;	
					textBox58.Text = (read["Operator3"].ToString());	
					textBox58.BackColor = Color.White;						
					}
				else {
					textBox60.Text = "0";
					textBox59.Text = "0";
					textBox58.Text = "0";
				}
				}	
		}
		void Button5Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Operator1, Operator2, Operator3 from dbo.SD WHERE Datum = ('" + dateTimePicker1.Text + "') AND SD = 'M60' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox63.Text = (read["Operator1"].ToString());	
					textBox63.BackColor = Color.White;	
					textBox62.Text = (read["Operator2"].ToString());	
					textBox62.BackColor = Color.White;	
					textBox61.Text = (read["Operator3"].ToString());	
					textBox61.BackColor = Color.White;						
					}
				else {
					textBox63.Text = "0";
					textBox62.Text = "0";
					textBox61.Text = "0";
				}
				}		
		}
		void Button6Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select Operator1, Operator2, Operator3 from dbo.SD WHERE Datum = ('" + dateTimePicker1.Text + "') AND SD = 'M20' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox66.Text = (read["Operator1"].ToString());	
					textBox66.BackColor = Color.White;	
					textBox65.Text = (read["Operator2"].ToString());	
					textBox65.BackColor = Color.White;	
					textBox64.Text = (read["Operator3"].ToString());	
					textBox64.BackColor = Color.White;						
					}
				else {
					textBox66.Text = "0";
					textBox65.Text = "0";
					textBox64.Text = "0";
				}
				}	
		}
		void Button7Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.PF WHERE Datum = ('" + dateTimePicker1.Text + "') AND Reactor = 'R1601' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox69.Text = (read["operator1"].ToString());	
					textBox69.BackColor = Color.White;	
					textBox68.Text = (read["operator2"].ToString());	
					textBox68.BackColor = Color.White;	
					textBox67.Text = (read["operator3"].ToString());	
					textBox67.BackColor = Color.White;						
					}
				else {
					textBox69.Text = "0";
					textBox68.Text = "0";
					textBox67.Text = "0";
				}
				}	
		}
		void Button8Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.PF WHERE Datum = ('" + dateTimePicker1.Text + "') AND Reactor = 'R4001' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox72.Text = (read["operator1"].ToString());	
					textBox72.BackColor = Color.White;	
					textBox71.Text = (read["operator2"].ToString());	
					textBox71.BackColor = Color.White;	
					textBox70.Text = (read["operator3"].ToString());	
					textBox70.BackColor = Color.White;						
					}
				else {
					textBox72.Text = "0";
					textBox71.Text = "0";
					textBox70.Text = "0";
				}
				}	
		}
		void Button9Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI")) {
				SqlCommand command =
					new SqlCommand("select operator1, operator2, operator3 from dbo.PF WHERE Datum = ('" + dateTimePicker1.Text + "') AND Reactor = 'Lödige' ", connection);
				connection.Open();
				
				SqlDataReader read = command.ExecuteReader();

				if (read.Read()) {
					textBox75.Text = (read["operator1"].ToString());	
					textBox75.BackColor = Color.White;	
					textBox74.Text = (read["operator2"].ToString());	
					textBox74.BackColor = Color.White;	
					textBox73.Text = (read["operator3"].ToString());	
					textBox73.BackColor = Color.White;						
					}
				else {
					textBox75.Text = "0";
					textBox74.Text = "0";
					textBox73.Text = "0";
				}
				}	
		}
		void Button10Click(object sender, EventArgs e)
		{
            SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Körös, Duna, Tisza, Maros FROM [Muszakbe] WHERE Datum = ('" + dateTimePicker1.Text +"')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			conn.Close();	
		}
	}
}
