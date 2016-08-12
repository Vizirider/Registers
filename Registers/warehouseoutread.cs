/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-05-17
 * Time: 12:07
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
	/// Description of warehouseoutread.
	/// </summary>
	public partial class warehouseoutread : Form
	{
		public warehouseoutread(string batch)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.textBox3.Text = batch;
			Button1Click(null,null);
			label1.Font = new Font(label1.Font.FontFamily, 12);
			button7.Font = new Font(button7.Font.FontFamily, 11);
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
		void Button1Click(object sender, EventArgs e)
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("select * from dbo.warehouseout WHERE Batch=('" + textBox3.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        textBox1.Text = (read["POszam"].ToString());
			        textBox2.Text = (read["Pallets"].ToString());
			        textBox3.Text = (read["Batch"].ToString());
			        textBox5.Text = (read["Inspector"].ToString());
			        checkBox1.Checked = (bool)read["Foil"];
			        checkBox2.Checked = (bool)read["ZMP"];
			        checkBox3.Checked = (bool)read["ZEA"];
			        checkBox4.Checked = (bool)read["ZIL"];
			        checkBox5.Checked = (bool)read["Chep"];
			        checkBox6.Checked = (bool)read["Palletcon"];
			        checkBox7.Checked = (bool)read["Correct"];	        
			        checkBox8.Checked = (bool)read["Every"];
			        checkBox9.Checked = (bool)read["GS1"];					
			        dateTimePicker1.Text = Convert.ToDateTime(read["Date"]).ToString();
			    }
			    read.Close();
			}		
		}
		void WarehouseoutreadLoad(object sender, EventArgs e)
		{
			if(checkBox1.Checked == false)
			{
				checkBox1.BackColor = Color.Red;
			}
			if(checkBox2.Checked == false)
			{
				checkBox2.BackColor = Color.Red;
			}
			if(checkBox3.Checked == false)
			{
				checkBox3.BackColor = Color.Red;
			}
			if(checkBox4.Checked == false)
			{
				checkBox4.BackColor = Color.Red;
			}
			if(checkBox5.Checked == false)
			{
				checkBox5.BackColor = Color.Red;
			}
			if(checkBox6.Checked == false)
			{
				checkBox6.BackColor = Color.Red;
			}
			if(checkBox7.Checked == false)
			{
				checkBox7.BackColor = Color.Red;
			}
			if(checkBox8.Checked == false)
			{
				checkBox8.BackColor = Color.Red;
			}
			if(checkBox9.Checked == false)
			{
				checkBox9.BackColor = Color.Red;
			}				
		}

	}
}
