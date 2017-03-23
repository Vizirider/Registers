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
	/// Description of Form1.
	/// </summary>
	/// liquid register display like datagridview
	public partial class Form1 : Form
	{
		string id;
		int id1;
		
		SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
		
		private void dataGridView1_CellvalueChanged(object sender, DataGridViewCellEventArgs e){
		
			id = dataGridView1.Rows[e.RowIndex].Cells["POszam"].Value.ToString();
			
			if(id == "")
			{
				id1 = 0;
			}
			else 
			{
				id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["POszam"].Value.ToString());
			}
			if(id1 == 0)
			{
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "insert into liquida values ('" + dataGridView1.Rows[e.RowIndex].Cells["Ellenorizve"].Value.ToString() + "','" + dataGridView1.Rows[e.RowIndex].Cells["Ki"].Value.ToString() + "')";
			}
			else
			{
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "update liquida set Ellenorizve='" + dataGridView1.Rows[e.RowIndex].Cells["Ellenorizve"].Value.ToString() + "', Ki=''" + dataGridView1.Rows[e.RowIndex].Cells["Ki"].Value.ToString() + "'WHERE POszam=" + id1 + "";
			}
		}
		
		public Form1( string mws)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			// 
			InitializeComponent();
			
			this.textBox2.Text = mws;
			
			const string Select = "SELECT * FROM liquida";
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter(Select, conn);			
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.ReadOnly = false;
			dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM liquida WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataAdapter.Update(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			
			
		}

		void TextBox1KeyUp(object sender, KeyEventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM liquida WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
		}
		void Button3Click(object sender, EventArgs e)
		{
		InitializeComponent();
			
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"insert into liquida
    		select *
    		from liquid t1
    		where not exists (select * from liquida t2 where t2.POszam = t1.POszam);",conn);
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
			SqlCommand cmd = new SqlCommand(@"Update dbo.liquida set Ellenorizve = 1, Ki='" + textBox2.Text + "' WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted a PO-t", "Üzenet");
			Button1Click(sender,e);
			}


		}

		

	}
}
