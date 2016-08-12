/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-23
 * Time: 13:16
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
	/// Description of Warehouseread.
	/// </summary>
	public partial class Warehouseread : Form
	{
		public Warehouseread(string batch, string so)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.textBox2.Text = batch;
			this.comboBox1.Text = so;
			Button1Click(null,null);
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
	    new SqlCommand("select * from dbo.warehouse WHERE Batch LIKE ('%" +textBox2.Text +"%') AND POszam = ('" +comboBox1.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        comboBox1.Text = (read["POszam"].ToString());
			        textBox1.Text = (read["Pallets"].ToString());
			        textBox2.Text = (read["Batch"].ToString());
			        checkBox1.Checked = (bool)read["Matdep"];
			        checkBox2.Checked = (bool)read["Matcom"];
			        checkBox3.Checked = (bool)read["Labsled"];
			        checkBox4.Checked = (bool)read["Zealab"];
			        checkBox5.Checked = (bool)read["Zexlab"];
			        checkBox6.Checked = (bool)read["Corpal"];
			        checkBox7.Checked = (bool)read["Thegood"];
			        checkBox8.Checked = (bool)read["Thepall"];
			        checkBox9.Checked = (bool)read["Corrquan"];
			        textBox3.Text = (read["Quantity"].ToString());
			        checkBox10.Checked = (bool)read["Packun"];
			        checkBox11.Checked = (bool)read["Nobox"];
			        checkBox12.Checked = (bool)read["Palletli"];
			        checkBox13.Checked = (bool)read["Mocklab"];
			        if(read["Javitott"] == DBNull.Value){
			        	checkBox13.Checked = false;
			        }
			        else{
			        checkBox14.Checked = (bool)read["Javitott"];			        	
			        }
			        dateTimePicker1.Text = Convert.ToDateTime(read["Datum"]).ToString();
			        comboBox2.Text = (read["Ellenorzo"].ToString());
			    }
			    read.Close();
			}		
		}
		void Form_load(object sender, EventArgs e)
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
			if(checkBox10.Checked == false)
			{
				checkBox10.BackColor = Color.Red;
			}
			if(checkBox11.Checked == false)
			{
				checkBox11.BackColor = Color.Red;
			}
			if(checkBox12.Checked == false)
			{
				checkBox12.BackColor = Color.Red;
			}
			}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.warehouse set POszam = @POszam, Pallets = @Pallets, Batch = @Batch, Quantity = @Quantity, Matdep = @Matdep, Matcom = @Matcom, Labsled = @Labsled, Zealab = @Zealab, Zexlab = @Zexlab, Corpal = @Corpal, Thegood = @Thegood, Thepall = @Thepall,
			Corrquan = @Corrquan, Packun = @Packun, Nobox = @Nobox, Palletli = @Palletli, Mocklab = @Mocklab, Datum = @Datum, Ellenorzo = @Ellenorzo, Javitott = @Javitott 
			WHERE Batch LIKE ('%" +textBox2.Text +"%') AND POszam = ('" +comboBox1.Text +"')",conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Pallets", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Batch", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Quantity", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Matdep", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@Matcom", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@Labsled", checkBox3.Checked));
			cmd.Parameters.Add(new SqlParameter("@Zealab", checkBox4.Checked));
			cmd.Parameters.Add(new SqlParameter("@Zexlab", checkBox5.Checked));
			cmd.Parameters.Add(new SqlParameter("@Corpal", checkBox6.Checked));
			cmd.Parameters.Add(new SqlParameter("@Thegood", checkBox7.Checked));
			cmd.Parameters.Add(new SqlParameter("@Thepall", checkBox8.Checked));
			cmd.Parameters.Add(new SqlParameter("@Corrquan", checkBox9.Checked));
			cmd.Parameters.Add(new SqlParameter("@Packun", checkBox10.Checked));
			cmd.Parameters.Add(new SqlParameter("@Nobox", checkBox11.Checked));
			cmd.Parameters.Add(new SqlParameter("@Palletli", checkBox12.Checked));
			cmd.Parameters.Add(new SqlParameter("@Mocklab", checkBox13.Checked));
			cmd.Parameters.Add(new SqlParameter("@Javitott", 1));
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Ellenorzo", comboBox2.Text));

			cmd.ExecuteNonQuery();
			conn.Close();
			Button1Click(null,null);
			MessageBox.Show("Sikeresen Módosítottad a PO-t", "Üzenet");	
		}
		}
	}
