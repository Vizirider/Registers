/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-08-24
 * Time: 08:24
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

namespace Registers
{
	/// <summary>
	/// Description of aklszam.
	/// </summary>
	public partial class aklszam : Form
	{
		public aklszam(string date1, string date2)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			dateTimePicker1.Text = date1;
			dateTimePicker2.Text = date2;
			Button1Click(null,null);
			// all akl non comform event to form
		}
		void Button1Click(object sender, EventArgs e)
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("select SUM(Kimerve) AS Kimerve, SUM(Csomomentes) AS Csomomentes, SUM(Felcimkezve) AS Felcimkezve, " +
	    	               "SUM(Komment) AS Komment from dbo.nemmegaklek WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        textBox1.Text = (read["Kimerve"].ToString());
			        textBox2.Text = (read["Csomomentes"].ToString());	
			        textBox3.Text = (read["Felcimkezve"].ToString());
			        textBox7.Text = (read["Komment"].ToString());				        
			    }
			    read.Close();
			}	
		}
	}
}
