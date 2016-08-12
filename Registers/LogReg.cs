/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-05-04
 * Time: 09:37
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

namespace Liquidinster
{
	/// <summary>
	/// Description of LogReg.
	/// </summary>
	public partial class LogReg : Form
	{
		public LogReg()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Button1Click(null,null);
		}
		void Button1Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			DataSet ds = new DataSet();	
			SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT * FROM LoginReg ORDER BY Date DESC", conn);
			dataAdapter1.Fill(ds);	
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			dataGridView1.AutoResizeColumnHeadersHeight();		
		}
	}
}
