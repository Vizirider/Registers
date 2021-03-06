﻿/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-05-17
 * Time: 09:36
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
	/// Description of warehouseout.
	/// </summary>
	/// abroad warehouse site register insert to sql table
	public partial class warehouseout : Form
	{
		public warehouseout(string mws)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			label1.Font = new Font(label1.Font.FontFamily, 12);
			button2.Font = new Font(button2.Font.FontFamily, 11);
			this.textBox5.Text = mws;
		}
		void Button2Click(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
			{
				MessageBox.Show("Imperfect register", "Message"); 
			}
			else if(textBox3.Text.Length < 10){
				MessageBox.Show("Few Batch numbers", "Message");
			}
			else
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.warehouseout (POszam, Pallets, Batch, Foil, ZMP, ZEA, ZIL, Chep, Palletcon, Correct, Every, GS1, Date, Inspecor)  VALUES 
			(@POszam, @Pallets, @Batch, @Foil, @ZMP, @ZEA, @ZIL, @Chep, @Palletcon, @Correct, @Every, @GS1, @Date, @Inspecor)",conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Pallets", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Batch", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Foil", checkBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@ZMP", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@ZEA", checkBox3.Checked));
			cmd.Parameters.Add(new SqlParameter("@ZIL", checkBox4.Checked));
			cmd.Parameters.Add(new SqlParameter("@Chep", checkBox5.Checked));
			cmd.Parameters.Add(new SqlParameter("@Palletcon", checkBox6.Checked));
			cmd.Parameters.Add(new SqlParameter("@Correct", checkBox7.Checked));
			cmd.Parameters.Add(new SqlParameter("@Every", checkBox8.Checked));
			cmd.Parameters.Add(new SqlParameter("@GS1", checkBox9.Checked));
			cmd.Parameters.Add(new SqlParameter("@Inspector", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Date", dateTimePicker1.Value.Date));
			cmd.ExecuteNonQuery();
			conn.Close();

			MessageBox.Show("Successfully add the SO check", "Üzenet"); 
			}	
		}
		void CheckBox1MouseHover(object sender, EventArgs e)
		{
			checkBox1.BackColor = Color.LightSteelBlue;
		}
		void CheckBox1MouseLeave(object sender, EventArgs e)
		{
			checkBox1.BackColor = Color.White;	
		}
		void CheckBox2MouseHover(object sender, EventArgs e)
		{
			checkBox2.BackColor = Color.LightSteelBlue;
		}
		void CheckBox2MouseLeave(object sender, EventArgs e)
		{
			checkBox2.BackColor = Color.White;	
		}
		void CheckBox3MouseHover(object sender, EventArgs e)
		{
			checkBox3.BackColor = Color.LightSteelBlue;	
		}
		void CheckBox3MouseLeave(object sender, EventArgs e)
		{
			checkBox3.BackColor = Color.White;	
		}
		void CheckBox4MouseHover(object sender, EventArgs e)
		{
			checkBox4.BackColor = Color.LightSteelBlue;	
		}
		void CheckBox4MouseLeave(object sender, EventArgs e)
		{
			checkBox4.BackColor = Color.White;	
		}
		void CheckBox5MouseHover(object sender, EventArgs e)
		{
			checkBox5.BackColor = Color.LightSteelBlue;	
		}
		void CheckBox5MouseLeave(object sender, EventArgs e)
		{
			checkBox5.BackColor = Color.White;	
		}
		void CheckBox6MouseHover(object sender, EventArgs e)
		{
			checkBox6.BackColor = Color.LightSteelBlue;	
		}
		void CheckBox6MouseLeave(object sender, EventArgs e)
		{
			checkBox6.BackColor = Color.White;	
		}
		void CheckBox7MouseHover(object sender, EventArgs e)
		{
			checkBox7.BackColor = Color.LightSteelBlue;	
		}
		void CheckBox7MouseLeave(object sender, EventArgs e)
		{
			checkBox7.BackColor = Color.White;	
		}
		void CheckBox8MouseHover(object sender, EventArgs e)
		{
			checkBox8.BackColor = Color.LightSteelBlue;	
		}
		void CheckBox8MouseLeave(object sender, EventArgs e)
		{
			checkBox8.BackColor = Color.White;	
		}
		void CheckBox9MouseHover(object sender, EventArgs e)
		{
			checkBox9.BackColor = Color.LightSteelBlue;	
		}
		void CheckBox9MouseLeave(object sender, EventArgs e)
		{
			checkBox9.BackColor = Color.White;
		}
	}
}
