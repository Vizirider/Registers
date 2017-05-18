/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-02-26
 * Time: 16:23
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
	/// Description of packrcs.
	/// </summary>
	public partial class packrcso : Form
	{
		private readonly Liquidinster.MainForm frm1;
		public packrcso(string mws, string po, MainForm frm)
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
			this.comboBox1.Text = po;
			frm1 = frm;
			this.Button3Click(null, null);
		}
		void Button3Click(object sender, EventArgs e)
		{
			{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("select * from dbo.packingoffa WHERE POszam=('" + comboBox1.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        comboBox1.Text = (read["POszam"].ToString());
			        textBox1.Text = (read["Anyagkod"].ToString());
			        textBox2.Text = (read["Anyagnev"].ToString());
			        checkBox1.Checked = (bool)read["Tisztae"];
			        textBox3.Text = (read["POSszam"].ToString());
			        textBox4.Text = (read["IBCdok"].ToString());
			        checkBox10.Checked = (bool)read["POStisztae"];
			        checkBox2.Checked = (bool)read["Kezitisztae"];		
			        checkBox5.Checked = (bool)read["Szitae"];
			        checkBox11.Checked = (bool)read["Serulese"];
			        checkBox4.Checked = (bool)read["Pore"];
			        textBox7.Text = (read["Komment"].ToString());
			        dateTimePicker1.Text = Convert.ToDateTime(read["Datum"]).ToString();
			        comboBox2.Text = (read["Ellenorzo"].ToString());
			        comboBox3.Text = (read["Ki"].ToString());
			    }
			    read.Close();
			}
		}
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.packingoffa set Ellenorizve = 1, Ki='" + comboBox3.Text + "' WHERE POszam LIKE ('" + comboBox1.Text +"%')",conn);
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen ellenőrizted a PO-t", "Üzenet");
			frm1.Refresh();
						this.Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.packingoffa Set Tisztae = @Tisztae, POSszam = @POSszam, IBCdok = @IBCdok, POStisztae = @POStisztae, Kezitisztae = @Kezitisztae, 
			Szitae = @Szitae, Serulese = @Serulese, Pore = @Pore
			WHERE POszam LIKE ('" + comboBox1.Text +"%')",conn);
			cmd.Parameters.Add(new SqlParameter("@Tisztae", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@POSszam", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@IBCdok", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@POStisztae", checkBox10.Checked));
			cmd.Parameters.Add(new SqlParameter("@Kezitisztae", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@Szitae", checkBox5.Checked));
			cmd.Parameters.Add(new SqlParameter("@Serulese", checkBox11.Checked));
			cmd.Parameters.Add(new SqlParameter("@Komment", textBox7.Text));
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Pore", checkBox4.Checked));
			cmd.Parameters.Add(new SqlParameter("@Ki", comboBox3.Text));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen módosítottad a PO-t", "Üzenet"); 
		}
		void PackrcsLoad(object sender, EventArgs e)
		{
			if(checkBox1.Checked == false)
			{
				checkBox1.BackColor = Color.Red;
			}
			if(checkBox2.Checked == false)
			{
				checkBox2.BackColor = Color.Red;
			}
			if(checkBox5.Checked == false)
			{
				checkBox5.BackColor = Color.Red;
			}
			if(checkBox5.Checked == false)
			{
				checkBox5.BackColor = Color.Red;
			}
			if(checkBox10.Checked == false)
			{
				checkBox10.BackColor = Color.Red;
			}
			if(checkBox4.Checked == true)
			{
				checkBox4.BackColor = Color.Red;
			}
			if(checkBox11.Checked == true)
			{
				checkBox11.BackColor = Color.Red;
			}	
		}
	}
}
