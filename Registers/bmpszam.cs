/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-08-24
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

namespace Registers
{
	/// <summary>
	/// Description of bmpszam.
	/// </summary>
	public partial class bmpszam : Form
	{
		public bmpszam(string date1, string date2)
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
		}
		void Button1Click(object sender, EventArgs e)
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("select SUM(IBCtisztae) AS IBCtisztae, SUM(Allomastisztae) AS Allomastisztae, SUM(Elese) AS Elese, SUM(Kimerteke) AS Kimerteke, " +
	    	               "SUM(Csomomentese) AS Csomomentese, SUM(Alapanyage) AS Alapanyage,  SUM(Bonthatoe) AS Bonthatoe, " +
	    	               "SUM(Idegene) AS Idegene, SUM(Komment) AS Komment from dbo.nemmegbmpk WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        textBox1.Text = (read["IBCtisztae"].ToString());
			        textBox2.Text = (read["Allomastisztae"].ToString());	
			        textBox3.Text = (read["Elese"].ToString());
			        textBox4.Text = (read["Kimerteke"].ToString());
			        textBox5.Text = (read["Csomomentese"].ToString());
			        textBox6.Text = (read["Alapanyage"].ToString());
			        textBox7.Text = (read["Bonthatoe"].ToString());				        
			        textBox8.Text = (read["Idegene"].ToString());		
			        textBox9.Text = (read["Komment"].ToString());			        
			    }
			    read.Close();
			}			
		}
	}
}
