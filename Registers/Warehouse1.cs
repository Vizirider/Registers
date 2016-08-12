/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-04-08
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
using System.Linq;
using System.Data;

namespace Liquidinster
{
	/// <summary>
	/// Description of Warehouse1.
	/// </summary>
	public partial class Warehouse1 : Form
	{
		public Warehouse1(string mws)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.comboBox2.Text = mws;
		}
		void Button2Click(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
			{
				MessageBox.Show("Hiányos regiszter", "Üzenet"); 
			}
			else
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.warehouse1 (Batch, Cimketart, Chepp, Chepw, Euro, Standard, Arumeg, Givfelirat, Mennyiseg, Csomag, Raklap, Zmp, Ujrak, Alkfol, Megjegy, Datum, Ellenorzo)  VALUES 
			(@Batch, @Cimketart, @Chepp, @Chepw, @Euro, @Standard, @Arumeg, @Givfelirat, @Mennyiseg, @Csomag, @Raklap, @Zmp, @Ujrak, @Alkfol, @Megjegy, @Datum, @Ellenorzo)",conn);
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
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen hozzáadtad a Batch-et", "Üzenet");
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
			checkBox8.Checked = true;
			checkBox9.Checked = true;
			checkBox10.Checked = true;
			checkBox11.Checked = true;
			checkBox12.Checked = true;
		}
	}
}
