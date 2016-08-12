/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-02-24
 * Time: 15:11
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
	/// Description of Nemfelvitt.
	/// </summary>
	public partial class Nemfelvitt : Form
	{
		public Nemfelvitt()
		{
			//		
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.Button1Click(null, null);
			this.Button3Click(null, null);
			this.Button4Click(null, null);
			this.Button5Click(null, null);
			this.Button6Click(null, null);
			this.Button9Click(null, null);
			label7.Font = new Font(label1.Font.FontFamily, 14);
			label1.Font = new Font(label1.Font.FontFamily, 12);
			
									
		}

		void Button2Click(object sender, EventArgs e)
		{
			OleDbConnection  conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=V:\Common (Don't share confidential docs here)\adminregisters\registers.accdb;
			Persist Security Info=False;");
			conn.Open();
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT [EQ],[POszam],[SOszam],[WH],[LIQ],[AKL],[BMP],[BLEND],[PACK_OFF] FROM [pepsi]",conn);
			OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
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
			
			        }
			    }
			}
		
		void Button1Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [_nincsliqbe]",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AutoResizeColumns();
			conn.Close();
		}
		void Button3Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [_nincsaklba]",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView3.DataSource = ds.Tables[0];
			dataGridView3.AutoResizeColumns();
			conn.Close();
		}
		void Button4Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [_nincsbmpbe]",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView4.DataSource = ds.Tables[0];
			dataGridView4.AutoResizeColumns();
			conn.Close();	
		}
		void Button5Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [_nincsblendbe]",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView5.DataSource = ds.Tables[0];
			dataGridView5.AutoResizeColumns();
			conn.Close();
		}
		void Button6Click(object sender, EventArgs e)
		{
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [_nincspackbe]",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView6.DataSource = ds.Tables[0];
			dataGridView6.AutoResizeColumns();
			conn.Close();	
		}
		void Button7Click(object sender, EventArgs e)
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
		void Button8Click(object sender, EventArgs e)
		{
			Nemfelvittarchiv na = new Nemfelvittarchiv();
			na.Show();
		}
		void Button9Click(object sender, EventArgs e){
			SqlConnection  conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [_nincswhba]",conn);
			SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView7.DataSource = ds.Tables[0];
			dataGridView7.AutoResizeColumns();
			conn.Close();		
		}

		
	}
}
