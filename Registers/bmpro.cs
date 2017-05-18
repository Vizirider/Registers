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
	public partial class bmpro : Form
	{
		private readonly Liquidinster.MainForm frm1;
		public bmpro(string mws, string po, MainForm frm)
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
			        checkBox5.Checked = (bool)read["Kimerteke"];
			        checkBox6.Checked = (bool)read["MegfeleloIBCe"];
			        textBox5.Text = (read["AKLzsak"].ToString());
			        checkBox7.Checked = (bool)read["Csomomentese"];
			        textBox6.Text = (read["Komment"].ToString());
			        dateTimePicker1.Text = Convert.ToDateTime(read["Datum"]).ToString();
			        comboBox2.Text = (read["Ellenorzo"].ToString());
			        comboBox3.Text = (read["Ki"].ToString());
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
			SqlCommand cmd = new SqlCommand(@"Update dbo.bmpa set POszam = @POszam, Anyagkod = @Anyagkod, Anyagnev = @Anyagnev, IBCtisztae = @IBCtisztae, IBCszam = @IBCszam, LastIBCszam = @LastIBCszam, Allomastisztae = @Allomastisztae, Elese = @Elese, Kimerteke = @Kimerteke, MegfeleloIBCe = @MegfeleloIBCe, AKLzsak = @AKLzsak, Csomomentese = @Csomomentese, Komment = @Komment, Datum = @Datum, Ellenorzo = @Ellenorzo, Ellenorizve = @Ellenorizve, Ki = @Ki 
			WHERE POszam LIKE ('" + comboBox1.Text +"%')",conn);
			cmd.Parameters.Add(new SqlParameter("@POszam", comboBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagkod", textBox1.Text));
			cmd.Parameters.Add(new SqlParameter("@Anyagnev", textBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@IBCtisztae", checkBox1.Checked));
			cmd.Parameters.Add(new SqlParameter("@IBCszam", textBox3.Text));
			cmd.Parameters.Add(new SqlParameter("@LastIBCszam", textBox4.Text));
			cmd.Parameters.Add(new SqlParameter("@Allomastisztae", checkBox2.Checked));
			cmd.Parameters.Add(new SqlParameter("@Elese", checkBox3.Checked));
			cmd.Parameters.Add(new SqlParameter("@Kimerteke", checkBox5.Checked));
			cmd.Parameters.Add(new SqlParameter("@MegfeleloIBCe", checkBox6.Checked));
			cmd.Parameters.Add(new SqlParameter("@AKLzsak", textBox5.Text));
			cmd.Parameters.Add(new SqlParameter("@Csomomentese", checkBox7.Checked));
			cmd.Parameters.Add(new SqlParameter("@Komment", textBox6.Text));
			cmd.Parameters.Add(new SqlParameter("@Datum", dateTimePicker1.Value.Date));
			cmd.Parameters.Add(new SqlParameter("@Ellenorzo", comboBox2.Text));
			cmd.Parameters.Add(new SqlParameter("@Ellenorizve", checkBox4.Checked));
			cmd.Parameters.Add(new SqlParameter("@Ki", comboBox3.Text));
			cmd.ExecuteNonQuery();
			conn.Close();
			MessageBox.Show("Sikeresen hozzáadtad a PO-t", "Üzenet"); 
		}
	}
}
