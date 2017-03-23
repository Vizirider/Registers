/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-03
 * Time: 14:41
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
	/// Description of Nemfelvitt1.
	/// </summary>
	public partial class Nemfelvitt1 : Form
	{
		public Nemfelvitt1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//

			label7.Font = new Font(label1.Font.FontFamily, 14);
			label1.Font = new Font(label1.Font.FontFamily, 12);
			
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy.MM.dd";
			this.Button2Click(null, null);
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT [EQ], [POszam],[SOszam],[WH],[LIQ],[AKL],[BMP],[BLEND],[SD],[PF],[PACK_OFF] FROM reportday ORDER BY EQ",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;			
		
			conn.Close();
	
		}
		
		
private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
			{
			    // If the column is the department column, check the
			    // value.
			    if (this.dataGridView2.Columns[e.ColumnIndex].Name == "WH")
			    {
			        if (e.Value != null)
			        {
			            // Check for the string "rdy" in the cell.
			            string stringValue = (string)e.Value;
			            stringValue = stringValue.ToLower();
			            if ((stringValue.IndexOf("not rdy") > -1))
			            {
			                e.CellStyle.BackColor = Color.Red;
			            }
			            			        	if ((stringValue.IndexOf("in progress") > -1))
			            {
			                e.CellStyle.BackColor = Color.Yellow;
			            }
			           	else if ((stringValue.IndexOf("n/a") > -1))
			            {
			                e.CellStyle.BackColor = Color.Black;
			                e.CellStyle.ForeColor = Color.White;
			            }			
			        }
			    }
			    else if (this.dataGridView2.Columns[e.ColumnIndex].Name == "LIQ")
			    {
			        if (e.Value != null)
			        {
			            // Check for the string "rdy" in the cell.
			            string stringValue = (string)e.Value;
			            stringValue = stringValue.ToLower();
			            if ((stringValue.IndexOf("not rdy") > -1))
			            {
			                e.CellStyle.BackColor = Color.Red;
			            }
			            			        	if ((stringValue.IndexOf("in progress") > -1))
			            {
			                e.CellStyle.BackColor = Color.Yellow;
			            }
			           	else if ((stringValue.IndexOf("n/a") > -1))
			            {
			                e.CellStyle.BackColor = Color.Black;
			                e.CellStyle.ForeColor = Color.White;
			            }			
			        }
			    }
			    else if (this.dataGridView2.Columns[e.ColumnIndex].Name == "AKL")
			    {
			        if (e.Value != null)
			        {
			            // Check for the string "rdy" in the cell.
			            string stringValue = (string)e.Value;
			            stringValue = stringValue.ToLower();
			            if ((stringValue.IndexOf("not rdy") > -1))
			            {
			                e.CellStyle.BackColor = Color.Red;
			            }
			            			        	if ((stringValue.IndexOf("in progress") > -1))
			            {
			                e.CellStyle.BackColor = Color.Yellow;
			            }
			           	else if ((stringValue.IndexOf("n/a") > -1))
			            {
			                e.CellStyle.BackColor = Color.Black;
			                e.CellStyle.ForeColor = Color.White;
			            }			
			        }
			    }
			   	else if (this.dataGridView2.Columns[e.ColumnIndex].Name == "BMP")
			    {
			        if (e.Value != null)
			        {
			            // Check for the string "rdy" in the cell.
			            string stringValue = (string)e.Value;
			            stringValue = stringValue.ToLower();
			            if ((stringValue.IndexOf("not rdy") > -1))
			            {
			                e.CellStyle.BackColor = Color.Red;
			            }
			            			        	if ((stringValue.IndexOf("in progress") > -1))
			            {
			                e.CellStyle.BackColor = Color.Yellow;
			            }
			           	else if ((stringValue.IndexOf("n/a") > -1))
			            {
			                e.CellStyle.BackColor = Color.Black;
			                e.CellStyle.ForeColor = Color.White;
			            }			
			        }
			    }
			   	else if (this.dataGridView2.Columns[e.ColumnIndex].Name == "BLEND")
			    {
			        if (e.Value != null)
			        {
			            // Check for the string "rdy" in the cell.
			            string stringValue = (string)e.Value;
			            stringValue = stringValue.ToLower();
			            if ((stringValue.IndexOf("not rdy") > -1))
			            {
			                e.CellStyle.BackColor = Color.Red;
			            }
			            			        	if ((stringValue.IndexOf("in progress") > -1))
			            {
			                e.CellStyle.BackColor = Color.Yellow;
			            }
			           	else if ((stringValue.IndexOf("n/a") > -1))
			            {
			                e.CellStyle.BackColor = Color.Black;
			                e.CellStyle.ForeColor = Color.White;
			            }			
			        }
			    }
			   	else if (this.dataGridView2.Columns[e.ColumnIndex].Name == "PACK_OFF")
			    {
			        if (e.Value != null)
			        {
			            // Check for the string "rdy" in the cell.
			            string stringValue = (string)e.Value;
			            stringValue = stringValue.ToLower();
			            if ((stringValue.IndexOf("not rdy") > -1))
			            {
			                e.CellStyle.BackColor = Color.Red;
			            }
			            			        	if ((stringValue.IndexOf("in progress") > -1))
			            {
			                e.CellStyle.BackColor = Color.Yellow;
			            }
			           	else if ((stringValue.IndexOf("n/a") > -1))
			            {
			                e.CellStyle.BackColor = Color.Black;
			                e.CellStyle.ForeColor = Color.White;
			            }			
			        }
			    }
			   	else if (this.dataGridView2.Columns[e.ColumnIndex].Name == "PF")
			    {
			        if (e.Value != null)
			        {
			            // Check for the string "rdy" in the cell.
			            string stringValue = (string)e.Value;
			            stringValue = stringValue.ToLower();
			            if ((stringValue.IndexOf("not rdy") > -1))
			            {
			                e.CellStyle.BackColor = Color.Red;
			            }
			            			        	if ((stringValue.IndexOf("in progress") > -1))
			            {
			                e.CellStyle.BackColor = Color.Yellow;
			            }
			           	else if ((stringValue.IndexOf("n/a") > -1))
			            {
			                e.CellStyle.BackColor = Color.Black;
			                e.CellStyle.ForeColor = Color.White;
			            }
			
			        }
			    }
			    else if (this.dataGridView2.Columns[e.ColumnIndex].Name == "SD")
			    {
			        if (e.Value != null)
			        {
			            // Check for the string "rdy" in the cell.
			            string stringValue = (string)e.Value;
			            stringValue = stringValue.ToLower();
			            if ((stringValue.IndexOf("not rdy") > -1))
			            {
			                e.CellStyle.BackColor = Color.Red;
			            }
			            			        	if ((stringValue.IndexOf("in progress") > -1))
			            {
			                e.CellStyle.BackColor = Color.Yellow;
			            }
			        	else if ((stringValue.IndexOf("n/a") > -1))
			            {
			                e.CellStyle.BackColor = Color.Black;
			                e.CellStyle.ForeColor = Color.White;
			            }
			
			        }
			    }

			}
		
		void Button8Click(object sender, EventArgs e)
		{
		CaptureScreen();
        printDocument1.Print();	
		}
		Bitmap memoryImage;
    
		private void CaptureScreen()
	    {
	        Graphics myGraphics = this.CreateGraphics();
	        Size s = this.Size;
	        memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
	        Graphics memoryGraphics = Graphics.FromImage(memoryImage);
	        memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
	    }
			void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
			{
	        e.Graphics.DrawImage(memoryImage, 0, 0);
			}
		void DataGridView7CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		
		}
		void Button9Click(object sender, EventArgs e)
		{
			Nemfelvittarchiv1 na1 = new Nemfelvittarchiv1();
			na1.Show();
		}
		void Button10Click(object sender, EventArgs e)
		{
            SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT [Ossz] FROM [Ossznincs]",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView8.DataSource = ds.Tables[0];
			dataGridView8.AutoResizeColumns();
			string frstcol = dataGridView8.Rows[0].Cells["Ossz"].Value.ToString();
			textBox1.Text = frstcol;
			conn.Close();
			Button11Click(null,null);		
		}

		void Button11Click(object sender, EventArgs e)
		{
            SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT [Ossz] FROM [Osszkiirt]",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView9.DataSource = ds.Tables[0];
			dataGridView9.AutoResizeColumns();
			string frstcol = dataGridView9.Rows[0].Cells["Ossz"].Value.ToString();
			textBox2.Text = frstcol;
			conn.Close();		
		}

		void DateTimePicker1ValueChanged(object sender, EventArgs e)
		{
			Button17Click(null,null);
			Button16Click(null,null);
			Button15Click(null,null);
			Button14Click(null,null);
			Button13Click(null,null);
			Button12Click(null,null);
			
		}
		void Button17Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [nincsliqbe] WHERE Datum = ('" + dateTimePicker1.Text +"')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			conn.Close();

			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM nincsliqbe WHERE Datum = ('" + dateTimePicker1.Text +"')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox3.Text = result.ToString();
    		}	
		}
		void Button16Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [nincsbmpbe] WHERE Datum = ('" + dateTimePicker1.Text +"')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			conn.Close();
			
			
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM nincsbmpbe WHERE Datum = ('" + dateTimePicker1.Text +"')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox4.Text = result.ToString();
    		}	
		}
		void Button15Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [nincsblendbe] WHERE Datum = ('" + dateTimePicker1.Text +"')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView4.DataSource = ds.Tables[0];
			dataGridView4.AutoResizeColumns();
			conn.Close();
			
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM nincsblendbe WHERE Datum = ('" + dateTimePicker1.Text +"')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox5.Text = result.ToString();
    		}	
		}
		void Button14Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [nincspackbe] WHERE Datum = ('" + dateTimePicker1.Text +"')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView5.DataSource = ds.Tables[0];
			dataGridView5.AutoResizeColumns();
			conn.Close();
			
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM nincspackbe WHERE Datum = ('" + dateTimePicker1.Text +"')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox8.Text = result.ToString();
    		}	
		}
		void Button13Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [nincssdbe] WHERE Datum = ('" + dateTimePicker1.Text +"')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView6.DataSource = ds.Tables[0];
			dataGridView6.AutoResizeColumns();
			conn.Close();
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM nincssdbe WHERE Datum = ('" + dateTimePicker1.Text +"')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox6.Text = result.ToString();
    		}	
		}
		void Button12Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [nincspfbe] WHERE Datum = ('" + dateTimePicker1.Text +"')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView7.DataSource = ds.Tables[0];
			dataGridView7.AutoResizeColumns();
			conn.Close();
			using (SqlConnection con = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(POszam) FROM nincspfbe WHERE Datum = ('" + dateTimePicker1.Text +"')", con))
    		{
       	 	con.Open();
        	int result = (int)cmd.ExecuteScalar();
        	textBox7.Text = result.ToString();
    		}			
		}

		void Button20Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Shame] ORDER BY Nemfelvitt DESC",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView10.DataSource = ds.Tables[0];
			dataGridView10.AutoResizeColumns();
			conn.Close();	
		}
		void Button19Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Nemvittefel] WHERE POszam = ('" + textBox9.Text +"')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView10.DataSource = ds.Tables[0];
			dataGridView10.AutoResizeColumns();
			conn.Close();	
		}
		void TextBox10KeyUp(object sender, KeyEventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT [EQ],[POszam],[SOszam], [WH],[LIQ],[AKL],[BMP],[BLEND],[SD],[PF],[PACK_OFF],[Datum] FROM reportall WHERE POszam = ('" + textBox10.Text +"')",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView2.DataSource = ds.Tables[0];
			dataGridView2.AutoResizeColumns();	
		}
		void Button1Click(object sender, EventArgs e)
		{
			Button17Click(null,null);
			Button16Click(null,null);
			Button15Click(null,null);
			Button14Click(null,null);
			Button13Click(null,null);
			Button12Click(null,null);	
		}


	}
}
