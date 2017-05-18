/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-11-22
 * Time: 08:21
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

namespace Registers
{
	/// <summary>
	/// Description of Nemfelvittipqc.
	/// </summary>
	public partial class Nemfelvittipqc : Form
	{
		public Nemfelvittipqc()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Button1Click(null,null);
			Button2Click(null,null);
			Button3Click(null,null);
			Button4Click(null,null);
		}
		void Button1Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [liqipqc] WHERE Datum = DATEADD(day, DATEDIFF(day, 0, GETDATE()), 0) OR Datum = DATEADD(day, DATEDIFF(day, 0, GETDATE()), 0) -1 ",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();
			conn.Close();	
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [blendipqc] WHERE Datum = DATEADD(day, DATEDIFF(day, 0, GETDATE()), 0) OR Datum =  DATEADD(day, DATEDIFF(day, 0, GETDATE()), 0) -1 ",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			conn.Close();		
		}
		void Button3Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam FROM [_nincsliqip] WHERE Datum > '2016-11-22' ",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			conn.Close();	
		}
		void Button4Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT POszam FROM [_nincsblendip] WHERE Datum > '2016-11-22' ",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView5.DataSource = ds.Tables[0];
			dataGridView5.AutoResizeColumns();
			conn.Close();	
		}
	}
}
