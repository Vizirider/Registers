/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-04-08
 * Time: 15:22
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
	/// Description of Warehouseread1.
	/// </summary>
	public partial class Warehouseread1 : Form
	{
		public Warehouseread1(string batch)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.comboBox1.Text = batch;
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
	    new SqlCommand("select * from dbo.warehouse1 WHERE Batch=('" + comboBox1.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        comboBox1.Text = (read["Batch"].ToString());
			        checkBox1.Checked = (bool)read["Cimketart"];
			        checkBox8.Checked = (bool)read["Chepp"];
			        checkBox9.Checked = (bool)read["Chepw"];
			        checkBox10.Checked = (bool)read["Euro"];
			        checkBox11.Checked = (bool)read["Standard"];
			        checkBox2.Checked = (bool)read["Arumeg"];
			        checkBox3.Checked = (bool)read["Givfelirat"];
			        textBox3.Text = (read["Mennyiseg"].ToString());			        
			        checkBox4.Checked = (bool)read["Csomag"];
			        checkBox5.Checked = (bool)read["Raklap"];
			        checkBox6.Checked = (bool)read["Zmp"];
			        checkBox12.Checked = (bool)read["Ujrak"];
			        comboBox3.Text = (read["Alkfol"].ToString());
			        textBox1.Text = (read["Megjegy"].ToString());					
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


		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.warehouse1 set Batch = @Batch, Cimketart = @Cimketart, Chepp = @Chepp, Chepw = @Chepw, Euro = @Euro, Standard = @Standard, Arumeg = @Arumeg, Givfelirat = @Givfelirat, Mennyiseg = @Mennyiseg, Csomag = @Csomag, Raklap = @Raklap, Zmp = @Zmp,
			Ujrak = @Ujrak, Alkfol = @Alkfol, Megjegy = @Megjegy, Datum = @Datum, Ellenorzo = @Ellenorzo, Javitott = @Javitott
			WHERE Batch=('" + comboBox1.Text +"')",conn);
			cmd.Parameters.Add(new SqlParameter("@Batch", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Cimketart", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@Chepp", checkBox8.Checked));
			cmd.Parameters.Add(new SqlParameter("@Chepw", checkBox9.Checked));
			cmd.Parameters.Add(new SqlParameter("@Euro", checkBox10.Checked));
			cmd.Parameters.Add(new SqlParameter("@Standard", checkBox11.Checked));
			cmd.Parameters.Add(new SqlParameter("@Arumeg", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@Givfelirat", checkBox3.Checked));
			cmd.Parameters.Add(new SqlParameter("@Mennyiseg", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomag", checkBox4.Checked));
			cmd.Parameters.Add(new SqlParameter("@Raklap", checkBox5.Checked));
			cmd.Parameters.Add(new SqlParameter("@Zmp", checkBox6.Checked));
			cmd.Parameters.Add(new SqlParameter("@Ujrak", checkBox12.Checked));
			cmd.Parameters.Add(new SqlParameter("@Alkfol", comboBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Megjegy", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Ellenorzo", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Javitott", 1));

			cmd.ExecuteNonQuery();
			conn.Close();
			Button1Click(null,null);
			MessageBox.Show("Sikeresen Módosítottad a Batchet", "Üzenet");		
		}
		
	}
}
