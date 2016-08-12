/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-01-21
 * Time: 12:47
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

namespace Liquidinster
{
	/// <summary>
	/// Description of Form6.
	/// </summary>
	public partial class Form6 : Form
	{
		public Form6(string mws)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.textBox2.Text = mws;
			const string Select = "SELECT * FROM blendinga";
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter(Select, conn);			
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
//			dataGridView1.ReadOnly = true;
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button9Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM blendinga WHERE POszam LIKE ('" + textBox3.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
		}
		void Button7Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"insert into blendinga
    		select *
    		from blending t1
    		where not exists (select * from blendinga t2 where t2.POszam = t1.POszam);",conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen Frissítetted a PO-kat", "Üzenet");
			this.Close();
		}
		void TextBox3KeyUp(object sender, KeyEventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM blendinga WHERE POszam LIKE ('" + textBox3.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
		}
		void Button4Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBox3.Text) || textBox3.Text.Length < 8)
			{
				MessageBox.Show("Nem megfelelő PO szám", "Figyelmeztetés");
			}
			else
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.blendinga set Ellenorizve = 1, Ki='" + textBox2.Text + "' WHERE POszam LIKE ('" + textBox3.Text +"%')",conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted a PO-t", "Üzenet");
			Button9Click(sender,e);
			}
		}
	}
}
