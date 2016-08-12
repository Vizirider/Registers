/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-07
 * Time: 15:43
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
	/// Description of nagykevero.
	/// </summary>
	public partial class nagykevero : Form
	{
		public nagykevero()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Button1Click(null,null);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
				SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Blendertime",@"Data Source=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
		DataSet ds = new DataSet();
		da.Fill(ds);
		dataGridView1.DataSource = ds.Tables[0];	
			
		// Transposed database
		
		DataTable dt = new DataTable();

		for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
		{
		DataColumn dc = new DataColumn();
		dt.Columns.Add(dc);
		}
		for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
		{
		DataRow dr = dt.NewRow();
		for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
		{
		dr[j] = ds.Tables[0].Rows[j][i];
		
		}
		dt.Rows.Add(dr);
		dataGridView2.DataSource = dt;
		dataGridView2.ColumnHeadersVisible = false;
		}
		
		for (int i = 0; i < dt.Rows.Count; i++)
		{
		dataGridView2.Rows[i].HeaderCell.Value = ds.Tables[0].Columns[i].ColumnName;
		}
		}
	}
}
