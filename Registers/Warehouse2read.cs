/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-04-08
 * Time: 15:56
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
	/// Description of Warehouse2read.
	/// </summary>
	public partial class Warehouse2read : Form
	{
		public Warehouse2read(string hu)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.textBox1.Text = hu;
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
	    new SqlCommand("select * from dbo.warehouse2 WHERE Hu=('" + textBox1.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        textBox1.Text = (read["Hu"].ToString());
			        textBox2.Text = (read["Batch"].ToString());	
			        comboBox1.Text = (read["Material"].ToString());	
			        textBox3.Text = (read["Edeny"].ToString());	
			        textBox4.Text = (read["Edenyu"].ToString());	
			        checkBox1.Checked = (bool)read["Kanal"];
			        checkBox2.Checked = (bool)read["Kidobva"];					
			        dateTimePicker1.Text = Convert.ToDateTime(read["Datum"]).ToString();
			        comboBox2.Text = (read["Ellenorzo"].ToString());
			        if(read["Javitott"] == DBNull.Value){
			        	checkBox14.Checked = false;
			        }
			        else{
			        checkBox14.Checked = (bool)read["Javitott"];			        	
			        }
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
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.warehouse2 set Hu = @Hu, Batch = @Batch, Material = @Material, Edeny = @Edeny,
			Edenyu = @Edenyu, Kanal = @Kanal, Kidobva = @Kidobva, Datum = @Datum, Ellenorzo = @Ellenorzo, Javitott = @Javitott
			WHERE Hu=('" + textBox1.Text +"')",conn);
			cmd.Parameters.Add(new SqlParameter("@Hu", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Kanal", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@Kidobva", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@Batch", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Edeny", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Edenyu", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Material", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Ellenorzo", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Javitott", 1));

			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen Módosítottad a Batchet", "Üzenet");	
			Button1Click(null,null);			
		}
	}
}
