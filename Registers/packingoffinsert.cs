/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-02-17
 * Time: 15:44
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
	/// Description of packingoffinsert.
	/// </summary>
	public partial class packingoffinsert : Form
	{
		public packingoffinsert(string mws)
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
		void packingoffinsertLoad(object sender, EventArgs e)
		{
			label1.Font = new Font(label1.Font.FontFamily, 12);
			comboBox1.Font = new Font(comboBox1.Font.FontFamily, 12);
			const string Select = "Select Order FROM [Sheet1$]";
			OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=V:\Common (Don't share confidential docs here)\000\export.xlsx;Extended Properties=""Excel 12.0;HDR=YES;""");
			conn.Open();
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter(Select, conn);			
			OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			comboBox1.DataSource = ds.Tables[0];
			comboBox1.DisplayMember = "Order";
			conn.Close();	
		}
		void Button1Click(object sender, EventArgs e)
		{
			OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=V:\Common (Don't share confidential docs here)\000\export.xlsx;Extended Properties=""Excel 12.0;HDR=YES;""");
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
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.packingoffa (POszam, Anyagkod, Anyagnev, Tisztae, POSszam, IBCdok, POStisztae, Kezitisztae, Szitae, Serulese, Pore, Komment, Datum, Ellenorzo, Ellenorizve, Ki)  VALUES 
			(@POszam, @Anyagkod, @Anyagnev, @Tisztae, @POSszam, @IBCdok, @POStisztae, @Kezitisztae, @Szitae, @Serulese, @Pore, @Komment, @Datum, @Ellenorzo, @Ellenorizve, @Ki, @Prepordere, @Szitaellazone,
			 @Beleszsake, @Mintaedenyszame, @Szinhomogene, @Beleszsakzare, @Packofffolye, @Mintaedenyszamu, @Idegene, @Vizfolye)",conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagnev", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Tisztae", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@POSszam", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@IBCdok", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@POStisztae", checkBox10.Checked));
			cmd.Parameters.Add(new SqlParameter("@Kezitisztae", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@Szitae", checkBox5.Checked));
			cmd.Parameters.Add(new SqlParameter("@Serulese", checkBox11.Checked));
			cmd.Parameters.Add(new SqlParameter("@Pore", checkBox3.Checked));
			cmd.Parameters.Add(new SqlParameter("@Komment", textBox7.Text));
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Ellenorzo", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Ellenorizve", checkBox4.Checked));
			cmd.Parameters.Add(new SqlParameter("@Ki", comboBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Mintaedenyszame", textBox6.Text));
		    cmd.Parameters.Add(new SqlParameter("@Mintaedenyszamu", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Prepordere", checkBox7.Checked));
			cmd.Parameters.Add(new SqlParameter("@Szitaellazone", checkBox12.Checked));
			cmd.Parameters.Add(new SqlParameter("@Beleszsake", checkBox9.Checked));
			cmd.Parameters.Add(new SqlParameter("@Szinhomogene", checkBox8.Checked));
			cmd.Parameters.Add(new SqlParameter("@Beleszsakzare", checkBox6.Checked));
			cmd.Parameters.Add(new SqlParameter("@Packofffolye", checkBox15.Checked));
			cmd.Parameters.Add(new SqlParameter("@Idegene", checkBox14.Checked));
			cmd.Parameters.Add(new SqlParameter("@Vizfolye", checkBox13.Checked));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen hozzáadtad a PO-t", "Üzenet"); 
		}
		void ComboBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=V:\Common (Don't share confidential docs here)\000\export.xlsx;Extended Properties=""Excel 12.0;HDR=YES;""");
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
		void ComboBox1KeyUp(object sender, KeyEventArgs e)
		{
			OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=V:\Common (Don't share confidential docs here)\000\export.xlsx;Extended Properties=""Excel 12.0;HDR=YES;""");
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
		void ComboBox1KeyDown(object sender, KeyEventArgs e)
		{
			OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=V:\Common (Don't share confidential docs here)\000\export.xlsx;Extended Properties=""Excel 12.0;HDR=YES;""");
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
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
	
		}
	
		}
}

