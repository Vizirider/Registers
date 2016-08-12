/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2015-12-07
 * Time: 09:06
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
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		public Form4(string mws)
		{			
			InitializeComponent();
			this.textBox4.Text = mws;
			const string Select = "SELECT * FROM akla";
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter(Select, conn);			
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
//			dataGridView1.ReadOnly = true;
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();	

		}
		void Button9Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM akla WHERE POszam LIKE ('" + textBox3.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
		}
		void TextBox3KeyUp(object sender, KeyEventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM akla WHERE POszam LIKE ('" + textBox3.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
		}
		void Button7Click(object sender, EventArgs e)
		{
			InitializeComponent();
			
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"insert into akla
    		select *
    		from akl t1
    		where not exists (select * from akla t2 where t2.POszam = t1.POszam);",conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen Frissítetted a PO-kat", "Üzenet");
			this.Close();
		}
		void Button10Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(textBox3.Text) || textBox3.Text.Length < 8)
			{
				MessageBox.Show("Nem megfelelő PO szám", "Figyelmeztetés");
			}
			else
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.akla set Ellenorizve = 1, Ki='" + textBox4.Text + "' WHERE POszam LIKE ('" + textBox3.Text +"%')",conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted a PO-t", "Üzenet");
			Button9Click(sender,e);
			}
		}

	}
}
