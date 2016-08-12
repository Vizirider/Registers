/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-02-23
 * Time: 11:15
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
	/// Description of Form8.
	/// </summary>
	public partial class Form8 : Form
	{
		public Form8(string mws)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.textBox2.Text = mws;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
					const string Select = "SELECT * FROM liquidella";
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter(Select, conn);			
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
//			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
		}

		void TextBox1KeyUp(object sender, KeyEventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM liquidella WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
		}
		void Button3Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM liquidella WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
		}
		void Button1Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"insert into liquidella
    		select *
    		from liquidell t1
    		where not exists (select * from liquidella t2 where t2.POszam = t1.POszam);",conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen Frissítetted a PO-kat", "Üzenet");
			this.Close();
		}
		void Button4Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBox1.Text) || textBox1.Text.Length < 8)
			{
				MessageBox.Show("Nem megfelelő PO szám", "Figyelmeztetés");
			}
			else
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.liquidella set Ellenorizve = 1, Ellenorzo='" + textBox2.Text + "' WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted a PO-t", "Üzenet");
			Button3Click(sender,e);
			}
		}

	}
}
