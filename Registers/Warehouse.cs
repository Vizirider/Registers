/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-03-23
 * Time: 12:37
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
	/// Description of Warehouse.
	/// </summary>
	///  Warehouse pepsico register with insert sql table
	public partial class Warehouse : Form
	{
		public Warehouse(string mws)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.comboBox2.Text = mws;
		}
		void Button2Click(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
			{
				MessageBox.Show("Hiányos regiszter", "Üzenet"); 
			}
			else if(textBox2.Text.Length < 10){
				MessageBox.Show("Kevés Batch szám", "Üzenet");
			}
			else
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.warehouse (POszam, Pallets, Batch, Matdep, Matcom, Labsled, Zealab, Zexlab, Thegood, Thepall, Corrquan, Quantity, Packun, Nobox, Palletli, Zmp, Mocklab, Datum, Ellenorzo, Givfelirat, Givfolia, Chepp, Chepw, Euro, Standard, Megjegy)  VALUES 
			(@POszam, @Pallets, @Batch, @Matdep, @Matcom, @Labsled, @Zealab, @Zexlab, @Thegood, @Thepall, @Corrquan, @Quantity, @Packun, @Nobox, @Palletli, @Zmp, @Mocklab, @Datum, @Ellenorzo, @Givfelirat, @Givfolia, @Chepp, @Chepw, @Euro, @Standard, @Megjegy)",conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Pallets", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Batch", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Matdep", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@Matcom", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@Labsled", checkBox3.Checked));
			cmd.Parameters.Add(new SqlParameter("@Zealab", checkBox4.Checked));
			cmd.Parameters.Add(new SqlParameter("@Zexlab", checkBox5.Checked));
			cmd.Parameters.Add(new SqlParameter("@Thegood", checkBox6.Checked));
			cmd.Parameters.Add(new SqlParameter("@Thepall", checkBox7.Checked));
			cmd.Parameters.Add(new SqlParameter("@Corrquan", checkBox8.Checked));
			cmd.Parameters.Add(new SqlParameter("@Packun", checkBox9.Checked));
			cmd.Parameters.Add(new SqlParameter("@Quantity", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Nobox", checkBox10.Checked));
			cmd.Parameters.Add(new SqlParameter("@Palletli", checkBox11.Checked));
			cmd.Parameters.Add(new SqlParameter("@Zmp", checkBox12.Checked));
			cmd.Parameters.Add(new SqlParameter("@Mocklab", checkBox13.Checked));
			cmd.Parameters.Add(new SqlParameter("@Givfelirat", checkBox15.Checked));
			cmd.Parameters.Add(new SqlParameter("@Givfolia", checkBox14.Checked));
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Ellenorzo", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Chepp", checkBox19.Checked));
			cmd.Parameters.Add(new SqlParameter("@Chepw", checkBox18.Checked));
			cmd.Parameters.Add(new SqlParameter("@Euro", checkBox17.Checked));
			cmd.Parameters.Add(new SqlParameter("@Standard", checkBox16.Checked));
			cmd.Parameters.Add(new SqlParameter("@Megjegy", textBox4.Text));
			cmd.ExecuteNonQuery();
			conn.Close();

			MessageBox.Show("Sikeresen hozzáadtad a PO-t", "Üzenet"); 
			}
		}
		void Form_load(object sender, EventArgs e)
		{
			checkBox1.Checked = true;
			checkBox2.Checked = true;
			checkBox3.Checked = true;
			checkBox4.Checked = true;
			checkBox5.Checked = true;
			checkBox6.Checked = true;
			checkBox7.Checked = true;
			checkBox8.Checked = true;
			checkBox9.Checked = true;
			checkBox10.Checked = true;
			checkBox11.Checked = true;
			checkBox12.Checked = true;
			checkBox13.Checked = true;
			checkBox14.Checked = true;
			checkBox15.Checked = true;
		}
	}
}
