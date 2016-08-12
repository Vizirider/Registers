/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-02-23
 * Time: 12:59
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
	/// Description of Form10.
	/// </summary>
	public partial class Form10 : Form
	{
		private String connectionString = null;
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private SqlCommandBuilder sqlCommandBuilder = null;
        private DataTable dataTable = null;
        private BindingSource bindingSource = null;
        private String selectQueryString = null;
		public Form10(string mws)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.textBox2.Text = mws;			

		}

		void TextBox1KeyUp(object sender, KeyEventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM packella WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
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
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM packella WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
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
			SqlCommand cmd = new SqlCommand(@"insert into packella
    		select *
    		from packell t1
    		where not exists (select * from packella t2 where t2.POszam = t1.POszam);",conn);
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
			SqlCommand cmd = new SqlCommand(@"Update dbo.packella set Ellenorizve = 1, Ellenorzo='" + textBox2.Text + "' WHERE POszam LIKE ('" + textBox1.Text +"%')",conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted a PO-t", "Üzenet");
			Button3Click(sender,e);
			}			
		}
		void Button2Click(object sender, EventArgs e)
		{
            try
            {
                sqlDataAdapter.Update(dataTable);
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }		
		}

		private void packload(object sender, EventArgs e)
		{
			connectionString = "server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI";
            sqlConnection = new SqlConnection(connectionString);
           	selectQueryString = "SELECT * FROM packella";

            sqlConnection.Open();

            dataGridView1.DataSource = bindingSource;            
           	
            sqlDataAdapter = new SqlDataAdapter(selectQueryString, sqlConnection);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
		}
	}
}
