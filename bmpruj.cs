/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2017-09-23
 * Time: 16:42
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

namespace Registers
{
	/// <summary>
	/// Description of bmpruj.
	/// </summary>
	public partial class bmpruj : Form
	{
		private readonly Liquidinster.MainForm frm1;
		public bmpruj(string mws, string po, Liquidinster.MainForm frm)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.comboBox2.Text = mws;
			this.comboBox3.Text = mws;
			this.comboBox1.Text = po;
			frm1 = frm;
			this.Button3Click(null, null);
		}
		void Button3Click(object sender, EventArgs e)
		{
		using (SqlConnection connection =  new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI"))
		{
	    SqlCommand command =
	    new SqlCommand("select * from dbo.bmpa WHERE POszam=('" + comboBox1.Text +"')", connection);
	    connection.Open();
	
	    SqlDataReader read= command.ExecuteReader();

			    while (read.Read())
			    {
			        comboBox1.Text = (read["POszam"].ToString());
			        textBox1.Text = (read["Anyagkod"].ToString());
			        textBox2.Text = (read["Anyagnev"].ToString());
			        textBox3.Text = (read["IBCszam"].ToString());
			        textBox4.Text = (read["LastIBCszam"].ToString());
			        checkBox2.Checked = (bool)read["Allomastisztae"];
			        textBox5.Text = (read["AKLzsak"].ToString());
			        checkBox5.Checked = (bool)read["Csomomentese"];
			        textBox6.Text = (read["Komment"].ToString());
			        dateTimePicker1.Text = Convert.ToDateTime(read["Datum"]).ToString();
			        comboBox2.Text = (read["Ellenorzo"].ToString());
			        comboBox3.Text = (read["Ki"].ToString());
			        checkBox6.Checked = (bool)read["Alapanyage"];
			        checkBox7.Checked = (bool)read["Bonthatoe"];
			        checkBox8.Checked = (bool)read["Idegene"];
			        textBox7.Text = (read["Soszam"].ToString());
			        textBox6.Text = (read["Allomastisztaenon"].ToString());
			        textBox8.Text = (read["Csomomentesenon"].ToString());
			        textBox9.Text = (read["Alapanyagenon"].ToString());
			        textBox10.Text = (read["Bonthatoenon"].ToString());
			        textBox11.Text = (read["Idegenenon"].ToString());
			    }
			    read.Close();
			}	
		}
		void BmprujLoad(object sender, EventArgs e)
		{

			if(checkBox2.Checked == false)
			{
				checkBox2.BackColor = Color.Red;
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
		}
		void Button2Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("server=gmacsm0001dp;database=Production_test;Integrated Security=SSPI");
			conn.Open();
			SqlCommand cmd = new SqlCommand(@"Update dbo.bmpa set Ellenorizve = 1, Ki='" + comboBox3.Text + "' WHERE POszam LIKE ('" + comboBox1.Text +"%')",conn);
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
			SqlCommand cmd = new SqlCommand(@"Update dbo.bmpa set POszam = @POszam, Anyagkod = @Anyagkod, Anyagnev = @Anyagnev,IBCszam = @IBCszam, LastIBCszam = @LastIBCszam, Allomastisztae = @Allomastisztae, AKLzsak = @AKLzsak, Csomomentese = @Csomomentese, Komment = @Komment, Datum = @Datum, Ellenorzo = @Ellenorzo,  Ki = @Ki, 
			Soszam = @Soszam, Alapanyage = @Alapanyage, Bonthatoe = @Bonthatoe, Idegene = @Idegene, Allomastisztaenon = @Allomastisztaenon,
			Csomomentesenon = @Csomomentesenon, Alapanyagenon = @Alapanyagenon, Bonthatoenon = @Bonthatoenon, Idegenenon = @Idegenenon WHERE POszam = ('" + comboBox1.Text +"')",conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagnev", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@IBCszam", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@LastIBCszam", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Allomastisztae", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@AKLzsak", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomomentese", checkBox5.Checked));
			cmd.Parameters.Add(new SqlParameter("@Komment", textBox6.Text));
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Ellenorzo", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Ki", comboBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@Soszam", textBox7.Text));
			cmd.Parameters.Add(new SqlParameter("@Alapanyage", checkBox6.Checked));
			cmd.Parameters.Add(new SqlParameter("@Bonthatoe", checkBox7.Checked));
			cmd.Parameters.Add(new SqlParameter("@Idegene", checkBox8.Checked));
			cmd.Parameters.Add(new SqlParameter("@Allomastisztaenon", textBox6.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomomentesenon", textBox8.Text));
			cmd.Parameters.Add(new SqlParameter("@Alapanyagenon", textBox9.Text));
			cmd.Parameters.Add(new SqlParameter("@Bonthatoenon", textBox10.Text));
			cmd.Parameters.Add(new SqlParameter("@Idegenenon", textBox11.Text));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen módosítottad a PO-t", "Üzenet"); 	
		}
	}
}
