/*
 * Created by SharpDevelop.
 * User: vizir
 * Date: 2016-02-26
 * Time: 14:17
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
	/// Description of bmpr.
	/// </summary>
	public partial class bmpr : Form
	{
		private readonly Liquidinster.MainForm frm1;	
		public bmpr(string mws, string po, MainForm frm)
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
			
			// bmp register with instances (po, mws number)
			
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
			        checkBox1.Checked = (bool)read["IBCtisztae"];
			        textBox3.Text = (read["IBCszam"].ToString());
			        textBox4.Text = (read["LastIBCszam"].ToString());
			        checkBox2.Checked = (bool)read["Allomastisztae"];
			        checkBox3.Checked = (bool)read["Elese"];
			        checkBox4.Checked = (bool)read["Kimerteke"];
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
			   		if(read["sopick"] == DBNull.Value){
			        	checkBox9.Checked = false;			        	
			        }
			        else{
			        checkBox9.Checked = (bool)read["sopick"];			        	
			        }
			    }
			    read.Close();
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
			SqlCommand cmd = new SqlCommand(@"Update dbo.bmpa set POszam = @POszam, Anyagkod = @Anyagkod, Anyagnev = @Anyagnev, IBCtisztae = @IBCtisztae, IBCszam = @IBCszam, LastIBCszam = @LastIBCszam, Allomastisztae = @Allomastisztae, Elese = @Elese, Kimerteke = @Kimerteke, AKLzsak = @AKLzsak, Csomomentese = @Csomomentese, Komment = @Komment, Datum = @Datum, Ellenorzo = @Ellenorzo,  Ki = @Ki, 
			Soszam = @Soszam, Alapanyage = @Alapanyage, Bonthatoe = @Bonthatoe, Idegene = @Idegene, sopick = @sopick WHERE POszam = ('" + comboBox1.Text +"')",conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagnev", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@IBCtisztae", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@IBCszam", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@LastIBCszam", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Allomastisztae", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@Elese", checkBox3.Checked));
			cmd.Parameters.Add(new SqlParameter("@Kimerteke", checkBox4.Checked));
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
			cmd.Parameters.Add(new SqlParameter("@sopick", checkBox9.Checked));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen módosítottad a PO-t", "Üzenet"); 
		}
		void BmprLoad(object sender, EventArgs e)
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
			if(checkBox8.Checked == true)
			{
				checkBox8.BackColor = Color.Red;
			}	
			if(checkBox4.Checked == false)
			{
				checkBox4.BackColor = Color.Red;
			}
			if(checkBox9.Checked == false)
			{
				checkBox9.BackColor = Color.Red;
			}

		}
	}
}
