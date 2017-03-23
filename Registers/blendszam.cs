/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-08-24
 * Time: 09:24
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
	/// Description of blendszam.
	/// </summary>
	public partial class blendszam : Form
	{
		public blendszam(string date1, string date2)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			// blender non comfort event to form
			
			dateTimePicker1.Text = date1;
			dateTimePicker2.Text = date2;
			Button1Click(null,null);
		}
		void Button1Click(object sender, EventArgs e)
		{
			// non comfort sql table to form
			
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("select SUM(Tisztae) AS Tisztae, SUM(Kitoltvee) AS Kitoltvee, SUM(IBCkiurulte) AS IBCkiurulte, SUM(Felrazvae) AS Felrazvae, " +
	    	               "SUM(Felrazvahoe) AS Felrazvahoe, SUM(Jerrycane) AS Jerrycane,  SUM(Urese) AS Urese, " +
	    	               "SUM(Automatae) AS Automatae, SUM(Szivarogepor) AS Szivarogepor, SUM(Szivaroge) AS Szivaroge, SUM(Muszakie) AS Muszakie, " +
						"SUM(Idegene) AS Idegene, SUM(Komment) AS Komment " +
						"from dbo.nemmegblendek WHERE Datum BETWEEN ('" + dateTimePicker1.Text +"') AND ('" + dateTimePicker2.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        textBox1.Text = (read["Tisztae"].ToString());
			        textBox2.Text = (read["Kitoltvee"].ToString());	
			        textBox3.Text = (read["IBCkiurulte"].ToString());
			        textBox4.Text = (read["Felrazvae"].ToString());
			        textBox5.Text = (read["Felrazvahoe"].ToString());
			        textBox6.Text = (read["Jerrycane"].ToString());
			        textBox7.Text = (read["Urese"].ToString());				        
			        textBox8.Text = (read["Automatae"].ToString());		
			        textBox9.Text = (read["Szivarogepor"].ToString());		
			        textBox10.Text = (read["Szivaroge"].ToString());				        
			        textBox11.Text = (read["Muszakie"].ToString());		
			        textBox12.Text = (read["Idegene"].ToString());		
			        textBox13.Text = (read["Komment"].ToString());				        				        
			    }
			    read.Close();
			}		
		}
	}
}
