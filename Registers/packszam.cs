/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-08-24
 * Time: 09:48
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
	/// Description of packszam.
	/// </summary>
	public partial class packszam : Form
	{
		public packszam(string date1, string date2)
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
	    new SqlCommand("select SUM(Tisztae) AS Tisztae, SUM(POStisztae) AS POStisztae, SUM(Kezitisztae) AS Kezitisztae, SUM(Prepordere) AS Prepordere, " +
	    	               "SUM(Szitae) AS Szitae, SUM(Szitaellazone) AS Szitaellazone, " +
	    	               "SUM(Serulese) AS Serulese, SUM(Beleszsake) AS Beleszsake, SUM(Szinhomogene) AS Szinhomogene," +
						"SUM(Beleszsakzare) AS Beleszsakzare, SUM(Packofffolye) AS Packofffolye, SUM(Idegene) AS Idegene, SUM(Vizfolye) AS Vizfolye,  " +
						"SUM(Komment) AS Komment from dbo.nemmegpackek WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        textBox1.Text = (read["Tisztae"].ToString());
			        textBox2.Text = (read["POStisztae"].ToString());	
			        textBox3.Text = (read["Kezitisztae"].ToString());
			        textBox4.Text = (read["Prepordere"].ToString());
			        textBox5.Text = (read["Szitae"].ToString());
			        textBox7.Text = (read["Szitaellazone"].ToString());				        
			        textBox8.Text = (read["Serulese"].ToString());		
			        textBox9.Text = (read["Beleszsake"].ToString());		
			        textBox10.Text = (read["Szinhomogene"].ToString());				        
			        textBox11.Text = (read["Beleszsakzare"].ToString());		
			        textBox12.Text = (read["Packofffolye"].ToString());		
			        textBox13.Text = (read["Idegene"].ToString());	
			        textBox14.Text = (read["Vizfolye"].ToString());		
			        textBox15.Text = (read["Komment"].ToString());			        
			    }
			    read.Close();
			}	
		}
	}
}
