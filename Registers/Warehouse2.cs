/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-04-08
 * Time: 15:46
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
	/// Description of Warehouse2.
	/// </summary>
	public partial class Warehouse2 : Form
	{
		public Warehouse2(string mws)
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
		void Button2Click(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
			{
				MessageBox.Show("Hiányos regiszter", "Üzenet"); 
			}
			else
			{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Insert into dbo.warehouse2 (Hu, Batch, Material, Edeny, Edenyu, Kanal, Kidobva, Datum, Ellenorzo, Mintazo,Log)  VALUES 
			(@Hu, @Batch, @Material, @Edeny, @Edenyu, @Kanal, @Kidobva, @Datum, @Ellenorzo, @Mintazo, @Log)",conn);
			cmd.Parameters.Add(new SqlParameter("@Hu", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Batch", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Material", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Edeny", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Edenyu", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Kanal", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@Kidobva", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Ellenorzo", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Mintazo", comboBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Log", DateTime.Now));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen hozzáadtad a HU-t", "Üzenet"); 	
			}
		}
		void Form_load(object sender, EventArgs e)
		{
			checkBox1.Checked = true;
			checkBox2.Checked = true;
		}
	}
}
