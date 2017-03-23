/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-01-29
 * Time: 12:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Data;

namespace Liquidinster
{
	/// <summary>
	/// Description of Liquidinsert.
	/// </summary>
	public partial class Liquidinsert : Form
	{
		public Liquidinsert(string mws, string po)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.comboBox2.Text = mws;
			this.comboBox3.Text = mws;
		}
		
		void LiquidinsertLoad(object sender, EventArgs e)
		{
			label1.Font = new Font(label1.Font.FontFamily, 12);
			comboBox1.Font = new Font(comboBox1.Font.FontFamily, 12);
			const string Select = "Select Order FROM [Sheet1$]";
			OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=V:\Production\14 REGISTER\export.xlsx;Extended Properties=""Excel 12.0;HDR=YES;""");
			conn.Open();
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter(Select, conn);			
			OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			comboBox1.DataSource = ds.Tables[0];
			comboBox1.DisplayMember = "Order";
			conn.Close();
			
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=V:\Production\14 REGISTER\export.xlsx;Extended Properties=""Excel 12.0;HDR=YES;""");
			conn.Open();
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$] WHERE [Sheet1$].[Order] LIKE ('" + comboBox1.Text +"%')",conn);
			OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			string frstcol = dataGridView1.Rows[0].Cells["Material"].Value.ToString();
			string scndcol = dataGridView1.Rows[0].Cells["Material description"].Value.ToString();
			textBox1.Text = frstcol;
			textBox2.Text = scndcol;
			conn.Close();
		}
				void Combobox1KeyUp(object sender, KeyEventArgs e)
		{
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=V:\Production\14 REGISTER\export.xlsx;Extended Properties=""Excel 12.0;HDR=YES;""");
			conn.Open();
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$] WHERE [Sheet1$].[Order] LIKE ('" + comboBox1.Text +"%')",conn);
			OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			string frstcol = dataGridView1.Rows[0].Cells["Material"].Value.ToString();
			string scndcol = dataGridView1.Rows[0].Cells["Material description"].Value.ToString();
			textBox1.Text = frstcol;
			textBox2.Text = scndcol;
			conn.Close();
		}
				
					
		void Button1Click(object sender, EventArgs e)
		{
            
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data SourceV:\Production\14 REGISTER\export.xlsx;Extended Properties=""Excel 12.0;HDR=YES;""");
			conn.Open();
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$] WHERE [Sheet1$].[Order] LIKE ('" + comboBox1.Text +"%')",conn);
			OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			string frstcol = dataGridView1.Rows[0].Cells["Material"].Value.ToString();
			string scndcol = dataGridView1.Rows[0].Cells["Material description"].Value.ToString();
			textBox1.Text = frstcol;
			textBox2.Text = scndcol;
			conn.Close();
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.liquida (POszam, Anyagkod, Anyagnev, Kimerve, Felrazva, Felcimkezve, Kannaszam, Komment, Datum, Ellenorzo, Ellenorizve, Ki)  VALUES 
			(@POszam, @Anyagkod, @Anyagnev, @Kimerve, @Felrazva, @Felcimkezve, @Kannaszam, @Komment, @Datum, @Ellenorzo, @Ellenorizve, @Ki)",conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagnev", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Kimerve", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@Felrazva", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@Felcimkezve", checkBox3.Checked));
			cmd.Parameters.Add(new SqlParameter("@Kannaszam", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Komment", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Ellenorzo", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Ellenorizve", checkBox4.Checked));
			cmd.Parameters.Add(new SqlParameter("@Ki", comboBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Uledeke", checkBox7.Checked));
			cmd.Parameters.Add(new SqlParameter("@Idegene", checkBox6.Checked));
			cmd.Parameters.Add(new SqlParameter("@Megfelelohoe", checkBox5.Checked));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen hozzáadtad a PO-t", "Üzenet"); 			
		}
		void Button3Click(object sender, EventArgs e)
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("select * from dbo.liquida WHERE POszam=('" + comboBox1.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        comboBox1.Text = (read["POszam"].ToString());
			        textBox1.Text = (read["Anyagkod"].ToString());
			        textBox2.Text = (read["Anyagnev"].ToString());
			        checkBox1.Checked = (bool)read["Kimerve"];
			        checkBox2.Checked = (bool)read["Felrazva"];
			        checkBox3.Checked = (bool)read["Felcimkezve"];
			        textBox5.Text = (read["Kannaszam"].ToString());
			        textBox3.Text = (read["Komment"].ToString());
			        dateTimePicker1.Text = Convert.ToDateTime(read["Datum"]).ToString();
			        comboBox2.Text = (read["Ellenorzo"].ToString());
			        checkBox4.Checked = (bool)read["Ellenorizve"];
			        comboBox3.Text = (read["Ki"].ToString());
			        checkBox7.Checked = (bool)read["Uledeke"];
			        checkBox6.Checked = (bool)read["Idegene"];
			        checkBox5.Checked = (bool)read["Megfelelohoe"];
			    }
			    read.Close();
			}
		}
		void Button4Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.liquida set Ellenorizve = 1, Ki='" + comboBox3.Text + "' WHERE POszam LIKE ('" + comboBox1.Text +"%')",conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted a PO-t", "Üzenet");
			Button3Click(sender,e);
		}
		void ComboBox1KeyPress(object sender, KeyPressEventArgs e)
		{
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=V:\Production\14 REGISTER\export.xlsx;Extended Properties=""Excel 12.0;HDR=YES;""");
			conn.Open();
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$] WHERE [Sheet1$].[Order] LIKE ('" + comboBox1.Text +"%')",conn);
			OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			string frstcol = dataGridView1.Rows[0].Cells["Material"].Value.ToString();
			string scndcol = dataGridView1.Rows[0].Cells["Material description"].Value.ToString();
			textBox1.Text = frstcol;
			textBox2.Text = scndcol;
			conn.Close();		
		}

}
	
}


